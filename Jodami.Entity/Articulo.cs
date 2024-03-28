﻿using System;
using System.Collections.Generic;

namespace Jodami.Entity;

public partial class Articulo
{
    /// <summary>
    /// Artículo ID
    /// </summary>
    public int IdArticulo { get; set; }

    /// <summary>
    /// Código Artículo
    /// </summary>
    public string CodigoArticulo { get; set; }

    /// <summary>
    /// Descripción
    /// </summary>
    public string Descripcion { get; set; }

    /// <summary>
    /// Sub Grupo Artículo ID
    /// </summary>
    public int IdSubGrupoArticulo { get; set; }

    /// <summary>
    /// Unidad Inventario ID
    /// </summary>
    public int? IdUnidadInventario { get; set; }

    /// <summary>
    /// Unidad Compra ID
    /// </summary>
    public int? IdUnidadCompra { get; set; }

    /// <summary>
    /// Unidad Venta ID
    /// </summary>
    public int? IdUnidadVenta { get; set; }

    /// <summary>
    /// Tipo Artículo ID
    /// </summary>
    public int? IdTipoArticulo { get; set; }

    /// <summary>
    /// Tipo Detracción Sunat ID
    /// </summary>
    public int? IdTipoDetraccion { get; set; }

    /// <summary>
    /// Tipo Valorización ID
    /// </summary>
    public int? IdTipoValorizacion { get; set; }

    /// <summary>
    /// Tipo Existencia Sunat ID
    /// </summary>
    public int? IdTipoExistencia { get; set; }

    /// <summary>
    /// Stock Mínimo
    /// </summary>
    public decimal StockMinimo { get; set; }

    /// <summary>
    /// Stock Máximo
    /// </summary>
    public decimal StockMaximo { get; set; }

    /// <summary>
    /// Stock de Seguridad
    /// </summary>
    public decimal StockSeguridad { get; set; }

    /// <summary>
    /// Observaciones
    /// </summary>
    public string Observaciones { get; set; }

    /// <summary>
    /// ¿Es Activo?
    /// </summary>
    public bool EsActivo { get; set; }

    /// <summary>
    /// Auditoría Usuario
    /// </summary>
    public string UsuarioName { get; set; }

    /// <summary>
    /// Auditoría Fecha
    /// </summary>
    public DateTime FechaRegistro { get; set; }

    public virtual ICollection<ArticuloImagen> ArticuloImagens { get; set; } = new List<ArticuloImagen>();

    public virtual SubGrupoArticulo IdSubGrupoArticuloNavigation { get; set; }

    public virtual TipoArticulo IdTipoArticuloNavigation { get; set; }

    public virtual SunatTipoDetraccion IdTipoDetraccionNavigation { get; set; }

    public virtual SunatTipoExistencium IdTipoExistenciaNavigation { get; set; }

    public virtual TipoValorizacion IdTipoValorizacionNavigation { get; set; }

    public virtual UnidadMedida IdUnidadCompraNavigation { get; set; }

    public virtual UnidadMedida IdUnidadInventarioNavigation { get; set; }

    public virtual UnidadMedida IdUnidadVentaNavigation { get; set; }

    public virtual ICollection<SocioPrecioArticulo> SocioPrecioArticulos { get; set; } = new List<SocioPrecioArticulo>();

    public virtual ICollection<TicketPesaje> TicketPesajes { get; set; } = new List<TicketPesaje>();
}
