using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contatos.Model;

namespace Contatos.Controller
{
    class Contatos
    {
        private int qtContatos = 0;
        private int mxContatos = 5;
        Contato[] contatos;

        public int mxcontatos
        {
            get { return mxContatos; }
        }
        public int qtcontatos
        {
            get { return qtContatos; }
        }

        public bool addContato(Contato contato)
        {

            bool adicioneiContato = false;
            bool podeAdicionar = (this.qtContatos < this.mxContatos);

            if (podeAdicionar)
            {

                contatos[qtContatos] = contato;
                contato.ContatoID = int.Parse(Console.ReadLine());



                  qtContatos++;
                adicioneiContato = true;
            
            }else
            {
                Console.WriteLine("Não foi possível adicionar");
            }
            return adicioneiContato;
        }
    }
}
