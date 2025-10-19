using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaisesEstadosCidades
{
    internal class Controller
    {



        public Controller()
        {

        }
            

        public virtual void Excluir(Object obj)
        {

        }
        public virtual string  Salvar(object obj)
        {
            return null;
            
        }

        public virtual List<T> Listar<T>()
        {
            return null;


        }
        public virtual Object CarregaObj(int chave)
        {
            return null;
        }

        public virtual List<T>Pesquisar<T>(string chave)
        {
            return null;


        }



    }
}
