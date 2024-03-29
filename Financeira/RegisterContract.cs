﻿

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
                
                Console.WriteLine(Utilities.MenuRegisterOrQuery);

            
            do
            {
                option = Utilities.ReceivesAndValidatesIntegers();
            }while(option != 1 && option != 2 && option != 3);
        if(option != 3)
            {
                    
                if (option == 1)// Cadastrar Contrato
                {
                    Console.Clear();
                    Console.WriteLine(Utilities.MenuPfOrPj);

                        do
                    {
                        option = Utilities.ReceivesAndValidatesIntegers();
                    } while (option != 1 && option != 2);

                    if (option == 1)
                    {
                            
                            ContratoPessoaFisica pf = new ContratoPessoaFisica();
                            pf.RequestContractData();
                            pf = new ContratoPessoaFisica(pf.contractor, pf.value, pf.deadline, pf.cpf, pf.birthDate);
                            ContractList.Add(pf);
                           

                    }
                    else
                    {
                            ContratoPessoaJuridica pj = new ContratoPessoaJuridica();
                            pj.RequestContractData();
                            pj = new ContratoPessoaJuridica(pj.contractor, pj.value, pj.deadline, pj.cnpj, pj.stateRegistration);
                            ContractList.Add(pj);
                            
                     }
                        continue;
                    }
                if(option == 2) //Consultar contrato
                    {
                        Console.Clear();
                        Console.WriteLine(Utilities.MsgWhoIsLooking);
                        string seasearchContractName= Console.ReadLine();
                        int numberContract = 0;
                        Contrato contractFound = null;  
                        foreach (var contract in ContractList)
                        {
                            contractFound = contract;
                            if (contractFound.Contractor.ToString() == seasearchContractName)
                            {
                                Console.WriteLine(Utilities.MsgFoundData);
                                contractFound.DisplaysInformation();
                                numberContract++;
                            }
                        }
                        if(numberContract == 0)
                        {
                            Console.WriteLine(Utilities.MsgContractorSearchFeedback);
                        }
                        
                    }
            }
            
            
            
            
          }
        }
    }
}
