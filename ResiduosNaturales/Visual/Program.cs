using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Visual
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            lectura();
            escritura();
        }

        public static void lectura()
        {
            String line;
            try
            {
                StreamReader sr = new StreamReader("..\\..\\ejemplo.txt");

                line = "";

                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }

                sr.Close();
                //Console.ReadLine();
                Thread.Sleep(4000);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        public static void escritura()
        {
            try
            {

                StreamWriter sw = new StreamWriter("..\\..\\ejemplo.txt", true);

                sw.WriteLine("\n- Hola de nuevo mundo!!");

                sw.WriteLine("- :D");

                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }








    }
}
