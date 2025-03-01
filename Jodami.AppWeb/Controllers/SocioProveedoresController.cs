﻿using AutoMapper;
using Jodami.AppWeb.Models.ViewModels;
using Jodami.AppWeb.Utilidades.Infraestructura;
using Jodami.AppWeb.Utilidades.Servicios;
using Jodami.BLL.Interfaces;
using Jodami.DAL.DBContext;
using Jodami.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rotativa.AspNetCore;

namespace Jodami.AppWeb.Controllers
{
    public class SocioProveedoresController : Controller
    {
        #region Variables 

        private readonly DbJodamiContext _contexto;
        private readonly IGenericService<Socio> _srvSocio;
        private readonly Usuario _sessionUsuario;
        private readonly IGenericService<TipoDocumentoIdentidad> _srvTipoDcmtoIdentidad;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMapper _mapper;

        #endregion

        #region Constructor 

        public SocioProveedoresController(
            DbJodamiContext contexto,
            IGenericService<Socio> srvSocio,
            IGenericService<TipoDocumentoIdentidad> srvTipoDcmtoIdentidad,
            IHttpContextAccessor httpContextAccessor,
            IMapper mapper
           )
        {
            _contexto = contexto;
            _srvSocio = srvSocio;
            _srvTipoDcmtoIdentidad = srvTipoDcmtoIdentidad;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
            _sessionUsuario = System.Text.Json.JsonSerializer.Deserialize<Usuario>(_httpContextAccessor.HttpContext.Session.GetString("sessionUsuario"));
        }

        #endregion 

        #region HttpGet => Index  

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var query = await ETL_SociosComerciales();
            return View(query);
        }

        #endregion

        #region HttpGet => Adicionar  

        [HttpGet]
        public async Task<IActionResult> Adicionar()
        {
            var entity = await Etl_SociosProveedores(0);
            return View(entity);
        }

        #endregion

        #region Adicionar => HttpPost 

        [HttpPost]
        public async Task<IActionResult> Adicionar(VMSociosProveedores vmSocio)
        {
            var keyRUC = (await _srvTipoDcmtoIdentidad.GetById(x => x.Simbolo == KeysNames.TIPO_DCMTO_IDENTIDAD_RUC)).IdTipoDcmtoIdentidad;

            var socio = new Socio()
            {
                IdTipoSocio = vmSocio.IdTipoSocio,
                IdTipoDcmtoIdentidad = vmSocio.IdTipoDcmtoIdentidadAsignado,
                NumeroDcmtoIdentidad = vmSocio.NumeroDcmtoIdentidad,
                RazonSocial = keyRUC == vmSocio.IdTipoDcmtoIdentidadAsignado ? vmSocio.RazonSocial : string.Empty,
                ApellidoPaterno = keyRUC != vmSocio.IdTipoDcmtoIdentidadAsignado ? vmSocio.ApellidoPaterno : string.Empty,
                ApellidoMaterno = keyRUC != vmSocio.IdTipoDcmtoIdentidadAsignado ? vmSocio.ApellidoMaterno : string.Empty,
                PrimerNombre = keyRUC != vmSocio.IdTipoDcmtoIdentidadAsignado ? vmSocio.PrimerNombre : string.Empty,
                SegundoNombre = keyRUC != vmSocio.IdTipoDcmtoIdentidadAsignado ? vmSocio.SegundoNombre : string.Empty,
                Telefono = vmSocio.Telefono,
                Celular = vmSocio.Celular,
                PaginaWeb = vmSocio.PaginaWeb,
                Email = vmSocio.Email,
                IsAfectoRetencion = vmSocio.IsAfectoRetencion,
                IsAfectoPercepcion = vmSocio.IsAfectoPercepcion,
                IsBuenContribuyente = vmSocio.IsBuenContribuyente,
                IdTipoCalificacion = vmSocio.IdTipoCalificacion,
                ZonaPostal = vmSocio.ZonaPostal,
                FechaInicioOperaciones = vmSocio.FechaInicioOperaciones.HasValue ? vmSocio.FechaInicioOperaciones.Value : null,
                IdGrupoSocioNegocio = vmSocio.IdGrupoSocioNegocio.HasValue ? vmSocio.IdGrupoSocioNegocio : null,
                IdColaboradorAsignado = vmSocio.IdColaboradorAsignado.HasValue ? vmSocio.IdColaboradorAsignado : null,
                EsActivo = true,
                UsuarioName = _sessionUsuario.Nombre,
                FechaRegistro = DateTime.Now
            };

            var entity = await _srvSocio.Insert(socio);
            return RedirectToAction("Index");
        }

