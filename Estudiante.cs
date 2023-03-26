using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesHerencia
{
    internal class Estudiante : Usuario
    {
        /// <summary>
        /// Este es un constructror vacio
        /// </summary>
        public Estudiante() { }

        public string Matricula { get; set; }
    }
}
