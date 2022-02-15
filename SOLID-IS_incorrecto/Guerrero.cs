using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_IS_incorrecto
{
    class Guerrero : IPersonaje
    {
        public string Nombre { get; set; }
        public Guerrero(string nombre)
        {
            Nombre = nombre;
        }

        public void Atacar(string JugadorParaAtacar)
        {
            Console.WriteLine("Atacando!");
        }

        public void Bloquear()
        {
            Console.WriteLine("Bloqueando!");
        }

        public void CalcularDanio()
        {
            Console.WriteLine("Calculando daño de ataque...");
        }

        public void CargarModelo3d()
        {
            Console.WriteLine("Cargando modelo del personaje");
        }

        public void Comerciar(string JugadorParaComerciar)
        {
            Console.WriteLine("Comerciando con " + JugadorParaComerciar);
        }

        public void ConectarBD()
        {
            Console.WriteLine("conectando a la base de jugadores... ");
        }

        public void GuardarEnBD()
        {
            Console.WriteLine("Guardando Jugador en Baase de Datos ");
        }

        public void Hablar(string JugadorParaHablar)
        {
            Console.WriteLine("Hablando con " + JugadorParaHablar);
        }

        public void RenderizarEnPantalla()
        {
            Console.WriteLine("Renderizando modelo en pantalla ");
        }

        public void Saltar()
        {
            Console.WriteLine("Saltando");
        }
    }
}
