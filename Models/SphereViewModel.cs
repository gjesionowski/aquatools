using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AquaTools.Models
{
    public class SphereViewModel : TankViewModel
    {
        public double Diameter { get; set; }
        public double GetVolumeSphere(double diameter)
        {
            double pi = Convert.ToDouble(Math.PI);
            double radius = (double)diameter / 2;
            double prework = (double)(4 * pi * Math.Pow(radius, 3));
            double volume = prework / 3;
            return Rounded(volume);
        }
    }
}
