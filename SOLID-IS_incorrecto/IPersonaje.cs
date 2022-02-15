using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_IS_incorrecto
{
    interface IPersonaje
    {
        string Nombre { get; set; }

        void CalcularDanio();
        void Atacar(string JugadorParaAtacar);
        void Saltar();
        void Bloquear();   
        void Hablar(string JugadorParaHablar);
        void Comerciar(string JugadorParaComerciar);
        void ConectarBD();
        void GuardarEnBD();
        void CargarModelo3d();
        void RenderizarEnPantalla();

    }
}
