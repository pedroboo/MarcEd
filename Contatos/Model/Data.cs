using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contatos.Model
{
    class Data
    {
        private int IDdtNasc;
        private int dia, mes, ano;

        public Data(int iDdtNasc, int dia, int mes, int ano)
        {
            IDdtNasc = iDdtNasc;
            this.dia = dia;
            this.mes = mes;
            this.ano = ano;
        }

        public Data(int dia, int mes, int ano)
        {
            dia = this.dia;
            mes = this.mes;
            ano = this.ano;
        }

        public Data()
        {
            dia = this.dia;
            mes = this.mes;
            ano = this.ano;
        }
        public int iDdtNasc { get => IDdtNasc; set => IDdtNasc = value; }

        public void adicionarDtNasc()
        {
            Data dt = new Data();
            Console.WriteLine("Informe o dia: ");
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o mes: ");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o ano: ");
            ano = int.Parse(Console.ReadLine());
           
        }

        public  void    adicionarDtNasc(int x,int y,int z)
        {
            Data dt = new Data();
            dia = x;
            mes = y;
            ano = z;
       }
        public int getIdade()
        {
            int idade = 0;
            int mesA = 1;int anoA = 2020;

            Console.WriteLine("Informe o mês atual: ");
            mesA = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o ano: ");
            anoA = int.Parse(Console.ReadLine());

            if (mesA < mes)
            {
                idade = (anoA - ano) - 1;
            }
            else
            {
                idade = (anoA - ano); 
            }

            return idade;
        }

        public override string ToString()
        {
            
            return  "Dia :"+dia+" Mes "+mes+" Ano"+ano+ base.ToString();

        }



    }
}
