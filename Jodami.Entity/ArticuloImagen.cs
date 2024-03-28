﻿using System;
using System.Collections.Generic;

namespace Jodami.Entity;

public partial class ArticuloImagen
{
    /// <summary>
    /// Artículo Imagen ID
    /// </summary>
    public int IdArticuloImagen { get; set; }

    /// <summary>
    /// Artículo ID
    /// </summary>
    public int IdArticulo { get; set; }

    /// <summary>
    /// Imagen
    /// </summary>
    public byte[] Imagen { get; set; }

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
}
