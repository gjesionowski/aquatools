using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AquaTools.Models
{
    public class BoxViewModel : TankViewModel
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }

        public double GetVolumeBox(double width, double height, double length)
        {
            double volume = width * length * height;
            return Rounded(volume);
        }
    }
}
