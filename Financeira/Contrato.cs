using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeira
{
    public class Contrato
    {
        public Guid ContractId { get; protected set; }
        public string Contractor { get; set; }
        public decimal Value { get; set; }
        public int Deadline { get; set; }

        public Guid contractId;
        public string contractor;
        public decimal value;
        public int deadline;

      

        public virtual decimal CalculateInstallment()
        {

            decimal installment = Value / Deadline;

            return installment;
            
        }

        public virtual void RequestContractData()
        {
            contractId = Guid.NewGuid();
            Console.WriteLine("Digite o nome do contratante: ");
            contractor = Utilities.ReceivesAndValidatesTextInput();
            Console.Clear();
            Console.WriteLine("Digite o valor do contrato: ");
            value = Utilities.ReceivesAndValidatesDecimalNumbers();
            Console.Clear();
            Console.WriteLine("Digite o prazo do contrato em meses: ");
            deadline = Utilities.ReceivesAndValidatesIntegers();
            Console.Clear();

        }

        public virtual void DisplaysInformation()
        {
            
            Console.WriteLine($"Valor do Contrato: R${Value}");
            Console.WriteLine($"Prazo:{Deadline} meses.");

            var deadline = Deadline;
            var numberInstallment = 1;

            while (deadline != 0)
            {
                Console.WriteLine($"Prestação nº {numberInstallment}:.....................R$ {CalculateInstallment()}");
                deadline--;
                numberInstallment++;
            }

        }
    }

    
}
