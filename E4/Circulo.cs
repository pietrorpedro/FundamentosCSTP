using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4
{
    internal class Circulo
    {
        public double Raio;

        public double CalcularArea()
        {
            return Math.PI * (this.Raio * this.Raio);
        }
    }
}
