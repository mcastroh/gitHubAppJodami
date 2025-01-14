﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Jodami.Entity;

public partial class GrupoArticulo
{
    /// <summary>
    /// Grupo ID
    /// </summary>
    [Key]
    public int IdGrupoArticulo { get; set; }

    /// <summary>
    /// Código
    /// </summary>
    [Required]
    [StringLength(2)]
    public string Codigo { get; set; }

    /// <summary>
    /// Descripción
    /// </summary>
    [Required]
    [StringLength(100)]
    public string Descripcion { get; set; }

    /// <summary>
    /// ¿Es Activo?
    /// </summary>
    public bool Activo { get; set; }

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

    [InverseProperty("IdGrupoArticuloNavigation")]
    public virtual ICollection<SubGrupoArticulo> SubGrupoArticulo { get; set; } = new List<SubGrupoArticulo>();
}