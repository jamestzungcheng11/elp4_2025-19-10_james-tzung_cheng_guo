using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaisesEstadosCidades
{
     internal class  Estados:Pai
    {
        protected string estado;
        protected string uf;
        protected Paises opais;


        public Estados()
        {
            estado = string.Empty;
            uf = string.Empty;
            opais = new Paises();
        }

        public Estados(int codigo,DateTime datcad,DateTime ultal,string estado,string uf,Paises opais):base(codigo,datcad,ultal)
        {
            this.estado = estado;
            this.uf = uf;
            this.opais = opais;
        }

        public string Estado
        {
            get => estado;
            set => estado = value;
        }
        public string Uf
        {
            get => uf;
            set=>uf= value;
        }
        public Paises Opais
        {
            get => opais;
            set => opais = value;

        }
    }
}
