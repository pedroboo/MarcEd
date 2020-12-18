using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contatos.Model;
using Contatos.Controller;


namespace Contatos
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            Contato novoContato = new Contato();
            
            Console.WriteLine("Informe a opção desejada:");
                
            do
            {
                Console.WriteLine("1 - adicionar \n 2 - Pesquisar \n 3 - Excluir");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.WriteLine(" vou adicionar ! ");
                        novoContato.ContatoID = int.Parse(Console.ReadLine());
                        novoContato.addContato();
                        break;
                }
            
            
            } while (op != 0);



            Console.ReadKey();
        }
    }
}
