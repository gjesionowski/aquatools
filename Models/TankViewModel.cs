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
        public double Height { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
        public double Diameter { get; set; }
        [BindProperty]
        public string TankType { get; set; }
        public string[] TankTypes = new[] {"Box", "Cylinder", "Sphere"};

        public double Rounded(double input)
        {
            double rounded;
            rounded = Math.Round(input);
            return rounded;
        }

        public double GetVolumeBox(double width, double height, double length)
        {
            double volume = width * length * height;
            return this.Rounded(volume);
        }
    }

}
