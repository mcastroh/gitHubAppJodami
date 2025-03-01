﻿using System.ComponentModel.DataAnnotations;

namespace Jodami.AppWeb.Models.ViewModels
{
    public class VMUnidadMedida
    {
        [Key]
        [Display(Name = "Unidad Medida ID")]
        public int IdUnidad { get; set; }

        [Display(Name = "Descripción")]
        [Required(ErrorMessage = "Descripción es obligatorio")]
        [MaxLength(60)]
        public string Descripcion { get; set; }

        [Display(Name = "Símbolo")]
        [Required(ErrorMessage = "Símbolo de moneda es obligatorio")]
        [MaxLength(20)]
        public string Simbolo { get; set; }

        [Display(Name = "Código SUNAT")]
        [Required(ErrorMessage = "Código SUNAT es obligatorio")]
        [MaxLength(20)]
        public string IdSunat { get; set; }

        [Display(Name = "Estado")]
        public bool EsActivo { get; set; }

    }
}