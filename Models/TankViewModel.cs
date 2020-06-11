using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace AquaTools.Models
{
    public class TankViewModel
    {
        [Required]
        public string TankType { get; set; }
        public string[] TankTypes = new[] { "Box", "Cylinder", "Sphere" };

        public double Rounded(double input)
        {
            double rounded;
            rounded = Math.Round(input);
            return rounded;
        }
    }
}
