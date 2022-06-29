using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraClases
{
    internal class Calculadora
    {
        // Declaro las variables principales a utilizar en la clase
        float n1;
        float n2;
        public Calculadora(float n1, float n2) // Creo el constructor
        {
            this.n1 = n1;
            this.n2 = n2;
        }
        public float Sumar() // Creo un metodo float que regresara el valor 
        {
            return n1 + n2;
        }
        public void ResultadoSuma(float total) // Desplegar el resultado con un parametro total que almacena lo que regresa el metodo anterior
        {
            Console.Clear();
            Console.WriteLine("~ RESULTADOS ~");
            Console.WriteLine("El primer digito ingresado es: " + n1);
            Console.WriteLine("El segundo digito ingresado es: " + n2);
            Console.ForegroundColor = ConsoleColor.Green; // Crea un color en el texto
            Console.WriteLine("Total de la suma de los dos numeros: " + total);
            Console.ResetColor(); // Finaliza el cambio de color
        }
        public float Restar() // Creo un metodo float que regresara el valor 
        {
            return n1 - n2;
        }
        public void ResultadoResta(float total) // Desplegar el resultado con un parametro total que almacena lo que regresa el metodo anterior
        {
            Console.Clear();
            Console.WriteLine("~ RESULTADOS ~");
            Console.WriteLine("El primer digito ingresado es: " + n1);
            Console.WriteLine("El segundo digito ingresado es: " + n2);
            Console.ForegroundColor = ConsoleColor.Green; // Crea un color en el texto
            Console.WriteLine("Total de la resta de los dos numeros: " + total);
            Console.ResetColor(); // Finaliza el cambio de color
        }
        public float Multiplicar() // Creo un metodo float que regresara el valor 
        {
            return n1 * n2;
        }
        public void ResultadoMultiplicacion(float total) // Desplegar el resultado con un parametro total que almacena lo que regresa el metodo anterior
        {
            Console.Clear();
            Console.WriteLine("~ RESULTADOS ~");
            Console.WriteLine("El primer digito ingresado es: " + n1);
            Console.WriteLine("El segundo digito ingresado es: " + n2);
            Console.ForegroundColor = ConsoleColor.Green; // Crea un color en el texto
            Console.WriteLine("Total de la multiplicacion de los dos numeros: " + total);
            Console.ResetColor(); // Finaliza el cambio de color
        }
        public float Division() // Creo un metodo float que regresara el valor 
        {
            return n1 / n2;
        }
        public void ResultadoDiviion(float total) // Desplegar el resultado con un parametro total que almacena lo que regresa el metodo anterior
        {
            Console.Clear();
            Console.WriteLine("~ RESULTADOS ~");
            Console.WriteLine("El primer digito ingresado es: " + n1);
            Console.WriteLine("El segundo digito ingresado es: " + n2);
            Console.ForegroundColor = ConsoleColor.Green; // Crea un color en el texto
            Console.WriteLine("Total de la division de los dos numeros: " + total);
            Console.ResetColor(); // Finaliza el cambio de color
        }
        public float Porcentaje()
        {
            return (n1 * n2) / 100;
        }
        public void ResultadoPorcentaje(float total) // Desplegar el resultado con un parametro total que almacena lo que regresa el metodo anterior
        {
            Console.Clear();
            Console.WriteLine("~ RESULTADOS ~");
            Console.WriteLine("El primer digito ingresado es: " + n1);
            Console.WriteLine("El segundo digito ingresado es: " + n2);
            Console.ForegroundColor = ConsoleColor.Green; // Crea un color en el texto
            Console.WriteLine("El {0}% de {1} es {2}", n2, n1, total);
            Console.ResetColor(); // Finaliza el cambio de color
        }
        static void Main(string[] args)
        {
            // Declaracion de varibales del Main
            char opciones;
            float n1, n2;
            do // Creo un Do/While para restablecer el menu cada vez que finalice un procedimiento
            {
                Console.Clear();
                // Creo el menu de opciones
                Console.WriteLine("~ MENU DE OPCIONES ~");
                Console.WriteLine("1.- Suma");
                Console.WriteLine("2.- Resta");
                Console.WriteLine("3.- Multiplicacion");
                Console.WriteLine("4.- Dividir");
                Console.WriteLine("5.- Porcentaje");
                Console.WriteLine("6.- Salir del programa");
                // Finalizo el menu de opciones
                Console.Write("Ingresar una opcion del memnu: "); // Ingreso la opcion que se utlizara
                opciones = char.Parse(Console.ReadLine());
                switch (opciones) // Se crea un Switch para describir lo que hace cada opcion con el parametro de la opcion ingresada (opciones)
                { 
                    case '1': // Comenza a ejecutar el procedimiento que realizara esta opcion                      
                        do 
                        {
                            try // Hace que el programa continue ejecutandose sin importar si ingresas una variable erronea
                            {
                                char opc; // Se utiliza para el do/while y finalizar el ciclo o repetirlo
                                do // Inicia el ciclo do/while
                                {
                                    Console.Clear(); // Limpio la consola
                                    // Registro las variables
                                    Console.Write("Ingresar el primer digito: ");
                                    n1 = float.Parse(Console.ReadLine());
                                    Console.Write("Ingresar el segundo digito: ");
                                    n2 = float.Parse(Console.ReadLine());
                                    // Finaliza el registro
                                    Calculadora calculadora = new Calculadora(n1, n2); // Se crea un objeto con los parametros de los registros para enviar a la clase
                                    float total = calculadora.Sumar(); // El objeto manda llamas de la funcion que regresaria el valor en el parametro Total para almacenarlo
                                    calculadora.ResultadoSuma(total); // El objeto manda a llamar a la funcion Resultado con el parametro total, enviando el resultado que regreso 
                                    Console.Write("Desea continuar con otra suma (s/n): "); 
                                    opc = char.Parse(Console.ReadLine());
                                } while ((opc == 'S') || (opc == 's'));
                            }
                            catch (FormatException a)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(a.Message);
                                Console.ResetColor();
                                Console.WriteLine("[Presiona <Enter> para continuar]");
                                Console.ReadKey();
                                Console.Clear();  
                            }
                            catch (Exception a)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(a.Message);
                                Console.ResetColor();
                                Console.WriteLine("[Presiona <Enter> para continuar]");
                                Console.ReadKey();
                                Console.Clear();
                            }
                        } while (false);
                        break;
                    case '2':
                        do
                        {
                            try
                            {
                                char opc;
                                do
                                {
                                    Console.Clear();
                                    Console.Write("Ingresar el primer digito: ");
                                    n1 = float.Parse(Console.ReadLine());
                                    Console.Write("Ingresar el segundo digito: ");
                                    n2 = float.Parse(Console.ReadLine());
                                    Calculadora calculadora = new Calculadora(n1, n2);
                                    float total = calculadora.Restar();
                                    calculadora.ResultadoResta(total);
                                    Console.Write("Desea continuar con otra resta (s/n): ");
                                    opc = char.Parse(Console.ReadLine());
                                } while ((opc == 'S') || (opc == 's'));
                            }
                            catch (FormatException a)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(a.Message);
                                Console.ResetColor();
                                Console.WriteLine("[Presiona <Enter> para continuar]");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            catch (Exception a)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(a.Message);
                                Console.ResetColor();
                                Console.WriteLine("[Presiona <Enter> para continuar]");
                                Console.ReadKey();
                                Console.Clear();

                            }
                        } while (false);
                        break;
                    case '3':
                        do
                        {
                            try
                            {
                                char opc;
                                do
                                {
                                    Console.Clear();
                                    Console.Write("Ingresar el primer digito: ");
                                    n1 = float.Parse(Console.ReadLine());
                                    Console.Write("Ingresar el segundo digito: ");
                                    n2 = float.Parse(Console.ReadLine());
                                    Calculadora calculadora = new Calculadora(n1, n2);
                                    float total = calculadora.Multiplicar();
                                    calculadora.ResultadoMultiplicacion(total);
                                    Console.Write("Desea continuar con otra resta (s/n): ");
                                    opc = char.Parse(Console.ReadLine());
                                } while ((opc == 'S') || (opc == 's'));
                            }
                            catch (FormatException a)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(a.Message);
                                Console.ResetColor();
                                Console.WriteLine("[Presiona <Enter> para continuar]");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            catch (Exception a)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(a.Message);
                                Console.ResetColor();
                                Console.WriteLine("[Presiona <Enter> para continuar]");
                                Console.ReadKey();
                                Console.Clear();

                            }
                        } while (false);
                        break;
                    case '4':
                        do
                        {
                            try
                            {
                                char opc;
                                do
                                {
                                    Console.Clear();
                                    Console.Write("Ingresar el primer digito: ");
                                    n1 = float.Parse(Console.ReadLine());
                                    Console.Write("Ingresar el segundo digito: ");
                                    n2 = float.Parse(Console.ReadLine());
                                    Calculadora calculadora = new Calculadora(n1, n2);
                                    float total = calculadora.Division();
                                    calculadora.ResultadoDiviion(total);
                                    Console.Write("Desea continuar con otra resta (s/n): ");
                                    opc = char.Parse(Console.ReadLine());
                                } while ((opc == 'S') || (opc == 's'));
                            }
                            catch (FormatException a)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(a.Message);
                                Console.ResetColor();
                                Console.WriteLine("[Presiona <Enter> para continuar]");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            catch (Exception a)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(a.Message);
                                Console.ResetColor();
                                Console.WriteLine("[Presiona <Enter> para continuar]");
                                Console.ReadKey();
                                Console.Clear();
                            }
                        } while (false);
                        break;
                    case '5':
                        do
                        {
                            try
                            {
                                char opc;
                                do
                                {
                                    Console.Clear();
                                    Console.Write("Ingresar la cantidad: ");
                                    n1 = float.Parse(Console.ReadLine());
                                    Console.Write("Ingresar el porcentaje: ");
                                    n2 = float.Parse(Console.ReadLine());
                                    Calculadora calculadora = new Calculadora(n1, n2);
                                    float total = calculadora.Porcentaje();
                                    calculadora.ResultadoPorcentaje(total);
                                    Console.Write("Desea continuar con otra resta (s/n): ");
                                    opc = char.Parse(Console.ReadLine());
                                } while ((opc == 'S') || (opc == 's'));
                            }
                            catch (FormatException a)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(a.Message);
                                Console.ResetColor();
                                Console.WriteLine("[Presiona <Enter> para continuar]");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            catch (Exception a)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(a.Message);
                                Console.ResetColor();
                                Console.WriteLine("[Presiona <Enter> para continuar]");
                                Console.ReadKey();
                                Console.Clear();

                            }
                        } while (false);
                        break;
                    case '6':
                        Console.WriteLine("[Presiona <Enter> para salir del programa]");
                        Console.ReadKey();
                        break;
                    default:
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Favor de ingresar una opcion del menu");
                            Console.ResetColor();
                            Console.WriteLine("[Presiona <Enter> para continuar]");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                }
            } while (opciones != '5');
        }
    }
}
