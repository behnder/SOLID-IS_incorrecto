using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_IS_incorrecto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========");
            IPersonaje guerrero = new Guerrero("guerrero1");
            guerrero.ConectarBD();
            guerrero.GuardarEnBD();
            guerrero.RenderizarEnPantalla();
            guerrero.Atacar("enemigo");
            guerrero.Bloquear();
            guerrero.CalcularDanio();
            guerrero.Comerciar("NPC");
            guerrero.Hablar("NPC");
            guerrero.Saltar();
    

            Console.ReadKey();


        }
    }
}
