using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Datetimerpicker.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        [Display(Name = "Nome Completo:")]
        public int MyProperty { get; set; }

        [Display(Name = "E-mail:")]
        public string Email { get; set; }

        [Display(Name = "Data do aniversário:")]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Tempo Inicio:")]
        public string StartTime { get; set; }

        [Display(Name = "Está Inscrito:")]
        public bool IsEnrolled { get; set; }

    }
}