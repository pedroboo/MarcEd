using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contatos.Model;

namespace Contatos
{
    public class Contato
    {

        private int contatoID;
        private string nome;
        private string email;
        private string telefone;
        private Data dtNasc;


        public Contato()
        {
            dtNasc = new Data();
            contatoID = 0;
            Nome = "";
            Email = "";
            Telefone = "";
            dtNasc.adicionarDtNasc();
            



        }
        public Contato(int contatoID, string nome, string email, string telefone)
        {
            ContatoID = contatoID;
            Nome = nome;
            Email = email;
            Telefone = telefone;
        }



        public int ContatoID { get => contatoID; set => contatoID = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        internal Data DTNasc { get => dtNasc; set => dtNasc = value; }

        
    }



}

