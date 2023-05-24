using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class EjercicioValidar1
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                            .WriteTo.File(@"D:\10. DECIMO CICLO\TALLER DE DESARROLLO 2\PrimeraPractica\MyFirstSolution\ConsoleApp\Logs\Log_20230523.txt")
                            .CreateLogger();
            Nombre();
            
        }

        public static void Nombre()
        {
            try
            {
                Console.Write("Ingrese su Nombre: ");
                string nombre = Console.ReadLine();
                if (string.IsNullOrEmpty(nombre)){
                    Console.WriteLine("Campo Vacio");
                    //Log.Information("Error nombre");
                }
                else
                {
                    Console.Write("Ingrese su Edad:  ");
                    int edad = int.Parse(Console.ReadLine());
                    if (edad < 0 && edad >= 99)
                    {
                        Console.WriteLine("Formato de edad incorrecto");
                        //Log.Information("Error edad");
                    }
                    else
                    {
                        Console.Write("Ingrese su genero (M)masculino | (F)femenino:  ");
                        string sexopersona = Console.ReadLine();

                        //string root2 = @"C:\Users";
                        //bool result = root.Equals(root2, StringComparison.OrdinalIgnoreCase);

                        if (sexopersona.Equals("f"))
                        {
                            bool genero = true;
                     
                            Console.WriteLine("Hola " + nombre + ", " + edad + " años, género Femenino");
                            Log.Information("El registro se realízó correctamente");
                        }else if (sexopersona.Equals("m"))
                        {
                            bool genero = false;

                            Console.WriteLine("Hola " + nombre + ", " + edad + " años, género Masculino");
                            Log.Information("El registro se realízó correctamente");
                        }
                        else
                        {
                            Console.WriteLine("Formato incorrecto");
                        }
                        Console.ReadKey();
                    }
                    Console.ReadKey();
                }   
                                                
                Console.ReadKey();    

            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
                Log.Error("ArgumentNullException " + ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Log.Error("FormatException " + ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
                Log.Error("OverflowException " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Log.Error("Exception " + ex.Message);
            }

        }
    }
}
