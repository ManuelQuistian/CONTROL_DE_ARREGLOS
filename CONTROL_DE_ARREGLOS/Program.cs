using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CONTROL_DE_ARREGLOS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables a declarar;

            string condicionWhile;
            string nombre;
            string medicamento;
            int botiquin = 0, curitas = 0, inyecciones = 0, oxigeno = 0, pastillas = 0, vendas = 0;

            Console.WindowHeight = 600;
            Console.WindowWidth = 600;

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();

            Console.WriteLine("Bienvenido al Menu de Emergencias Enfermero {0}", nombre);
            Thread.Sleep(2000);

            Console.WriteLine("Ingrese el material que desea llevar");
            Thread.Sleep(1000);

            Console.WriteLine("Botiquin  \t Curitas  \t Inyecciones  \t Oxigeno  \t Pastillas  \t Vendas ");
            medicamento = Console.ReadLine().Trim();

            if (medicamento == "Botiquin")
            {
                botiquin++;
            }
            else if (medicamento == "Curitas")
            {
                curitas++;
            }
            else if (medicamento == "Inyecciones")
            {
                inyecciones++;
            }
            else if (medicamento == "Oxigeno")
            {
                oxigeno++;
            }
            else if (medicamento == "Pastillas")
            {
                pastillas++;
            }
            else if (medicamento == "Vendas")
            {
                vendas++;
            }

            Console.WriteLine("Desea agregar mas elementos? SI o NO");
            condicionWhile = Console.ReadLine();


            while (condicionWhile == "SI" || condicionWhile == "Si" || condicionWhile == "si")
            {
                Console.WriteLine("Se le mostrara de nuevo la lista de materiales");

                Console.WriteLine("Botiquin  \t Curitas  \t Inyecciones  \t Oxigeno  \t Pastillas  \t Vendas ");
                medicamento = Console.ReadLine();

                if (medicamento == "Botiquin")
                {
                    botiquin++;
                }
                else if (medicamento == "Curitas")
                {
                    curitas++;
                }
                else if (medicamento == "Inyecciones")
                {
                    inyecciones++;
                }
                else if (medicamento == "Oxigeno")
                {
                    oxigeno++;
                }
                else if (medicamento == "Pastillas")
                {
                    pastillas++;
                }
                else if (medicamento == "Vendas")
                {
                    vendas++;
                }

                Console.WriteLine("Desea agregar mas elementos? SI o NO");
                condicionWhile = Console.ReadLine();

                while (condicionWhile == "SI" || condicionWhile == "Si" || condicionWhile == "si")
                {
                    Console.WriteLine("Se le mostrara de nuevo la lista de materiales");

                    Console.WriteLine("Botiquin  \t Curitas  \t Inyecciones  \t Oxigeno  \t Pastillas  \t Vendas ");
                    medicamento = Console.ReadLine();
                    Console.WriteLine("Desea agregar mas elementos? SI o NO");
                    condicionWhile = Console.ReadLine();
                    if (medicamento == "Botiquin")
                    {
                        botiquin++;
                    }
                    else if (medicamento == "Curitas")
                    {
                        curitas++;
                    }
                    else if (medicamento == "Inyecciones")
                    {
                        inyecciones++;
                    }
                    else if (medicamento == "Oxigeno")
                    {
                        oxigeno++;
                    }
                    else if (medicamento == "Pastillas")
                    {
                        pastillas++;
                    }
                    else if (medicamento == "Vendas")
                    {
                        vendas++;
                    }

                    while (condicionWhile == "SI" || condicionWhile == "Si" || condicionWhile == "si")
                    {
                        Console.WriteLine("Se le mostrara de nuevo la lista de materiales");

                        Console.WriteLine("Botiquin  \t Curitas  \t Inyecciones  \t Oxigeno  \t Pastillas  \t Vendas ");
                        medicamento = Console.ReadLine();
                        Console.WriteLine("Desea agregar mas elementos? SI o NO");
                        condicionWhile = Console.ReadLine();
                        if (medicamento == "Botiquin")
                        {
                            botiquin++;
                        }
                        else if (medicamento == "Curitas")
                        {
                            curitas++;
                        }
                        else if (medicamento == "Inyecciones")
                        {
                            inyecciones++;
                        }
                        else if (medicamento == "Oxigeno")
                        {
                            oxigeno++;
                        }
                        else if (medicamento == "Pastillas")
                        {
                            pastillas++;
                        }
                        else if (medicamento == "Vendas")
                        {
                            vendas++;
                        }

                    }

                    while (condicionWhile == "SI" || condicionWhile == "Si" || condicionWhile == "si")
                    {
                        Console.WriteLine("Se le mostrara de nuevo la lista de materiales");

                        Console.WriteLine("Botiquin  \t Curitas  \t Inyecciones  \t Oxigeno  \t Pastillas  \t Vendas ");
                        medicamento = Console.ReadLine();
                        Console.WriteLine("Desea agregar mas elementos? SI o NO");
                        condicionWhile = Console.ReadLine();
                        if (medicamento == "Botiquin")
                        {
                            botiquin++;
                        }
                        else if (medicamento == "Curitas")
                        {
                            curitas++;
                        }
                        else if (medicamento == "Inyecciones")
                        {
                            inyecciones++;
                        }
                        else if (medicamento == "Oxigeno")
                        {
                            oxigeno++;
                        }
                        else if (medicamento == "Pastillas")
                        {
                            pastillas++;
                        }
                        else if (medicamento == "Vendas")
                        {
                            vendas++;
                        }

                    }

                    while (condicionWhile == "SI" || condicionWhile == "Si" || condicionWhile == "si")
                    {
                        Console.WriteLine("Se le mostrara de nuevo la lista de materiales");

                        Console.WriteLine("Botiquin  \t Curitas  \t Inyecciones  \t Oxigeno  \t Pastillas  \t Vendas ");
                        medicamento = Console.ReadLine();
                        Console.WriteLine("Desea agregar mas elementos? SI o NO");
                        condicionWhile = Console.ReadLine();
                        if (medicamento == "Botiquin")
                        {
                            botiquin++;
                        }
                        else if (medicamento == "Curitas")
                        {
                            curitas++;
                        }
                        else if (medicamento == "Inyecciones")
                        {
                            inyecciones++;
                        }
                        else if (medicamento == "Oxigeno")
                        {
                            oxigeno++;
                        }
                        else if (medicamento == "Pastillas")
                        {
                            pastillas++;
                        }
                        else if (medicamento == "Vendas")
                        {
                            vendas++;
                        }

                    }

                    while (condicionWhile == "SI" || condicionWhile == "Si" || condicionWhile == "si")
                    {
                        Console.WriteLine("Se le mostrara de nuevo la lista de materiales");

                        Console.WriteLine("Botiquin  \t Curitas  \t Inyecciones  \t Oxigeno  \t Pastillas  \t Vendas ");
                        medicamento = Console.ReadLine();
                        Console.WriteLine("Desea agregar mas elementos? SI o NO");
                        condicionWhile = Console.ReadLine();
                        if (medicamento == "Botiquin")
                        {
                            botiquin++;
                        }
                        else if (medicamento == "Curitas")
                        {
                            curitas++;
                        }
                        else if (medicamento == "Inyecciones")
                        {
                            inyecciones++;
                        }
                        else if (medicamento == "Oxigeno")
                        {
                            oxigeno++;
                        }
                        else if (medicamento == "Pastillas")
                        {
                            pastillas++;
                        }
                        else if (medicamento == "Vendas")
                        {
                            vendas++;
                        }

                    }

                    while (condicionWhile == "SI" || condicionWhile == "Si" || condicionWhile == "si")
                    {
                        Console.WriteLine("Se le mostrara de nuevo la lista de materiales");

                        Console.WriteLine("Botiquin  \t Curitas  \t Inyecciones  \t Oxigeno  \t Pastillas  \t Vendas ");
                        medicamento = Console.ReadLine();
                        Console.WriteLine("Desea agregar mas elementos? SI o NO");
                        condicionWhile = Console.ReadLine();
                        if (medicamento == "Botiquin")
                        {
                            botiquin++;
                        }
                        else if (medicamento == "Curitas")
                        {
                            curitas++;
                        }
                        else if (medicamento == "Inyecciones")
                        {
                            inyecciones++;
                        }
                        else if (medicamento == "Oxigeno")
                        {
                            oxigeno++;
                        }
                        else if (medicamento == "Pastillas")
                        {
                            pastillas++;
                        }
                        else if (medicamento == "Vendas")
                        {
                            vendas++;
                        }

                    }

                    while (condicionWhile == "SI" || condicionWhile == "Si" || condicionWhile == "si")
                    {
                        Console.WriteLine("Se le mostrara de nuevo la lista de materiales");

                        Console.WriteLine("Botiquin  \t Curitas  \t Inyecciones  \t Oxigeno  \t Pastillas  \t Vendas ");
                        medicamento = Console.ReadLine();
                        Console.WriteLine("Desea agregar mas elementos? SI o NO");
                        condicionWhile = Console.ReadLine();
                        if (medicamento == "Botiquin")
                        {
                            botiquin++;
                        }
                        else if (medicamento == "Curitas")
                        {
                            curitas++;
                        }
                        else if (medicamento == "Inyecciones")
                        {
                            inyecciones++;
                        }
                        else if (medicamento == "Oxigeno")
                        {
                            oxigeno++;
                        }
                        else if (medicamento == "Pastillas")
                        {
                            pastillas++;
                        }
                        else if (medicamento == "Vendas")
                        {
                            vendas++;
                        }

                    }

                    while (condicionWhile == "SI" || condicionWhile == "Si" || condicionWhile == "si")
                    {
                        Console.WriteLine("Se le mostrara de nuevo la lista de materiales");

                        Console.WriteLine("Botiquin  \t Curitas  \t Inyecciones  \t Oxigeno  \t Pastillas  \t Vendas ");
                        medicamento = Console.ReadLine();
                        Console.WriteLine("Desea agregar mas elementos? SI o NO");
                        condicionWhile = Console.ReadLine();
                        if (medicamento == "Botiquin")
                        {
                            botiquin++;
                        }
                        else if (medicamento == "Curitas")
                        {
                            curitas++;
                        }
                        else if (medicamento == "Inyecciones")
                        {
                            inyecciones++;
                        }
                        else if (medicamento == "Oxigeno")
                        {
                            oxigeno++;
                        }
                        else if (medicamento == "Pastillas")
                        {
                            pastillas++;
                        }
                        else if (medicamento == "Vendas")
                        {
                            vendas++;
                        }

                    }

                    while (condicionWhile == "SI" || condicionWhile == "Si" || condicionWhile == "si")
                    {
                        Console.WriteLine("Se le mostrara de nuevo la lista de materiales");

                        Console.WriteLine("Botiquin  \t Curitas  \t Inyecciones  \t Oxigeno  \t Pastillas  \t Vendas ");
                        medicamento = Console.ReadLine().Trim();
                        Console.WriteLine("Desea agregar mas elementos? SI o NO");
                        condicionWhile = Console.ReadLine();
                        if (medicamento == "Botiquin")
                        {
                            botiquin++;
                        }
                        else if (medicamento == "Curitas")
                        {
                            curitas++;
                        }
                        else if (medicamento == "Inyecciones")
                        {
                            inyecciones++;
                        }
                        else if (medicamento == "Oxigeno")
                        {
                            oxigeno++;
                        }
                        else if (medicamento == "Pastillas")
                        {
                            pastillas++;
                        }
                        else if (medicamento == "Vendas")
                        {
                            vendas++;
                        }

                    }

                    while (condicionWhile == "SI" || condicionWhile == "Si" || condicionWhile == "si")
                    {
                        Console.WriteLine("Se le mostrara de nuevo la lista de materiales");

                        Console.WriteLine("Botiquin  \t Curitas  \t Inyecciones  \t Oxigeno  \t Pastillas  \t Vendas ");
                        medicamento = Console.ReadLine();
                        Console.WriteLine("Desea agregar mas elementos? SI o NO");
                        condicionWhile = Console.ReadLine();
                        if (medicamento == "Botiquin")
                        {
                            botiquin++;
                        }
                        else if (medicamento == "Curitas")
                        {
                            curitas++;
                        }
                        else if (medicamento == "Inyecciones")
                        {
                            inyecciones++;
                        }
                        else if (medicamento == "Oxigeno")
                        {
                            oxigeno++;
                        }
                        else if (medicamento == "Pastillas")
                        {
                            pastillas++;
                        }
                        else if (medicamento == "Vendas")
                        {
                            vendas++;
                        }

                    }

                    while (condicionWhile == "SI" || condicionWhile == "Si" || condicionWhile == "si")
                    {
                        Console.WriteLine("Se le mostrara de nuevo la lista de materiales");

                        Console.WriteLine("Botiquin  \t Curitas  \t Inyecciones  \t Oxigeno  \t Pastillas  \t Vendas ");
                        medicamento = Console.ReadLine();
                        Console.WriteLine("Desea agregar mas elementos? SI o NO");
                        condicionWhile = Console.ReadLine();
                        if (medicamento == "Botiquin")
                        {
                            botiquin++;
                        }
                        else if (medicamento == "Curitas")
                        {
                            curitas++;
                        }
                        else if (medicamento == "Inyecciones")
                        {
                            inyecciones++;
                        }
                        else if (medicamento == "Oxigeno")
                        {
                            oxigeno++;
                        }
                        else if (medicamento == "Pastillas")
                        {
                            pastillas++;
                        }
                        else if (medicamento == "Vendas")
                        {
                            vendas++;
                        }

                    }
                }

                
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Black;





            Console.WriteLine("Usted lleva {0} Botiquin(es)", botiquin);
            Console.WriteLine("Usted lleva {0} Curita(s)", curitas);
            Console.WriteLine("Usted lleva {0} Inyeccion(es)", inyecciones);
            Console.WriteLine("Usted lleva {0} Tanque(es) de oxigeno", oxigeno);
            Console.WriteLine("Usted lleva {0} Pastilla(s)", pastillas);
            Console.WriteLine("Usted lleva {0} Venda(s)", vendas);
            
            

            Console.ReadKey();

        }
    }
}
