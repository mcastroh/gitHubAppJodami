﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Jodami.Entity;

public partial class SocioCuentaBanco
{
    /// <summary>
    /// Cuenta Bancaria ID
    /// </summary>
    [Key]
    public int IdCuenta { get; set; }

    /// <summary>
    /// Socio ID
    /// </summary>
    public int IdSocio { get; set; }

    /// <summary>
    /// Entidad Financiera ID
    /// </summary>
    public int IdEntidadFinanciera { get; set; }

    /// <summary>
    /// Moneda ID
    /// </summary>
    public int IdMoneda { get; set; }

    /// <summary>
    /// Tipo Cta Bancaria ID
    /// </summary>
    public int IdTipoCuentaBancaria { get; set; }

    /// <summary>
    /// Código Cuenta
    /// </summary>
    [Required]
    [StringLength(50)]
    public string CodigoCuenta { get; set; }

    /// <summary>
    /// Código Cuenta Interbancaria
    /// </summary>
    [Required]
    [StringLength(50)]
    public string CodigoCuentaInterbancaria { get; set; }

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

    [ForeignKey("IdEntidadFinanciera")]
    [InverseProperty("SocioCuentaBanco")]
    public virtual EntidadFinanciera IdEntidadFinancieraNavigation { get; set; }

    [ForeignKey("IdMoneda")]
    [InverseProperty("SocioCuentaBanco")]
    public virtual Moneda IdMonedaNavigation { get; set; }

    [ForeignKey("IdSocio")]
    [InverseProperty("SocioCuentaBanco")]
    public virtual Socio IdSocioNavigation { get; set; }

    [ForeignKey("IdTipoCuentaBancaria")]
    [InverseProperty("SocioCuentaBanco")]
    public virtual TipoCuentaBancaria IdTipoCuentaBancariaNavigation { get; set; }
}