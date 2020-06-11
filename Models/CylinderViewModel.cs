using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AquaTools.Models
{
    public class CylinderViewModel : TankViewModel
    {
        public double Height { get; set; }
        public double Diameter { get; set; }
        public double GetVolumeCylinder(double height, double diameter)
        {
            double pi = Convert.ToDouble(Math.PI);
            double radius = (double)diameter / 2;
            double volume = height * Math.Pow(radius, 2) * pi;
            return Rounded(volume);
        }
    }
}
