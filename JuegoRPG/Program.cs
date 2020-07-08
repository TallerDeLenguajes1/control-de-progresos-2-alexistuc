using System;
using System.Collections.Generic;

namespace JuegoRPG
{
    class Program
    {
        


        static void Main(string[] args)
        {
            string[] nombres = { "kitana", "mileena", "jade", "sonya", "sheeva"};
            string[] nicks = { "edeniana", "tarkatana", "shokan", "terrestre" };

            int cantidadPersonajes = 2;
            Personaje players;
            List<Personaje> player = new List<Personaje>();
            for(int i=0; i < cantidadPersonajes; ++i)
            {
                players = new Personaje(nombres[new Random().Next(0,4)], nicks[new Random().Next(0,4)], i+1);
                player.Add(players);
            }
            //combate
            Console.WriteLine("COMBATE:");
            foreach(Personaje p in player)
            {
                Console.WriteLine("NOMBRE: " + p.Nombre);
                Console.WriteLine("APODO: " + p.Nicks);
                Console.WriteLine("\n");
            }
            
        }
        
    }
}
