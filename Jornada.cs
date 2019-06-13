using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen3ra
{
    class Jornada
    {
        private int _Numero_Jornada;
        private static Random gen = new Random();
        public int Numero_Jornada
        {
            get { return _Numero_Jornada; }
        }
        public Jornada()
        {
            _Numero_Jornada = gen.Next(10);
        }
        public int tirar()
        {
                return gen.Next(10);
        }
    }
}
