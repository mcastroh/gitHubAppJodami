﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Jodami.Entity;

public partial class TipoFormaPago
{
    /// <summary>
    /// Tipo Forma Pago ID
    /// </summary>
    [Key]
    public int IdTipoFormaPago { get; set; }

    /// <summary>
    /// Código
    /// </summary>
    [Required]
    [StringLength(20)]
    public string Codigo { get; set; }

    /// <summary>
    /// Descripción
    /// </summary>
    [Required]
    [StringLength(100)]
    public string Descripcion { get; set; }

    /// <summary>
    /// Días de Pago
    /// </summary>
    public int DiasDePago { get; set; }

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

    [InverseProperty("IdTipoFormaPagoNavigation")]
    public virtual ICollection<SocioFormaPago> SocioFormaPago { get; set; } = new List<SocioFormaPago>();
}