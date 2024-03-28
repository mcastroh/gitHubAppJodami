﻿using System;
using System.Collections.Generic;

namespace Jodami.Entity;

public partial class TicketPesaje
{
    /// <summary>
    /// Ticket Pesaje ID
    /// </summary>
    public int IdTicketPesaje { get; set; }

    /// <summary>
    /// Ticket ID
    /// </summary>
    public int IdTicket { get; set; }

    /// <summary>
    /// Nro Pesaje
    /// </summary>
    public int NumeroPesaje { get; set; }

    /// <summary>
    /// Artículo ID
    /// </summary>
    public int? IdArticulo { get; set; }

    /// <summary>
    /// Peso Balanza
    /// </summary>
    public decimal PesoBalanza { get; set; }

    /// <summary>
    /// Unidad Pesaje
    /// </summary>
    public int IdUnidad { get; set; }

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

    public virtual Articulo IdArticuloNavigation { get; set; }

    public virtual Ticket IdTicketNavigation { get; set; }
}
