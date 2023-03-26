using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesHerencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            List<Pasante> listP = new List<Pasante>();
            listP.Add(new Pasante()
            {
                Cuenta = "CarmenJ",
                Password = "Car321",
                Nombre = "Carmen",
                Horas = 8,
               
                Sueldo = 2344,
        });
            listP.Add(new Pasante()
            {
                Cuenta = "AdanK",
                Password = "Ada345",
                Nombre = "Adan",
                Horas = 8,
               
                Sueldo = 2376,
        });

           


            Estudiante estudiante = new Estudiante();
            estudiante.Cuenta = "jperez";
            estudiante.Password = "123456";
            estudiante.Nombre = "Juan";
            estudiante.Matricula = "56789A";
         

            estudiante.login("jperez", "123456");
            estudiante.login();

            //Listas en ves de Arrays en .Net C#
            List<Docente> listaDocentes = new List<Docente>();
            listaDocentes.Add(new Docente() {
                Cuenta= "smamani",
                Password = "12477",
                Nombre = "Saul",
                Sueldo = 1234
            });
            listaDocentes.Add(new Docente()
            {
                Cuenta = "sperez",
                Password = "12477",
                Nombre = "Ana",
                Sueldo = 123
            });
            listaDocentes.Add(new Docente()
            {
                Cuenta = "scarla",
                Password = "12477",
                Nombre = "Carla",
                Sueldo = 12
            });

            listaDocentes.Add(new Docente()
            {
                Cuenta = "lidia",
                Password = "12477",
                Nombre = "Lidia",
                Sueldo = 23
            });

            listaDocentes.Add(new Docente()
            {
                Cuenta = "jOSE",
                Password = "12477",
                Nombre = "Jose",
                Sueldo = 12
            });

             listaDocentes.Add(new Docente()
            {
                Cuenta = "Lisa",
                Password = "12477",
                Nombre = "lisa",
                Sueldo = 23
            });

             listaDocentes.Add(new Docente()
            {
                Cuenta = "Lidy",
                Password = "12477",
                Nombre = "lidi",
                Sueldo = 230
            });

            listaDocentes.Add(new Docente()
            {
                Cuenta = "Pepe",
                Password = "12477",
                Nombre = "pepe",
                Sueldo = 54
            });

            listaDocentes.Add(new Docente()
            {
                Cuenta = "Soraya",
                Password = "12477",
                Nombre = "Soraya",
                Sueldo = 54
            });


            MostrarLista(listaDocentes);

            Double promedio = getPromedio(listaDocentes);
            Console.WriteLine("\n--- Promedio: {0}", promedio.ToString("##.##"));

            double promedio2 = getPromedioDos(listaDocentes);
            Console.WriteLine("\n--- Promedio Dos: {0}", promedio2.ToString("##.##"));

            double promedio3 = getPromedioTres(listaDocentes);
            Console.WriteLine("\n--- Promedio Tres: {0}", promedio3.ToString("##.##"));

            double promedio4 = getPromedioCuatro(listaDocentes);
            Console.WriteLine("\n--- Promedio Cuatro Modificado: {0}", promedio4.ToString("##.##"));


            MostrarL(listP);

            Double prom = getProm(listP);
            Console.WriteLine("\n--- Primer: {0}", prom.ToString("##.##"));

            double prom2 = getPromD(listP);
            Console.WriteLine("\n--- Segundo: {0}", prom2.ToString("##.##"));

            double prom3 = getPromT(listP);
            Console.WriteLine("\n--- Tercer: {0}", prom3.ToString("##.##"));

            double prom4 = getPromC(listP);
            Console.WriteLine("\n--- Cuarto: {0}", prom4.ToString("##.##"));

           


            Console.ReadKey(); 



        }


        private static double getPromC(List<Pasante> listaP)
        {

            decimal prom = (

                from item in listaP
                where item.Sueldo < 30000
                select item.Sueldo

                ).Average();
            return (double)prom;
        }

        private static double getPromT(List<Pasante> listaP)
        {

            decimal sum = listaP.Sum(x => x.Sueldo);
            int total = listaP.Count;
            return (double)(sum / total);
        }

        private static double getPromD(List<Pasante> listaP)
        {

            decimal prom = listaP.Average(x => x.Sueldo);
            return (double)prom;
        }

        private static double getProm(List<Pasante> listaP)
        {
            Decimal sum = 0;
            foreach (Pasante item in listaP)
            {
                sum += item.Sueldo;
            }
            return (double)(sum / listaP.Count()); //Cast
        }

        private static void MostrarL(List<Pasante> listP)
        {
            Console.WriteLine("\n---------LISTA DE PASANTES---------\n");
            foreach (Pasante item in listP)
            {
                Console.WriteLine(item.ToString());
            }
        }

        private static double getPromedioCuatro(List<Docente> listaDocentes)
        {
            //consuntas LINQ
            decimal prom = (
                
                from item in listaDocentes
                where item.Sueldo < 200
                select item.Sueldo
                
                ).Average();
            return (double)prom;
        }

        private static double getPromedioTres(List<Docente> listaDocentes)
        {
            //funciones Lambda
            decimal sum = listaDocentes.Sum(x => x.Sueldo);
            int total = listaDocentes.Count;
            return (double)(sum / total);
        }

        private static double getPromedioDos(List<Docente> listaDocentes)
        {
            //Funcones lamda
            decimal promedio = listaDocentes.Average(x => x.Sueldo);
            return (double)promedio;
        }

        private static double getPromedio(List<Docente> listaDocentes)
        {
            Decimal sum = 0;
            foreach (Docente item in listaDocentes) {
                sum += item.Sueldo;
            }

            return (double)(sum / listaDocentes.Count()); //CAST
        }

        private static void MostrarLista(List<Docente> listaDocentes)
        {
            Console.WriteLine("\n------- LISTA DE DOCENTES y OTROSS --------\n");

            foreach (Docente item in listaDocentes)
            {
                Console.WriteLine(item.ToString());
            }
        }

        
    }
}
