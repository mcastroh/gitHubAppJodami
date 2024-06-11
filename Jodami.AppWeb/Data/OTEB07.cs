﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Jodami.AppWeb.Data;

[PrimaryKey("CIACCOD", "OPNNRO", "OTECTEL", "OPCCOL", "OPNITE", "OTECETP6", "OTENTAL7", "OTECTAL7")]
public partial class OTEB07
{
    /// <summary>
    /// Código de compañía
    /// </summary>
    [Key]
    [StringLength(4)]
    [Unicode(false)]
    public string CIACCOD { get; set; }

    /// <summary>
    /// Numero de Pedido
    /// </summary>
    [Key]
    [Column(TypeName = "decimal(7, 0)")]
    public decimal OPNNRO { get; set; }

    /// <summary>
    /// Codigo de Tela
    /// </summary>
    [Key]
    [StringLength(11)]
    [Unicode(false)]
    public string OTECTEL { get; set; }

    /// <summary>
    /// Codigo Color
    /// </summary>
    [Key]
    [StringLength(6)]
    [Unicode(false)]
    public string OPCCOL { get; set; }

    /// <summary>
    /// OPNITE
    /// </summary>
    [Key]
    [Column(TypeName = "decimal(2, 0)")]
    public decimal OPNITE { get; set; }

    /// <summary>
    /// Etapa de Produccion
    /// </summary>
    [Key]
    [StringLength(4)]
    [Unicode(false)]
    public string OTECETP6 { get; set; }

    /// <summary>
    /// Numero de Talla
    /// </summary>
    [Key]
    [Column(TypeName = "decimal(3, 0)")]
    public decimal OTENTAL7 { get; set; }

    /// <summary>
    /// Codigo de talla
    /// </summary>
    [Key]
    [StringLength(6)]
    [Unicode(false)]
    public string OTECTAL7 { get; set; }

    /// <summary>
    /// OPDCOL7
    /// </summary>
    [Required]
    [StringLength(10)]
    [Unicode(false)]
    public string OPDCOL7 { get; set; }

    /// <summary>
    /// Cant. Pedida
    /// </summary>
    [Column(TypeName = "decimal(8, 0)")]
    public decimal OTEQPEDI7 { get; set; }

    /// <summary>
    /// Cantidad Programada
    /// </summary>
    [Column(TypeName = "decimal(8, 0)")]
    public decimal OTEQPROG7 { get; set; }

    /// <summary>
    /// Cant. proporcional
    /// </summary>
    [Column(TypeName = "decimal(5, 1)")]
    public decimal OTEQPROP7 { get; set; }

    /// <summary>
    /// Cant. a Girar
    /// </summary>
    [Column(TypeName = "decimal(8, 0)")]
    public decimal OTEQAGIR7 { get; set; }

    /// <summary>
    /// Acumulado Cortado
    /// </summary>
    [Column(TypeName = "decimal(8, 0)")]
    public decimal OTEQACCO7 { get; set; }

    /// <summary>
    /// Acumulado Girado
    /// </summary>
    [Column(TypeName = "decimal(8, 0)")]
    public decimal OTEQACGI7 { get; set; }

    /// <summary>
    /// Acumulado Girado inicial
    /// </summary>
    [Column(TypeName = "decimal(8, 0)")]
    public decimal OTEQAGIN7 { get; set; }

    /// <summary>
    /// Acumulado Cortado Inicial
    /// </summary>
    [Column(TypeName = "decimal(8, 0)")]
    public decimal OTEQACIN7 { get; set; }

    /// <summary>
    /// Estado del Registro
    /// </summary>
    [Required]
    [StringLength(1)]
    [Unicode(false)]
    public string OTECESTA7 { get; set; }

    /// <summary>
    /// Saldo Inicial Girado
    /// </summary>
    [Column(TypeName = "decimal(8, 0)")]
    public decimal OTEQSIGI { get; set; }

    /// <summary>
    /// Movimiento Girado
    /// </summary>
    [Column(TypeName = "decimal(8, 0)")]
    public decimal OTEQMVGI { get; set; }

    /// <summary>
    /// Saldo Iniciao de Corte
    /// </summary>
    [Column(TypeName = "decimal(8, 0)")]
    public decimal OTEQSICO { get; set; }

    /// <summary>
    /// Movimiento de Corte
    /// </summary>
    [Column(TypeName = "decimal(8, 0)")]
    public decimal OTEQMVCO { get; set; }

    /// <summary>
    /// Acumulado Girado Proyección
    /// </summary>
    [Column(TypeName = "decimal(8, 0)")]
    public decimal OTEQACGPY7 { get; set; }
}