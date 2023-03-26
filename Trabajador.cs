using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesHerencia
{
    internal class Trabajador : Usuario
    {
        /// <summary>
        /// Sueldo del docente
        /// </summary>
        public decimal Sueldo { get; set; }

        /// <summary>
        /// Dias de vacacion
        /// </summary>
        public int DiasVacacion { get; set; }

        public override string ToString()
        {
            return $"Cuenta: {Cuenta} | Pass: {Password} | Nombre: {Nombre} | Sueldo: {Sueldo} | Dias vacacion: {DiasVacacion}";
        }
    }
}
