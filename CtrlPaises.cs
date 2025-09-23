using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaisesEstadosCidades
{
    internal class CtrlPaises:Controller
    {
        ColecoesPaises acolpais;


        public CtrlPaises()
        {
            acolpais = new ColecoesPaises();

        }

        public override void Salvar(object obj)
        {
            base.Salvar(obj);
            acolpais.Inserir((Paises)obj);
        }
    }
}
