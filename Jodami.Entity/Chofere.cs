﻿using System;
using System.Collections.Generic;

namespace Jodami.Entity;

public partial class Chofere
{
    /// <summary>
    /// Chofer ID
    /// </summary>
    public int IdChofer { get; set; }

    /// <summary>
    /// Tipo Dcmto Identidad ID
    /// </summary>
    public int IdTipoDcmto { get; set; }

    /// <summary>
    /// Nro Dcmto Identidad
    /// </summary>
    public string NumeroDcmto { get; set; }

    /// <summary>
    /// Nombres
    /// </summary>
    public string Nombre { get; set; }

    /// <summary>
    /// Licencia
    /// </summary>
    public string Licencia { get; set; }

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

    public virtual TipoDocumentoIdentidad IdTipoDcmtoNavigation { get; set; }
}
