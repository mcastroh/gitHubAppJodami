﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Jodami.Entity;

public partial class TipoMovimiento
{
    /// <summary>
    /// Tipo Movto ID
    /// </summary>
    [Key]
    public int IdTipoMovimiento { get; set; }

    /// <summary>
    /// Descripción
    /// </summary>
    [Required]
    [StringLength(60)]
    public string Descripcion { get; set; }

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

    [InverseProperty("IdTipoMovimientoNavigation")]
    public virtual ICollection<SubTipoMovimiento> SubTipoMovimiento { get; set; } = new List<SubTipoMovimiento>();

    [InverseProperty("IdTipoMovimientoNavigation")]
    public virtual ICollection<Ticket> Ticket { get; set; } = new List<Ticket>();
}