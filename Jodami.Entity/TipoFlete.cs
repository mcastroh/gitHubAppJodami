﻿using System;
using System.Collections.Generic;

namespace Jodami.Entity;

public partial class TipoFlete
{
    /// <summary>
    /// Tipo Flete ID
    /// </summary>
    public int IdFlete { get; set; }

    /// <summary>
    /// Código
    /// </summary>
    public string Codigo { get; set; }

    /// <summary>
    /// Descripción
    /// </summary>
    public string Descripcion { get; set; }

    /// <summary>
    /// ¿Es Activo?
    /// </summary>
    public bool EsActivo { get; set; }

    /// <summary>
    /// Auditoría Usuario
    /// </summary>
    public string UsuarioName { get; set; }

    /// <summary>
    /// Auditoría Fecha
    /// </summary>
    public DateTime FechaRegistro { get; set; }

    public virtual ICollection<Vehiculo> Vehiculos { get; set; } = new List<Vehiculo>();
}