        #endregion

        #region Edit => HttpGet 

        [HttpGet]
        public async Task<IActionResult> Editar(int idSocio, string mensaje = null)
        {
            if (mensaje is not null)
                ViewBag.Mensaje = mensaje;

            var entity = await Etl_SociosProveedores(idSocio);
            return View("Editar", entity);
        }

        #endregion

        #region Edit => HttpPost 

        [HttpPost]
        public async Task<IActionResult> Editar(VMSociosProveedores modelo)
        {
            try
            {
                var keyRUC = (await _srvTipoDcmtoIdentidad.GetById(x => x.Simbolo == KeysNames.TIPO_DCMTO_IDENTIDAD_RUC)).IdTipoDcmtoIdentidad;
                var socio = await _srvSocio.GetById(x => x.IdSocio == modelo.IdSocio);

                socio.IdTipoSocio = modelo.IdTipoSocio;
                socio.IdTipoDcmtoIdentidad = modelo.IdTipoDcmtoIdentidadAsignado;
                socio.NumeroDcmtoIdentidad = modelo.NumeroDcmtoIdentidad;
                socio.RazonSocial = keyRUC == modelo.IdTipoDcmtoIdentidadAsignado ? modelo.RazonSocial : string.Empty;
                socio.ApellidoPaterno = keyRUC != modelo.IdTipoDcmtoIdentidadAsignado ? modelo.ApellidoPaterno : string.Empty;
                socio.ApellidoMaterno = keyRUC != modelo.IdTipoDcmtoIdentidadAsignado ? modelo.ApellidoMaterno : string.Empty;
                socio.PrimerNombre = keyRUC != modelo.IdTipoDcmtoIdentidadAsignado ? modelo.PrimerNombre : string.Empty;
                socio.SegundoNombre = keyRUC != modelo.IdTipoDcmtoIdentidadAsignado ? modelo.SegundoNombre : string.Empty;
                socio.Telefono = modelo.Telefono;
                socio.Celular = modelo.Celular;
                socio.Email = modelo.Email;
                socio.PaginaWeb = modelo.PaginaWeb;
                socio.IsAfectoRetencion = modelo.IsAfectoRetencion;
                socio.IsAfectoPercepcion = modelo.IsAfectoPercepcion;
                socio.IsBuenContribuyente = modelo.IsBuenContribuyente;
                socio.IdTipoCalificacion = modelo.IdTipoCalificacion;
                socio.ZonaPostal = modelo.ZonaPostal;
                socio.FechaInicioOperaciones = modelo.FechaInicioOperaciones.HasValue ? modelo.FechaInicioOperaciones.Value : null;
                socio.IdGrupoSocioNegocio = modelo.IdGrupoSocioNegocio.HasValue ? modelo.IdGrupoSocioNegocio : null;
                socio.IdColaboradorAsignado = modelo.IdColaboradorAsignado.HasValue ? modelo.IdColaboradorAsignado : null;
                socio.EsActivo = modelo.EsActivo;
                socio.UsuarioName = _sessionUsuario.Nombre;
                socio.FechaRegistro = DateTime.Now;

                bool flgRetorno = await _srvSocio.Update(socio);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                string msge = ex.Message;
                var qq = ex.InnerException.Message;
                return RedirectToAction("Editar", new { idSocio = modelo.IdSocio, mensaje = ex.InnerException.Message });
            }
        }

