using System;

namespace Laberinto
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
                
            char moverse;
            int usuario, x = 0, y = 1;
            int[,] laberinto =
            {
                {1,0,1,1,0,0},
                {1,0,1,1,0,1},
                {1,0,1,1,0,1},
                {1,0,0,0,0,1},
                {1,1,0,1,1,1}
            };
            Console.WriteLine("Laberinto");
            Console.WriteLine("Instrucciones");
            Console.WriteLine("Tecla 'W' dezplaza un espacio arriba");
            Console.WriteLine("Tecla 'S' dezplaza un espacio abajo");
            Console.WriteLine("Tecla 'D' dezplaza un espacio a la derecha");
            Console.WriteLine("Tecla 'A' dezplaza un espacio a la izquierda");
            Console.WriteLine("El jugador es el numero 2");
            Console.WriteLine("Para ganar llegue al punto (0,5)");
      
            Console.Clear();
            Console.WriteLine("MAPA");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write("{0}\t", laberinto[i, j]);
                }
                Console.WriteLine();
            }
           
            laberinto[x, y] = 2;
            do
            {
                Console.Clear();
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        Console.Write("{0}\t", laberinto[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Ingrese direccion de dezplazamiento");
                moverse = char.Parse(Console.ReadLine());
                switch (moverse)
                {
                    case 'w':
                        if (laberinto[x - 1, y] != 1 && x - 1 >= 0)
                        {
                            laberinto[x, y] = 0;
                            x = x - 1;
                            laberinto[x, y] = 2;
                        }
                        else
                        {
                            Console.WriteLine("No se puede realizar el movimiento");
                        }
                        break;
                    case 's':
                        if (laberinto[x + 1, y] != 1 && x + 1 <= 5)
                        {
                            laberinto[x, y] = 0;
                            x = x + 1;
                            laberinto[x, y] = 2;
                        }
                        else
                        {
                            Console.WriteLine("No se puede realizar el movimiento");
                        }
                        break;
                    case 'd':
                        if (laberinto[x, y + 1] != 1)
                        {
                            laberinto[x, y] = 0;
                            y = y + 1;
                            laberinto[x, y] = 2;
                        }
                        else
                        {
                            Console.WriteLine("No se puede realizar el movimiento");
                        }
                        break;
                    case 'a':
                        if (laberinto[x, y - 1] != 1)
                        {
                            laberinto[x, y] = 0;
                            y = y - 1;
                            laberinto[x, y] = 2;
                        }
                        else
                        {
                            Console.WriteLine("No se puede realizar el movimiento");
                        }
                        break;
                }
            } while (laberinto[0, 5] != 2);
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write("{0}\t", laberinto[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("!Has Ganado¡");
        }
    
    }
}

      



