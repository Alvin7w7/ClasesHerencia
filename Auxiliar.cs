using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesHerencia
{
    internal class Auxiliar : Usuario
    {
        /// <summary>
        /// Sueldo del docente
        /// </summary>
        public decimal Sueldo { get; set; }
        public int Horas { get; set; }

        public override string ToString()
        {
            return $"Cuenta: {Cuenta} | Pass: {Password} | Nombre: {Nombre} | Sueldo: {Sueldo} | Horas: {Horas}";
        }
    }
}
