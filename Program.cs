using System;

namespace Laberinto
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            
            char dezplazamiento;
            int usuario,x=0,y=1;
            int[,] matriz =
            {
                {1,0,1,1,0,0 },
                {1,0,1,1,0,1},
                {1,0,1,1,0,1},
                {1,0,0,0,0,1},
                {1,1,0,1,1,1}
            };
            Console.WriteLine("INTRUCCIONES");
            Console.WriteLine("Tecla 'a' dezplaza un espacio arriba");
            Console.WriteLine("Tecla 'b' dezplaza un espacio abajo");
            Console.WriteLine("Tecla 'd' dezplaza un espacio a la derecha");
            Console.WriteLine("Tecla 'i' dezplaza un espacio a la izquierda");
            Console.WriteLine("El jugador es el numero 2");
            Console.WriteLine("Llega a la salida");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("MAPA");
            for (int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 6; j++)
                {
                    Console.Write("{0}\t", matriz[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            matriz[x, y] = 2;
            do
            {
                Console.Clear();
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        Console.Write("{0}\t", matriz[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Ingrese direccion de dezplazamiento");
                dezplazamiento = char.Parse(Console.ReadLine());
                switch (dezplazamiento)
                {
                    case 'a':
                        if (matriz[x-1, y] != 1 && x-1 >= 0)
                        {
                            matriz[x, y] = 0;
                            x = x - 1;
                            matriz[x, y] = 2;
                        }
                        else
                        {
                            Console.WriteLine("No se puede realizar el movimiento");
                        }
                        break;
                    case 'b':
                        if (matriz[x + 1, y] != 1 && x+1 <= 5)
                        {
                            matriz[x, y] = 0;
                            x = x + 1;
                            matriz[x, y] = 2;
                        }
                        else
                        {
                            Console.WriteLine("No se puede realizar el movimiento");
                        }
                        break;
                    case 'd':
                        if (matriz[x, y + 1] != 1)
                        {
                            matriz[x, y] = 0;
                            y = y + 1;
                            matriz[x, y] = 2;
                        }
                        else
                        {
                            Console.WriteLine("No se puede realizar el movimiento");
                        }
                        break;
                    case 'i':
                        if (matriz[x, y - 1] != 1)
                        {
                            matriz[x, y] = 0;
                            y = y - 1;
                            matriz[x, y] = 2;
                        }
                        else
                        {
                            Console.WriteLine("No se puede realizar el movimiento");
                        }
                        break;
                }
            } while (matriz[0, 5] != 2);
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write("{0}\t", matriz[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("!Has Ganado¡");
                

            
           
        }
    
    }

      



