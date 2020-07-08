using System;
using System.Collections.Generic;
using System.Text;

namespace JuegoRPG
{
    class Personaje
    {
        /*Caracteristicas
        velocidad; //1 a 10
        destreza; //1 a 5
        fuerza; //1 a 10
        Nivel; //1 a 10
        Armadura; //1 a 10*/
        private int velocidad;
        private int destreza;
        private int fuerza;
        private int Nivel;
        private int Armadura;
        /*Datos
        Tipo;
        Nombre;
        Apodo;
        Fecha de Nacimiento;
        Edad; //entre 0 a 300
        Salud://100*/
        private string tipo;
        private string nombre;
        private string nicks;
        private string fechaNacimiento;
        private int edad;
        private int salud;
        private string v1;
        private string v2;
        private int v;

        public Personaje(string v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public Personaje(string v1, string v2, int v) : this(v1, v2)
        {
            this.v = v;
        }

        //metodos setters y getters
        public int Velocidad { get => velocidad; set => velocidad = value; }
        public int Destreza { get => destreza; set => destreza = value; }
        public int Fuerza { get => fuerza; set => fuerza = value; }
        public int Nivel1 { get => Nivel; set => Nivel = value; }
        public int Armadura1 { get => Armadura; set => Armadura = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Nicks { get => nicks; set => nicks = value; }
        public string FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Salud { get => salud; set => salud = value; }

        public Personaje()
        {

        }
    }
}