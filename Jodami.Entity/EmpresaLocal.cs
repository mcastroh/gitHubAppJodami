﻿using System;
using System.Collections.Generic;

namespace Jodami.Entity;

public partial class EmpresaLocal
{
    /// <summary>
    /// LocalID
    /// </summary>
    public int IdLocal { get; set; }

    /// <summary>
    /// Razón Social
    /// </summary>
    public string RazonSocial { get; set; }

    /// <summary>
    /// Empresa ID
    /// </summary>
    public int IdEmpresa { get; set; }

    /// <summary>
    /// Dirección ID
    /// </summary>
    public int? IdDireccion { get; set; }

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

    public virtual ICollection<Almacen> Almacens { get; set; } = new List<Almacen>();

    public virtual Direccion IdDireccionNavigation { get; set; }

    public virtual Empresa IdEmpresaNavigation { get; set; }
}
