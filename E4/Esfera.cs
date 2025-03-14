using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4
{
    internal class Esfera
    {
        public double Raio;

        public double CalcularVolume()
        {
            return (4.0 / 3.0) * Math.PI * (this.Raio * this.Raio * this.Raio);
        }
    }
}
