﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Modelos
{
    public class Bodega
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage ="Nombre es Requerido")]
        [MaxLength(60, ErrorMessage ="Nombre debe ser maximo 60 caracteres")]
        public string Nombre { get; set; }
        
        [Required(ErrorMessage = "Nombre es Requerido")]
        [MaxLength(100, ErrorMessage = "Descripcion debe ser maximo 60 caracteres")]
        public string Descripcion { get; set; }
       
        [Required(ErrorMessage = "Nombre es Requerido")]
        public bool Estado { get; set; }
    }
}
