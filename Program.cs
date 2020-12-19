using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contatos.Model;
using Contatos.Controller;
using System.Windows.Forms;

namespace Contatos
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            Contato novoContato = new Contato();
            Controller.Contatos nvContatos = new Controller.Contatos();
            
            Console.WriteLine("Informe a opção desejada:");
                
            do
            {
                Console.WriteLine("1 - adicionar \n 2 - Pesquisar \n 3 - Excluir");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                       // nvContatos.addContato(contato);


                        break;


                }
            
            
            } while (op != 0);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new tlContatos());

            Console.ReadKey();
        }
    }
}
