using System;

namespace Laberinto
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            int [,] laberinto = new int [5,6];
            int filas;
            int columnas;
            char a, b, d, i;
            a= 'a';
            char movimiento;
            int posicion_inicial;
            int posicion_actual;
            int posicion_anterior;
            

            for(filas =0; filas<5;filas++){
                for(columnas=0; columnas<6; columnas ++){
                    laberinto [filas,columnas] =0;
                    laberinto[0,1] =2;
                    Console.Write("{0}\t",laberinto[filas,columnas]);
                }
                Console.WriteLine();

            }
            
           
           Console.WriteLine("Ingresa tu movimiento");
           movimiento = char.Parse(Console.ReadLine());

          if(movimiento == a){
              laberinto[0,1]=0;
              laberinto[1,1] =2;
              }
        if(movimiento == a){
            laberinto[1,1] =0;
            laberinto[2,1]=2;
        }
          for(filas =0; filas<5;filas++){
                for(columnas=0; columnas<6; columnas ++){
                    
                    Console.Write("{0}\t",laberinto[filas,columnas]);
                }
                Console.WriteLine();
}
            }
                

            
           
        }
    
    }

        



