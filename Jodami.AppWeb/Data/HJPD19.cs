﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Jodami.AppWeb.Data;

[Keyless]
public partial class HJPD19
{
    [Required]
    [StringLength(4)]
    [Unicode(false)]
    public string CIACCOD { get; set; }

    [Column(TypeName = "decimal(4, 0)")]
    public decimal HJPFANO { get; set; }

    [Column(TypeName = "decimal(5, 0)")]
    public decimal HJPNNRO { get; set; }

    [Column(TypeName = "decimal(2, 0)")]
    public decimal HJPNVER { get; set; }

    [Required]
    [StringLength(1)]
    [Unicode(false)]
    public string HJPCTIP { get; set; }

    [Column(TypeName = "decimal(2, 0)")]
    public decimal HJPNCOM { get; set; }

    [Column(TypeName = "decimal(2, 0)")]
    public decimal HJPNGTE { get; set; }

    [Column(TypeName = "decimal(2, 0)")]
    public decimal HJPNULCON { get; set; }

    [Required]
    [StringLength(3)]
    [Unicode(false)]
    public string HJPCETJCM { get; set; }

    [Required]
    [StringLength(8)]
    [Unicode(false)]
    public string HJPFLOG19 { get; set; }

    [Required]
    [StringLength(8)]
    [Unicode(false)]
    public string HJPHLOG19 { get; set; }

    [Required]
    [StringLength(10)]
    [Unicode(false)]
    public string HJPWLOG19 { get; set; }

    [Required]
    [StringLength(10)]
    [Unicode(false)]
    public string HJPULOG19 { get; set; }

    [Column(TypeName = "decimal(3, 0)")]
    public decimal HJPNDECCO { get; set; }

    [Column(TypeName = "decimal(3, 0)")]
    public decimal HJPNDEDLCO { get; set; }

    [Required]
    [StringLength(11)]
    [Unicode(false)]
    public string HJPCTLCO { get; set; }

    [Required]
    [StringLength(6)]
    [Unicode(false)]
    public string HJPCCLPR { get; set; }
}