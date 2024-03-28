﻿using System;
using System.Collections.Generic;

namespace Jodami.Entity;

public partial class TipoMovimiento
{
    /// <summary>
    /// Tipo Movto ID
    /// </summary>
    public int IdTipoMovimiento { get; set; }

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

    public virtual ICollection<SubTipoMovimiento> SubTipoMovimientos { get; set; } = new List<SubTipoMovimiento>();

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}
