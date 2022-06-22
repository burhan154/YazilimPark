using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity.Concrete
{
    public class BMIModel
    {
        [Range(25, 250, ErrorMessage = "Weight must be between 25 and 60")]
        [DisplayName("Weight(Kg)")]
        public double Weight { get; set; }

        [Range(25, 400, ErrorMessage = "Weight must be between 25 and 60")]
        [DisplayName("Height(Cm)")]
        public double Height { get; set; }
    }
}
