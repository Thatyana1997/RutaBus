﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RutaBusApp.Models
{
    public class Usuario
    {
        public int UsuarioID { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string Apellido { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(100)]
        public string Contrasena { get; set; }

        public DateTime FechaRegistro { get; set; }
        public DateTime FechaAdicion { get; set; }
        public string AdicionadoPor { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string ModificadoPor { get; set; }
    }
}