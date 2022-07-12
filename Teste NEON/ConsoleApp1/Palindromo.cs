using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Palindromo
    {
        public bool VerificaPalindromo()
        {
            string texto = "O romano acata amores a damas amadas e Roma ataca o namoro";

            texto = texto.ToLower().Replace(" ", "");

            char[] str = texto.ToCharArray();

            int qtd = str.Length;

            string strComparacao = "";

            for (int i = (qtd - 1); i >= 0; i--)
            {
                strComparacao += str[i].ToString();
            }

            if (texto == strComparacao)
                return true;
            else
                return false;
        }


        public void GetFibonacci(int numero)
        {
            int controle = 1;
            int anterior = 0;
            int auxiliar = 0;

            for (int i = 0; i < numero; i++)
            {
                auxiliar = anterior;
                anterior = controle;
                controle = anterior + auxiliar;
                Console.WriteLine(controle);
            }
        }
    }
}