        #endregion

        #region Eliminar => HttpGet

        [HttpGet]
        public async Task<IActionResult> Eliminar(int idSocio, string mensaje = null)
        {
            if (mensaje is not null)
                ViewBag.Mensaje = mensaje;

            var entity = await Etl_SociosProveedores(idSocio);
            return View("Eliminar", entity);
        }

        #endregion

        #region Eliminar => HttpPost

        [HttpPost]
        public async Task<IActionResult> Eliminar(VMSociosProveedores modelo)
        {
            try
            {
                bool flgRetorno = await _srvSocio.Delete(x => x.IdSocio == modelo.IdSocio);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                string msge = ex.Message;
                var qq = ex.InnerException.Message;
                return RedirectToAction("Eliminar", new { idSocio = modelo.IdSocio, mensaje = ex.InnerException.Message });
            }
        }

        #endregion

        #region Método  => Listar PDF   

        public async Task<IActionResult> ListarPDF()
        {
            var query = await ETL_SociosComerciales();

            string titulo = "Proveedores";
            string protocolo = Request.IsHttps ? "Https" : "Http";
            string headerAction = Url.Action("Header", "Home", new { titulo }, protocolo);
            string footerAction = Url.Action("Footer", "Home", new { }, protocolo);

            return new ViewAsPdf("ListarPDF", query)
            {
                FileName = $"Proveedores {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}.pdf",
                PageOrientation = Rotativa.AspNetCore.Options.Orientation.Portrait,
                PageSize = Rotativa.AspNetCore.Options.Size.A4,
                PageMargins = { Left = 15, Bottom = 10, Right = 15, Top = 30 },
                CustomSwitches = $"--header-html {headerAction} --header-spacing 2 --footer-html {footerAction} --footer-spacing 2"
            };
        }

        #endregion

        #region ETL => Nuevo/Editar/Eliminar Proveedor

