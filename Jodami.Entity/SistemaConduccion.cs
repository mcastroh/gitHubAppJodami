﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Jodami.Entity;

public partial class SistemaConduccion
{
    /// <summary>
    /// Sistema Conducción ID
    /// </summary>
    [Key]
    public int IdSistemaConduccion { get; set; }

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

    [InverseProperty("IdSistemaConduccionNavigation")]
    public virtual ICollection<CentroCosto> CentroCosto { get; set; } = new List<CentroCosto>();
}