using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class Calculadora
    {
        private List<string> _hist;

        public Calculadora()
        {
            _hist = new List<string>();
        }
        public int Somar(int a,int b)
        {
            _hist.Add("Operacao Adicao");
            return a+b;
        }
        public int Subtrair(int a,int b)
        {
            _hist.Add("Operacao Subtracao");
            return a-b;
        }
        public int Multiplicar(int a,int b)
        {
            _hist.Add("Operacao Multiplicacao");
            return a*b;
        }
        public int Dividir(int a,int b)
        {
            _hist.Add("Operacao Divisao");
            return a/b;
        }
        public List<string> Historico(){
            _hist.RemoveRange(3,_hist.Count - 3);
            return  _hist;
        }        
    }
}