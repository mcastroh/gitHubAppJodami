﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Jodami.Entity;

public partial class EmpresaLocal
{
    /// <summary>
    /// LocalID
    /// </summary>
    [Key]
    public int IdLocal { get; set; }

    /// <summary>
    /// Razón Social
    /// </summary>
    [Required]
    [StringLength(100)]
    public string RazonSocial { get; set; }

    /// <summary>
    /// Empresa ID
    /// </summary>
    public int IdEmpresa { get; set; }

    /// <summary>
    /// Dirección ID
    /// </summary>
    public int? IdDireccion { get; set; }

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

    [ForeignKey("IdDireccion")]
    [InverseProperty("EmpresaLocal")]
    public virtual Direccion_ IdDireccionNavigation { get; set; }

    [ForeignKey("IdEmpresa")]
    [InverseProperty("EmpresaLocal")]
    public virtual Empresa IdEmpresaNavigation { get; set; }
}