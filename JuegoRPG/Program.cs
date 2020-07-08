using System;
using System.Collections.Generic;

namespace JuegoRPG
{
    class Program
    {
        


        static void Main(string[] args)
        {
            string[] nombres = { "ale", "alvaro", "yeye", "enzo", "maxi"};
            string[] nicks = { "papichulo", "dengue", "vieja", "moxi" };

            int cantidadPersonajes = 2;
            Personaje players;
            List<Personaje> players = new List<Personaje>();
            for(int i=0; i < cantidadPersonajes; ++i)
            {

                players = new Personaje(nombres[new Random().Next(0,4)], nicks[new Random().Next(0,4)],);
            }
             
        }
        /*
         static int cantidad = 2;
        static void Main(string[] args)
        {
            Personaje jugador;
            List<Personaje> ListaDeJugadores = new List<Personaje>();
            string[] Nombres = { "Celeste", "Gonzalo", "Fabio", "Alex", "Fede" };
            string[] Apodos = { "Ntvg", "Sotaski", "Soto", "Juampy", "kiko" };
        string[] nombres = {"Jhon Salchichon", "Josefo", "Lady Sonsa"};
            string[] apodos = {"Degolador", "El Destructor", "El Elegido"};
            for(int i = 0; i < cantidad; i++)
            {
                jugador = new Personaje(Nombres[new Random().Next(0, 4)], Apodos[new Random().Next(0, 4)], i+1);
                ListaDeJugadores.Add(jugador);
                jugador.MostrarPersonajes();
            }
            Combate(ListaDeJugadores);
         */
    }
}
