﻿using System;
using System.Collections.Generic;

namespace Jodami.Entity;

public partial class Menu
{
    /// <summary>
    /// Menú ID
    /// </summary>
    public int IdMenu { get; set; }

    /// <summary>
    /// Descripción
    /// </summary>
    public string Descripcion { get; set; }

    /// <summary>
    /// Menú Padre ID
    /// </summary>
    public int? IdMenuPadre { get; set; }

    /// <summary>
    /// Icono
    /// </summary>
    public string Icono { get; set; }

    /// <summary>
    /// Controlador
    /// </summary>
    public string Controlador { get; set; }

    /// <summary>
    /// Acción
    /// </summary>
    public string PaginaAccion { get; set; }

    /// <summary>
    /// ¿Es Activo?
    /// </summary>
    public bool? EsActivo { get; set; }

    /// <summary>
    /// Auditoría Usuario
    /// </summary>
    public string UsuarioName { get; set; }

    /// <summary>
    /// Auditoría Fecha
    /// </summary>
    public DateTime? FechaRegistro { get; set; }

    public virtual Menu IdMenuPadreNavigation { get; set; }

    public virtual ICollection<Menu> InverseIdMenuPadreNavigation { get; set; } = new List<Menu>();

    public virtual ICollection<RolMenu> RolMenus { get; set; } = new List<RolMenu>();
}