        private async Task<VMSociosProveedores> Etl_SociosProveedores(int idSocio)
        {
            var entity = new VMSociosProveedores();

            var svtTD = new ServicioTiposDeDocumentos(_srvTipoDcmtoIdentidad);

            var tipoDocumentoIdentidad = await svtTD.SrvTiposDeDocumentos();
            var tipoSocioGruposEconomicos = await _contexto.TipoSocio.AsNoTracking().FirstOrDefaultAsync(x => x.Codigo == KeysNames.GRUPOS_ECONOMICOS);
            var tipoSocioColaboradores = await _contexto.TipoSocio.AsNoTracking().FirstOrDefaultAsync(x => x.Codigo == KeysNames.COLABORADORES);
            var tipoSocioProveedores = await _contexto.TipoSocio.AsNoTracking().FirstOrDefaultAsync(x => x.Codigo == KeysNames.PROVEEDORES);

            var entityGruposEconomicos = _mapper.Map<List<VMSociosGrupos>>(await _contexto.Socio.AsNoTracking().Where(x => x.IdTipoSocio == tipoSocioGruposEconomicos.IdTipoSocio).ToListAsync());
            var entityColaboradores = _mapper.Map<List<VMSociosColaboradores>>(await _contexto.Socio.AsNoTracking().Where(x => x.IdTipoSocio == tipoSocioColaboradores.IdTipoSocio).ToListAsync());
            var entityTipoCalificacion = _mapper.Map<List<VMTipoCalificacion>>(await _contexto.TipoCalificacion.ToListAsync());

            foreach (var item in entityTipoCalificacion)
            {
                item.CodigoAndDescripcion = item.Codigo + " - " + item.Descripcion;
            }

            foreach (var item in entityColaboradores)
            {
                item.ApellidosAndNombres = item.ApellidoPaterno + " " + item.ApellidoMaterno + " " + item.PrimerNombre + " " + item.SegundoNombre;
            }

            if (idSocio == 0)
            {
                entity = new VMSociosProveedores()
                {
                    IdTipoSocio = tipoSocioProveedores.IdTipoSocio,
                    IdTipoDcmtoIdentidadAsignado = tipoDocumentoIdentidad.FirstOrDefault(x => x.Simbolo == KeysNames.TIPO_DCMTO_IDENTIDAD_RUC).IdTipoDcmtoIdentidad,
                    CodigoTipoDcmto = tipoDocumentoIdentidad.FirstOrDefault(x => x.Simbolo == KeysNames.TIPO_DCMTO_IDENTIDAD_RUC).Simbolo,
                    NameTipoDcmto = tipoDocumentoIdentidad.FirstOrDefault(x => x.Simbolo == KeysNames.TIPO_DCMTO_IDENTIDAD_RUC).Descripcion,
                    TiposDcmtoIdentidad = tipoDocumentoIdentidad,
                    KeyIdTipoDcmtoIdentidadRUC = tipoDocumentoIdentidad.FirstOrDefault(x => x.Simbolo == KeysNames.TIPO_DCMTO_IDENTIDAD_RUC).IdTipoDcmtoIdentidad,
                    nav_GrupoEconomico = entityGruposEconomicos,
                    nav_Colaboradores = entityColaboradores,
                    nav_Calificacion = entityTipoCalificacion
                };
            }
            else
            {
                var modelo = await _contexto.Socio.AsNoTracking().FirstOrDefaultAsync(x => x.IdSocio == idSocio);

                entity = new VMSociosProveedores()
                {
                    IdTipoSocio = modelo.IdTipoSocio,
                    IdTipoDcmtoIdentidad = modelo.IdTipoDcmtoIdentidad,
                    IdTipoDcmtoIdentidadAsignado = modelo.IdTipoDcmtoIdentidad,
                    NumeroDcmtoIdentidad = modelo.NumeroDcmtoIdentidad,
                    RazonSocial = modelo.RazonSocial,
                    ApellidoPaterno = modelo.ApellidoPaterno,
                    ApellidoMaterno = modelo.ApellidoMaterno,
                    PrimerNombre = modelo.PrimerNombre,
                    SegundoNombre = modelo.SegundoNombre,
                    Telefono = modelo.Telefono,
                    Celular = modelo.Celular,
                    PaginaWeb = modelo.PaginaWeb,
                    Email = modelo.Email,
                    IsAfectoRetencion = modelo.IsAfectoRetencion,
                    IsAfectoPercepcion = modelo.IsAfectoPercepcion,
                    IsBuenContribuyente = modelo.IsBuenContribuyente,
                    IdTipoCalificacion = modelo.IdTipoCalificacion,
                    ZonaPostal = modelo.ZonaPostal,
                    FechaInicioOperaciones = modelo.FechaInicioOperaciones.HasValue ? modelo.FechaInicioOperaciones.Value : null,
                    FechaBaja = modelo.FechaBaja.HasValue ? modelo.FechaBaja.Value : null,
                    IdTipoMotivoBaja = modelo.IdTipoMotivoBaja.HasValue ? modelo.IdTipoMotivoBaja.Value : null,
                    IdGrupoSocioNegocio = modelo.IdGrupoSocioNegocio.HasValue ? modelo.IdGrupoSocioNegocio : null,
                    IdColaboradorAsignado = modelo.IdColaboradorAsignado.HasValue ? modelo.IdColaboradorAsignado : null,
                    TiposDcmtoIdentidad = tipoDocumentoIdentidad,
                    EsActivo = modelo.EsActivo,
                    nav_GrupoEconomico = entityGruposEconomicos,
                    nav_Colaboradores = entityColaboradores,
                    nav_Calificacion = entityTipoCalificacion
                };
            }

            return entity;
        }

        #endregion

        #region ETL => Index Proveedores

