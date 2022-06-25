using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeira
{
    public class ContratoPessoaFisica : Contrato
    {
        public string Cpf { get; set; }
        public DateTime BirthDate { get; set; }

        public string cpf;
        public DateTime birthDate;

        public ContratoPessoaFisica()
        {

        }
        public ContratoPessoaFisica(string theContractor, decimal theValue, int theDeadline, string theCpf, DateTime theBirthDate)
        {
            ContractId = Guid.NewGuid();
            Contractor = theContractor;
            Value = theValue;
            Deadline = theDeadline;
            Cpf = theCpf;
            BirthDate = theBirthDate;

        }
        public override decimal CalculateInstallment()
        {

            decimal installment = base.CalculateInstallment();

            if (CalculateAge() <= 30 )
            {
                installment += 1;
            }
            else if(CalculateAge() <= 40)
            {
                installment += 2;
            }
            else if (CalculateAge() <= 50)
            {
                installment += 3;
            }
            else
            {
                installment += 4;
            }
            

            return installment;

        }

        public override void RequestContractData()
        {
            base.RequestContractData();
            Console.WriteLine("Digite o CPF do Contratante: ");
            cpf = Utilities.ReceivesAndValidatesCpf();
            Console.Clear();
            Console.WriteLine("Digite a data de nascimento: ");
            birthDate = Utilities.ReceivesAndValidatesDateTime();
            Console.Clear();
        }

        public override void DisplaysInformation()
        {
            Console.WriteLine($"Contratante:{Contractor}");
            Console.WriteLine($"Idade:{CalculateAge()}");
            base.DisplaysInformation();

        }
        public int CalculateAge()
        {
            return DateTime.Now.Year - BirthDate.Year;
        }

       
    }
}
