﻿using System;
using System.Collections.Generic;

namespace Jodami.Entity;

public partial class SunatTipoDetraccion
{
    /// <summary>
    /// Tipo Detracción ID
    /// </summary>
    public int IdTipoDetraccion { get; set; }

    /// <summary>
    /// Código
    /// </summary>
    public string Codigo { get; set; }

    /// <summary>
    /// Descripción
    /// </summary>
    public string Descripcion { get; set; }

    /// <summary>
    /// Porcentaje
    /// </summary>
    public decimal Porcentaje { get; set; }

    /// <summary>
    /// Condición
    /// </summary>
    public string Condicion { get; set; }

    /// <summary>
    /// Valor
    /// </summary>
    public decimal Valor { get; set; }

    /// <summary>
    /// Unidad UIT - S/.
    /// </summary>
    public string Unidad { get; set; }

    /// <summary>
    /// ¿Es Activo?
    /// </summary>
    public bool Activo { get; set; }

    /// <summary>
    /// Auditoría Fecha
    /// </summary>
    public string UsuarioName { get; set; }

    /// <summary>
    /// Auditoría Fecha
    /// </summary>
    public DateTime FechaRegistro { get; set; }

    public virtual ICollection<Articulo> Articulos { get; set; } = new List<Articulo>();
}
