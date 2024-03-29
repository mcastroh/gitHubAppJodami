﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Jodami.Entity;

[Table("Direccion ")]
public partial class Direccion_
{
    /// <summary>
    /// Dirección ID
    /// </summary>
    [Key]
    public int IdDireccion { get; set; }

    /// <summary>
    /// Socio ID
    /// </summary>
    public int IdSocio { get; set; }

    /// <summary>
    /// Tipo Direccón ID
    /// </summary>
    public int IdTipoDireccion { get; set; }

    /// <summary>
    /// Tipo Via ID
    /// </summary>
    public int IdTipoVia { get; set; }

    /// <summary>
    /// Nombre Tipo Via
    /// </summary>
    [StringLength(100)]
    public string NombreVia { get; set; }

    /// <summary>
    /// Número Tipo Via
    /// </summary>
    [StringLength(100)]
    public string NumeroVia { get; set; }

    /// <summary>
    /// Tipo Zona ID
    /// </summary>
    public int IdTipoZona { get; set; }

    /// <summary>
    /// Nombre Tipo Zona
    /// </summary>
    [StringLength(100)]
    public string NombreZona { get; set; }

    /// <summary>
    /// Distrito ID
    /// </summary>
    public int IdDistrito { get; set; }

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

    [InverseProperty("IdDireccionNavigation")]
    public virtual ICollection<Almacen> Almacen { get; set; } = new List<Almacen>();

    [InverseProperty("IdDireccionNavigation")]
    public virtual ICollection<Empresa> Empresa { get; set; } = new List<Empresa>();

    [InverseProperty("IdDireccionNavigation")]
    public virtual ICollection<EmpresaLocal> EmpresaLocal { get; set; } = new List<EmpresaLocal>();

    [ForeignKey("IdDistrito")]
    [InverseProperty("Direccion_")]
    public virtual Distrito IdDistritoNavigation { get; set; }

    [ForeignKey("IdTipoDireccion")]
    [InverseProperty("Direccion_")]
    public virtual TipoDireccion IdTipoDireccionNavigation { get; set; }

    [ForeignKey("IdTipoVia")]
    [InverseProperty("Direccion_")]
    public virtual TipoVia IdTipoViaNavigation { get; set; }

    [ForeignKey("IdTipoZona")]
    [InverseProperty("Direccion_")]
    public virtual TipoZona IdTipoZonaNavigation { get; set; }

    [InverseProperty("IdDireccionNavigation")]
    public virtual SocioDireccion_ SocioDireccion_ { get; set; }
}