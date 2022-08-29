using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace myappPc1.Models
{
    public class calculadora
    {
        [Display(Name="Datos del estudiante", Prompt="Ingrese su Nombre")]
        public String Nombre{get; set;}

        [Display(Name = "Cursos", Prompt = "Cursos")]
        public string? Cursos { get; set; }
        [Display(Name = "Matematica", Prompt = "Matematica")]
        public bool Matematica { get; set; }        
        [Display(Name = "Lenguaje", Prompt = "Lenguaje")]
        public bool Lenguaje { get; set; }
        [Display(Name = "Historia", Prompt = "Historia")]
        public bool Historia { get; set; }
    }
}

    
    



