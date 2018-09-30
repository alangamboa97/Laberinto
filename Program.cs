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
            int movimiento;
             Console.WriteLine("Ingresa tu movimiento:");
             movimiento = char.Parse(Console.ReadLine());
            
            for(filas =0; filas<5;filas++){
            for(columnas=0; columnas<6; columnas++){
                
                laberinto [filas, columnas] = 0;
                
            }
            
            
            laberinto [0,1] =2;
            
            /*             laberinto[1,1] =0;
            laberinto[2,1] =0;
            laberinto[3,1] =0;
            laberinto[3,2] =0;
            laberinto[3,3] =0;
            laberinto[3,4] = 0;
            laberinto[4,2] =0;
            laberinto[2,4] =0;
            laberinto[1,4] =0;
            laberinto[0,4] = 0;
            */
            
            for(filas =0; filas<5;filas++){
                for(columnas =0; columnas<6;columnas++){
                    
                    if(movimiento == 'A' || movimiento == 'a'){
                       
                        laberinto[filas,columnas] =2;


                    }
                    
                
                    Console.Write("{0}\t",laberinto[filas,columnas]);
                }
                Console.WriteLine();
            }
            
           
                

            
           
        }
    
    

        

}
}
}