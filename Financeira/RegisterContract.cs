

namespace Financeira
{
    public class RegisterContract: Contrato
    {
        

        public static void StartProgram()
        {
            List<Contrato> ContractList = new List<Contrato>();
            int option = 0;

        while(option != 3)
            { 
            
            Console.WriteLine(@"
----- ESCOLHA UMA OPÇÃO ------
1. CADASTRAR NOVO CONTRATO
2. CONSULTAR CONTRATOS
3. SAIR
");

            
            do
            {
                option = Utilities.ReceivesAndValidatesIntegers();
            }while(option != 1 && option != 2 && option != 3);
        if(option != 3)
            {
                if (option == 1)// Cadastrar Contrato
                {
                    Console.Clear();
                    Console.WriteLine(@"
----- ESCOLHA O TIPO DE CONTRATO ------
1. PESSOA FISICA
2. PESSOA JURÍDICA
");

                    do
                    {
                        option = Utilities.ReceivesAndValidatesIntegers();
                    } while (option != 1 && option != 2);

                    if (option == 1)
                    {

                            ContratoPessoaFisica aux = new ContratoPessoaFisica();
                            aux.RequestContractData();
                            ContratoPessoaFisica pf = new ContratoPessoaFisica(aux.contractor, aux.value, aux.deadline, aux.cpf, aux.birthDate);
                            ContractList.Add(pf);
                            Console.WriteLine(pf.Contractor);
                    }
                    else
                    {
                            ContratoPessoaJuridica aux = new ContratoPessoaJuridica();
                            aux.RequestContractData();
                            ContratoPessoaJuridica pj = new ContratoPessoaJuridica(aux.contractor, aux.value, aux.deadline, aux.cnpj, aux.stateRegistration);
                            ContractList.Add(pj);
                        }
                }
                if(option == 2) //Consultar contrato
                    {
                        Console.WriteLine("Digite o nome do da Pessoa ou Empresa");
                        string seasearchContractName= Console.ReadLine();
                        int numberContract = 0;
                        Contrato contractFound = null;  
                        foreach (var contract in ContractList)
                        {
                            contractFound = contract;
                            if (contractFound.Contractor.ToString() == seasearchContractName)
                            {

                                contractFound.DisplaysInformation();
                                numberContract++;
                            }
                        }
                        if(numberContract == 0)
                        {
                            Console.WriteLine("Não foram encontrados contratos com o nome digitado.");
                        }
                        
                    }
            }
            
            
            
            
          }
        }
    }
}
