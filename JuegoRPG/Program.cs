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
            int auxiliarPocoUtil = 1;
            Personaje players;
            List<Personaje> player = new List<Personaje>();
            for(int i=0; i < cantidadPersonajes; ++i)
            {
                players = new Personaje(nombres[new Random().Next(0,4)], nicks[new Random().Next(0,3)]);
                player.Add(players);
            }
            //combate
            Console.WriteLine("COMBATE:\n");
            foreach (Personaje p in player)
            {
                Console.WriteLine("JUGADOR NUMERO " + auxiliarPocoUtil);

                Console.WriteLine("NOMBRE: " + p.Nombre);
                Console.WriteLine("APODO: " + p.Nicks);
                Console.WriteLine("velocidad: " + p.Velocidad);
                Console.WriteLine("destreza: " + p.Destreza);
                Console.WriteLine("nivel: "+ p.Nivel1);
                Console.WriteLine("armadura: " + p.armadura);
                Console.WriteLine("\n\n");
                auxiliarPocoUtil++;
            }
        }

    }
}
