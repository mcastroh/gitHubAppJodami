﻿using AutoMapper;
using Jodami.AppWeb.Models.ViewModels;
using Jodami.BLL.Interfaces;
using Jodami.Entity;
using Microsoft.AspNetCore.Mvc;
using Rotativa.AspNetCore;

namespace Jodami.AppWeb.Controllers
{
    public class TipoAlmacenController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IGenericService<TipoAlmacen> _service;

        #region Constructor 

        public TipoAlmacenController(IMapper mapper, IGenericService<TipoAlmacen> service)
        {
            _mapper = mapper;
            _service = service;
        }
        #endregion 

        #region HttpGet => Index  

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var query = _mapper.Map<List<VMTipoAlmacen>>(await _service.GetAll());
            return View(query);
        }

        #endregion

        #region Adicionar => HttpPost

        [HttpPost]
        public async Task<IActionResult> Adicionar(string codigo, string descripcion)
        {
            var modelo = new TipoAlmacen()
            {
                Descripcion = descripcion,
                Codigo = codigo,
                EsActivo = true,
                UsuarioName = "Admin",
                FechaRegistro = DateTime.Now
            };

            var entity = await _service.Insert(modelo);
            return RedirectToAction("Index");
        }

        #endregion

        #region Edit => HttpPost 

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(VMTipoAlmacen vmModelo)
        {
            var modelo = await _service.GetById(x => x.IdTipoAlmacen == vmModelo.IdTipoAlmacen);

            modelo.Descripcion = vmModelo.Descripcion;
            modelo.Codigo = vmModelo.Codigo;
            modelo.EsActivo = vmModelo.EsActivo;
            modelo.UsuarioName = "Admin";
            modelo.FechaRegistro = DateTime.Now;

            bool flgRetorno = await _service.Update(modelo);
            return RedirectToAction("Index");
        }

        #endregion

        #region Eliminar => HttpPost

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Eliminar(VMTipoAlmacen vmModelo)
        {
            bool flgRetorno = await _service.Delete(x => x.IdTipoAlmacen == vmModelo.IdTipoAlmacen);
            return RedirectToAction("Index");
        }

        #endregion

        #region Método  => Listar PDF   

        public async Task<IActionResult> ListarPDF()
        {
            var query = _mapper.Map<List<VMTipoAlmacen>>(await _service.GetAll());

            string titulo = "Tipos de Almacenes";
            string protocolo = Request.IsHttps ? "Https" : "Http";
            string headerAction = Url.Action("Header", "Home", new { titulo }, protocolo);
            string footerAction = Url.Action("Footer", "Home", new { }, protocolo);

            return new ViewAsPdf("ListarPDF", query)
            {
                FileName = $"Tipos de Almacenes {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}.pdf",
                PageOrientation = Rotativa.AspNetCore.Options.Orientation.Portrait,
                PageSize = Rotativa.AspNetCore.Options.Size.A4,
                PageMargins = { Left = 15, Bottom = 10, Right = 15, Top = 30 },
                CustomSwitches = $"--header-html {headerAction} --header-spacing 2 --footer-html {footerAction} --footer-spacing 2"
            };
        }

        #endregion

    }
}
