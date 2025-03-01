﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Jodami.Entity;

public partial class Menu
{
    /// <summary>
    /// Menú ID
    /// </summary>
    [Key]
    public int IdMenu { get; set; }

    /// <summary>
    /// Descripción
    /// </summary>
    [StringLength(60)]
    public string Descripcion { get; set; }

    /// <summary>
    /// Menú Padre ID
    /// </summary>
    public int? IdMenuPadre { get; set; }

    /// <summary>
    /// Icono
    /// </summary>
    [StringLength(60)]
    public string Icono { get; set; }

    /// <summary>
    /// Controlador
    /// </summary>
    [StringLength(60)]
    public string Controlador { get; set; }

    /// <summary>
    /// Acción
    /// </summary>
    [StringLength(60)]
    public string PaginaAccion { get; set; }

    /// <summary>
    /// ¿Es Activo?
    /// </summary>
    public bool? EsActivo { get; set; }

    /// <summary>
    /// Auditoría Usuario
    /// </summary>
    [StringLength(60)]
    public string UsuarioName { get; set; }

    /// <summary>
    /// Auditoría Fecha
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? FechaRegistro { get; set; }

    [ForeignKey("IdMenuPadre")]
    [InverseProperty("InverseIdMenuPadreNavigation")]
    public virtual Menu IdMenuPadreNavigation { get; set; }

    [InverseProperty("IdMenuPadreNavigation")]
    public virtual ICollection<Menu> InverseIdMenuPadreNavigation { get; set; } = new List<Menu>();

    [InverseProperty("IdMenuNavigation")]
    public virtual ICollection<RolMenu> RolMenu { get; set; } = new List<RolMenu>();
}