        public async Task<List<VMSociosProveedores>> ETL_SociosComerciales()
        {
            var svtTD = new ServicioTiposDeDocumentos(_srvTipoDcmtoIdentidad);
            var tipoDocumentoIdentidad = await svtTD.SrvTiposDeDocumentos();

            var tipoSocioGruposEconomicos = await _contexto.TipoSocio.AsNoTracking().FirstOrDefaultAsync(x => x.Codigo == KeysNames.GRUPOS_ECONOMICOS);
            var tipoSocioColaboradores = await _contexto.TipoSocio.AsNoTracking().FirstOrDefaultAsync(x => x.Codigo == KeysNames.COLABORADORES);
            var tipoSocioProveedores = await _contexto.TipoSocio.AsNoTracking().FirstOrDefaultAsync(x => x.Codigo == KeysNames.PROVEEDORES);

            var entityGruposEconomicos = _mapper.Map<List<VMSociosGrupos>>(await _contexto.Socio.AsNoTracking().Where(x => x.IdTipoSocio == tipoSocioGruposEconomicos.IdTipoSocio).ToListAsync());
            var entityColaboradores = _mapper.Map<List<VMSociosColaboradores>>(await _contexto.Socio.AsNoTracking().Where(x => x.IdTipoSocio == tipoSocioColaboradores.IdTipoSocio).ToListAsync());
            var entityProveedores = _mapper.Map<List<VMSociosProveedores>>(await _contexto.Socio.AsNoTracking().Where(x => x.IdTipoSocio == tipoSocioProveedores.IdTipoSocio).ToListAsync());

            var entityTipoCalificacion = _mapper.Map<List<VMTipoCalificacion>>(await _contexto.TipoCalificacion.ToListAsync());

            foreach (var item in entityTipoCalificacion)
            {
                item.CodigoAndDescripcion = item.Codigo + " - " + item.Descripcion;
            }

            foreach (var item in entityColaboradores)
            {
                item.ApellidosAndNombres = item.ApellidoPaterno + " " + item.ApellidoMaterno + " " + item.PrimerNombre + " " + item.SegundoNombre;
            }

            foreach (var item in entityProveedores)
            {
                item.IdTipoDcmtoIdentidadAsignado = item.IdTipoDcmtoIdentidad;
                item.CodigoTipoDcmto = tipoDocumentoIdentidad.FirstOrDefault(x => x.IdTipoDcmtoIdentidad == item.IdTipoDcmtoIdentidad).Simbolo;
                item.NameTipoDcmto = tipoDocumentoIdentidad.FirstOrDefault(x => x.IdTipoDcmtoIdentidad == item.IdTipoDcmtoIdentidad).Descripcion;
                item.TiposDcmtoIdentidad = tipoDocumentoIdentidad;
                item.NombreRazonSocial = item.CodigoTipoDcmto == KeysNames.TIPO_DCMTO_IDENTIDAD_RUC ? item.RazonSocial : item.ApellidoPaterno + " " + item.ApellidoMaterno + "" + item.PrimerNombre + "" + item.SegundoNombre;
                item.nav_GrupoEconomico = entityGruposEconomicos;
                item.nav_Colaboradores = entityColaboradores;
                item.nav_Calificacion = entityTipoCalificacion;
            }

            ViewBag.TipoDocumentoIdentidad = tipoDocumentoIdentidad.ToList();
            ViewBag.TipoSocio = tipoSocioProveedores;
            ViewBag.DcmtoDefault = tipoDocumentoIdentidad.FirstOrDefault(x => x.Simbolo == KeysNames.TIPO_DCMTO_IDENTIDAD_RUC);

            ViewBag.GrupoEconomico = entityGruposEconomicos.ToList();
            ViewBag.Colaboradores = entityColaboradores.ToList();
            ViewBag.Calificacion = entityTipoCalificacion.ToList();

            return entityProveedores;
        }

        #endregion

    }
}