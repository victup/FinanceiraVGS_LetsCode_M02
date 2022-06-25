using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Financeira
{
    public static class Utilities
    {
        public static string ReceivesAndValidatesTextInput()
        {
            string texto = Console.ReadLine();

            do
            {
                if(String.IsNullOrEmpty(texto) || String.IsNullOrWhiteSpace(texto))
                {
                    Console.WriteLine("A entrada digitada não é uma entrada válida.");
                    texto = Console.ReadLine();
                }

            } while (String.IsNullOrEmpty(texto) || String.IsNullOrWhiteSpace(texto));

            return texto;
        }

        public static decimal ReceivesAndValidatesDecimalNumbers()
        {
            bool numberIsValid;
            decimal number;
            do
            {
                numberIsValid = decimal.TryParse(Console.ReadLine(), out number);
                if (!numberIsValid)
                {
                    Console.WriteLine("A entrada digitada não é uma entrada válida. Tente no formato 10.00");
                }
            } while (numberIsValid == false);

            return number;
        }

        public static int ReceivesAndValidatesIntegers()
        {
            bool numberIsValid;
            int number;
            do
            {
                numberIsValid = int.TryParse(Console.ReadLine(), out number);
                if (!numberIsValid)
                {
                    Console.WriteLine("A entrada digitada não é um número inteiro válido. ");
                }
            } while (numberIsValid == false);

            return number;
        }

        public static DateTime ReceivesAndValidatesDateTime()
        {
            Regex rgx = new Regex(@"\d{2}/\d{2}/\d{4}");
            var date = Console.ReadLine();
         
            while (!rgx.IsMatch(date))
            {
                Console.WriteLine("Não é uma data válida, digite no formato DD/MM/AAAA.");
                date = Console.ReadLine();
            }
              

            return Convert.ToDateTime(date);
        }

        public static string ReceivesAndValidatesCpf()
        {
            Regex rgx = new Regex(@"^\d{3}\.?\d{3}\.?\d{3}-?\d{2}$");
            var cpf = Console.ReadLine();

            while (!rgx.IsMatch(cpf))
            {
                Console.WriteLine("Não é um CPF válido, digite no formato 000.111.222-33.");
                cpf = Console.ReadLine();
            }


            return cpf;
        }

        public static string ReceivesAndValidatesCnpj()
        {
            Regex rgx = new Regex(@"^\d{2}\.?\d{3}\.?\d{3}\/?\d{4}\-?\d{2}$");
            var cnpj = Console.ReadLine();

            while (!rgx.IsMatch(cnpj))
            {
                Console.WriteLine("Não é um CNPJ válido, digite no formato 00.111.222.333/0001-44.");
                cnpj = Console.ReadLine();
            }


            return cnpj;
        }

        public static string ReceivesAndValidatesStateRegistration()
        {
            Regex rgx = new Regex(@"[0-9]{9}");
            var stateRegistration = Console.ReadLine();

            while (!rgx.IsMatch(stateRegistration))
            {
                Console.WriteLine("Não é uma inscrição estadual válida, trata-se de um número com 9 dígitos.");
                stateRegistration = Console.ReadLine();
            }


            return stateRegistration;
        }
    }
}
