using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeira
{
    public class ContratoPessoaJuridica : Contrato
    {
        public string Cnpj { get; set; }
        public string StateRegistration { get; set; }

        public string cnpj;
        public string stateRegistration;

        public ContratoPessoaJuridica()
        {

        }
        public ContratoPessoaJuridica(string theContractor, decimal theValue, int theDeadline, string theCnpj, string theStateRegistration)
        {
            ContractId = Guid.NewGuid();
            Contractor = theContractor;
            Value = theValue;
            Deadline = theDeadline;
            Cnpj = theCnpj;
            StateRegistration = theStateRegistration;

        }

        public override decimal CalculateInstallment()
        {

            decimal installment = base.CalculateInstallment();

            installment += 3;

            return installment;

        }

        public override void RequestContractData()
        {
            base.RequestContractData();
            Console.WriteLine("Digite o CNPJ do Contratante: ");
            cnpj = Utilities.ReceivesAndValidatesCnpj();
            Console.Clear();
            Console.WriteLine("Digite a Inscrição Estadual do Contratante: ");
            stateRegistration = Utilities.ReceivesAndValidatesStateRegistration();
            Console.Clear();
        }

        public override void DisplaysInformation()
        {
            Console.WriteLine($"Contratante:{Contractor}");
            Console.WriteLine($"Inscrição:{StateRegistration}");
            Console.WriteLine($"Inscrição:{StateRegistration}");
            base.DisplaysInformation();
        }
    }
}
