﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Jodami.Entity;

public partial class Socio
{
    /// <summary>
    /// Socio ID
    /// </summary>
    [Key]
    public int IdSocio { get; set; }

    /// <summary>
    /// Tipo Socio ID
    /// </summary>
    public int IdTipoSocio { get; set; }

    /// <summary>
    /// Tipo Dcmto Identidad ID
    /// </summary>
    public int IdTipoDcmtoIdentidad { get; set; }

    /// <summary>
    /// Número Dcmto Identidad
    /// </summary>
    [Required]
    [StringLength(20)]
    public string NumeroDcmtoIdentidad { get; set; }

    /// <summary>
    /// Apellido Paterno
    /// </summary>
    [StringLength(100)]
    public string ApellidoPaterno { get; set; }

    /// <summary>
    /// Apellido Materno
    /// </summary>
    [StringLength(100)]
    public string ApellidoMaterno { get; set; }

    /// <summary>
    /// Primer Nombre
    /// </summary>
    [StringLength(100)]
    public string PrimerNombre { get; set; }

    /// <summary>
    /// Segundo Nombre
    /// </summary>
    [StringLength(100)]
    public string SegundoNombre { get; set; }

    /// <summary>
    /// Razón Social
    /// </summary>
    [StringLength(100)]
    public string RazonSocial { get; set; }

    /// <summary>
    /// Grupo Económico ID
    /// </summary>
    public int? IdGrupoSocioNegocio { get; set; }

    /// <summary>
    /// Teléfono
    /// </summary>
    [StringLength(20)]
    public string Telefono { get; set; }

    /// <summary>
    /// Celular
    /// </summary>
    [StringLength(20)]
    public string Celular { get; set; }

    /// <summary>
    /// Página Web
    /// </summary>
    [StringLength(100)]
    public string PaginaWeb { get; set; }

    /// <summary>
    /// Email
    /// </summary>
    [StringLength(100)]
    public string Email { get; set; }

    /// <summary>
    /// Límite Crédito
    /// </summary>
    [Column(TypeName = "decimal(13, 2)")]
    public decimal LimiteCredito { get; set; }

    /// <summary>
    /// Sobregiros
    /// </summary>
    [Column(TypeName = "decimal(13, 2)")]
    public decimal Sobregiro { get; set; }

    /// <summary>
    /// ¿Afecto a Retención?
    /// </summary>
    public bool IsAfectoRetencion { get; set; }

    /// <summary>
    /// ¿Afecto a Percepción?
    /// </summary>
    public bool IsAfectoPercepcion { get; set; }

    /// <summary>
    /// ¿Buen Contribuyente?
    /// </summary>
    public bool IsBuenContribuyente { get; set; }

    /// <summary>
    /// Tipo Calificación ID
    /// </summary>
    public int? IdTipoCalificacion { get; set; }

    /// <summary>
    /// Zona Postal
    /// </summary>
    [StringLength(10)]
    public string ZonaPostal { get; set; }

    /// <summary>
    /// Fecha Inicio Operaciones
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? FechaInicioOperaciones { get; set; }

    /// <summary>
    /// Tipo Motivo Baja ID
    /// </summary>
    public int? IdTipoMotivoBaja { get; set; }

    /// <summary>
    /// Fecha Baja
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? FechaBaja { get; set; }

    /// <summary>
    /// ¿Es Activo?
    /// </summary>
    public bool EsActivo { get; set; }

    /// <summary>
    /// Auditoría Usuario
    /// </summary>
    [Required]
    [StringLength(60)]
    public string UsuarioName { get; set; }

    /// <summary>
    /// Auditoría Fecha
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime FechaRegistro { get; set; }

    [InverseProperty("IdResponsableNavigation")]
    public virtual ICollection<Almacen> Almacen { get; set; } = new List<Almacen>();

    [ForeignKey("IdGrupoSocioNegocio")]
    [InverseProperty("InverseIdGrupoSocioNegocioNavigation")]
    public virtual Socio IdGrupoSocioNegocioNavigation { get; set; }

    [ForeignKey("IdTipoCalificacion")]
    [InverseProperty("Socio")]
    public virtual TipoCalificacion IdTipoCalificacionNavigation { get; set; }

    [ForeignKey("IdTipoDcmtoIdentidad")]
    [InverseProperty("Socio")]
    public virtual TipoDocumentoIdentidad IdTipoDcmtoIdentidadNavigation { get; set; }

    [ForeignKey("IdTipoMotivoBaja")]
    [InverseProperty("Socio")]
    public virtual TipoMotivoBaja IdTipoMotivoBajaNavigation { get; set; }

    [ForeignKey("IdTipoSocio")]
    [InverseProperty("Socio")]
    public virtual TipoSocio IdTipoSocioNavigation { get; set; }

    [InverseProperty("IdGrupoSocioNegocioNavigation")]
    public virtual ICollection<Socio> InverseIdGrupoSocioNegocioNavigation { get; set; } = new List<Socio>();

    [InverseProperty("IdSocioNavigation")]
    public virtual ICollection<SocioCuentaBanco> SocioCuentaBanco { get; set; } = new List<SocioCuentaBanco>();

    [InverseProperty("Socio")]
    public virtual ICollection<SocioDireccion_> SocioDireccion_ { get; set; } = new List<SocioDireccion_>();

    [InverseProperty("IdSocioNavigation")]
    public virtual ICollection<SocioFormaPago> SocioFormaPago { get; set; } = new List<SocioFormaPago>();

    [InverseProperty("IdSocioNavigation")]
    public virtual ICollection<SocioPrecioArticulo> SocioPrecioArticulo { get; set; } = new List<SocioPrecioArticulo>();
}