using System;

namespace Agenda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Funfando");

            bool running = true;
            Contact[] planner = new Contact[100];
            int index = 0;

            while (running)
            {
                Console.WriteLine("Escolha as opções abaixo");
                Console.WriteLine("1 - cadastrar contato, 2 - listar todos os contatos");
                Console.WriteLine("3 - busca, 4 - remover contato, 5 - sair");
                
                int escolha = int.Parse(Console.ReadLine());
                index = index;

            
                switch (escolha)
                {
                    case 1:
                        if(index < planner.Length){
                            
                            Console.WriteLine("Adicionar contato");
                            Contact contato = new Contact();
                            Console.WriteLine("Primeiro Nome: ");
                            string name = Console.ReadLine();
                            contato.primeiroNome = name;
                            Console.WriteLine("Sobrenome Nome: ");
                            string lastname = Console.ReadLine();
                            contato.sobrenome = lastname;
                            contato.nomeCompleto = name + " " + lastname;
                            Console.WriteLine("*--*--*--*--*--*");
                            Console.WriteLine("Data de nascimento: DD/MM/AAAA");
                            string nascimento = Console.ReadLine();
                            contato.dataNascimento = Convert.ToDateTime(nascimento);
                            Console.WriteLine("Tipo de contato");
                            Console.WriteLine("*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*");
                            Console.WriteLine("1 - Celular, 2 - Trabalho, 3 - Casa, 4 - Principal");
                            Console.WriteLine("5 - Pager, 6 - Fax Trabalho, 7 - Fax Casa, 8 - Outro");
                            Console.WriteLine("*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*");
                            contato.tipoContato = (PhoneType) int.Parse(Console.ReadLine());
                            Console.WriteLine("*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*");
                            Console.WriteLine("*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*");
                            Console.WriteLine("Digite o DDD");
                            string ddd = Console.ReadLine();
                            Console.WriteLine("Digite o número de telefone:");
                            string numeroDeTelefone = Console.ReadLine();
                            contato.telefone = $"({ddd}) " + $"{numeroDeTelefone}";
                            Console.WriteLine("Digite o Email: ");
                            contato.email = Console.ReadLine();
                            Console.WriteLine("---|Endereço|---");
                            Console.WriteLine("Bairro: ");
                            contato.bairro = Console.ReadLine();
                            Console.WriteLine("Cidade: ");
                            contato.cidade = Console.ReadLine();
                            Console.WriteLine("Estado: ");
                            contato.estado = Console.ReadLine();
                            contato.endereco = contato.bairro + ", " + contato.cidade + ", " + contato.estado;
                            Console.WriteLine("Observações sobre o contato: ");
                            string observacao = Console.ReadLine();
                            contato.observacao = observacao;
                            planner[index] = contato;
                            Console.WriteLine($"O index atual é {index}");
                            index++;
                            Console.WriteLine($"O index passou a ser {index}");
                        }else{

                            Console.WriteLine("Não há mais espaço na agenda");
                        }
                        
                        break;

                    case 2:
                        listarTodosContatos(planner);                        
                        break;
                    case 3:
                        Console.WriteLine("Qual o tipo de busca quer fazer?");
                        Console.WriteLine("1 - Nome, 2 - Nome Completo, 3 - Email");
                        Console.WriteLine("4 - Cidade, 5 - Tipo de Telefone");
                        int escolhaDeBusca =  int.Parse(Console.ReadLine());
                        if (escolhaDeBusca == 1)
                        {   
                            procuraPorNome(planner);
                            
                        }else if(escolhaDeBusca == 2){
                            procuraPorNomeCompleto(planner);
                        
                        }else if(escolhaDeBusca == 3){
                            procuraPorEmail(planner);
                        
                        }else if(escolhaDeBusca == 4){
                            procuraPorCidade(planner);
                        
                        }else if(escolhaDeBusca == 5){
                            procuraPorTipo(planner);
                        }


                        break;

                    case 4:
                        Console.WriteLine("Não Removemos contato ainda!");
                        // removerContato(planner, index);
                        break;
                    case 5:
                        Console.WriteLine("Saindo!");
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Nenhuma opção válida");
                        break;
                     
                }      
            }
        }

        public static void procuraPorNomeCompleto(Contact[] contatos){
            Console.WriteLine("Qual é o nome que busca?");
                string busca = Console.ReadLine();
                for (var i = 0; i < contatos.Length; i++)
                {   
                    //bool contains = clientList.Any(client => client.ClientName == userNickname);
                    try
                    {
                        if (contatos[i].nomeCompleto.Contains(busca))
                        {
                            Console.WriteLine(contatos[i].toString());
                            // Console.WriteLine(planner[i].toString());
                        }
                        
                    }
                    catch (System.Exception ex)
                    {
                        
                            // TODO
                        //  Console.WriteLine("Posição Vazia"+ i);
                    }
                    
                }
        }
        public static void procuraPorNome(Contact[] contatos){
            Console.WriteLine("Qual é o nome que busca?");
                string busca = Console.ReadLine();
                for (var i = 0; i < contatos.Length; i++)
                {
                    try
                    {
                        if (contatos[i].nomeCompleto.Contains(busca))
                        {
                            Console.WriteLine(contatos[i].toString());
                        }
                        
                    }
                    catch (System.Exception ex)
                    {
                        //  Console.WriteLine("Posição Vazia"+ i);
                    }
                    
                }
        }
        public static void procuraPorEmail(Contact[] contatos){
            Console.WriteLine("Qual é o Email que busca?");
                string busca = Console.ReadLine();
                for (var i = 0; i < contatos.Length; i++)
                {
                    try
                    {
                        if (contatos[i].email.Contains(busca))
                        {
                            Console.WriteLine(contatos[i].toString());
                        }
                        
                    }
                    catch (System.Exception ex)
                    {
                        // Console.WriteLine(ex);
                        //  Console.WriteLine("Posição Vazia"+ i);
                    }
                    
                }
        }
        public static void procuraPorCidade(Contact[] contatos){
            Console.WriteLine("Qual é o cidade do seu contato?");
                string busca = Console.ReadLine();
                for (var i = 0; i < contatos.Length; i++)
                {
                    try
                    {
                        if (contatos[i].cidade.Contains(busca))
                        {
                            Console.WriteLine(contatos[i].toString());
                        }
                        
                    }
                    catch (System.Exception ex)
                    {
                        // Console.WriteLine(ex);
                        //  Console.WriteLine("Posição Vazia"+ i);
                    }
                    
                }
        }
        public static void procuraPorTipo(Contact[] contatos){
            Console.WriteLine("Qual é tipo seu contato?");
            Console.WriteLine("*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*");
            Console.WriteLine("1 - Celular, 2 - Trabalho, 3 - Casa, 4 - Principal");
            Console.WriteLine("5 - Pager, 6 - Fax Trabalho, 7 - Fax Casa, 8 - Outro");
            Console.WriteLine("*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*");
               int busca = int.Parse(Console.ReadLine());
                for (var i = 0; i < contatos.Length; i++)
                {
                    try
                    {
                        if ((PhoneType)contatos[i].tipoContato == (PhoneType)busca)
                        {
                            Console.WriteLine(contatos[i].toString());
                        }
                        
                    }
                    catch (System.Exception ex)
                    {
                        // Console.WriteLine(ex);
                        //  Console.WriteLine("Posição Vazia"+ i);
                    }
                    
                }
        }

        public static void listarTodosContatos(Contact[] contatos){
            Console.WriteLine("Listar todos os contatos");
                        for (var i = 0; i < contatos.Length; i++)
                        {   if (contatos[i].primeiroNome != null)
                            {
                                Console.WriteLine(contatos[i].toString());
                            }
                            
                        }
        }
        public static void removerContato(Contact[] contatos, int index){
        //    Console.WriteLine("Qual contato quer remover?");
        //         string busca = Console.ReadLine();
        //         for (var i = 0; i < contatos.Length; i++)
        //         {
        //             try
        //             {
        //                 if (contatos[i].primeiroNome.Contains(busca))
        //                 {
        //                     Console.WriteLine("Qual é o tipo de contato?");
        //                     int tipoContato = int.Parse(Console.ReadLine());
                            
        //                     if ((PhoneType)contatos[i].tipoContato == (PhoneType)tipoContato)
        //                     {
        //                        for (var j = 0; j < contatos.Length; j++)
        //                        {
        //                             contatos[i] = contatos[i+1];            
        //                        }
        //                             Console.WriteLine("Contato Removido");
        //                             index --;
        //                     }else{
        //                         Console.WriteLine("Não há contato para remover!");
        //                     }
                            
        //                 }
                        
        //             }
        //             catch (System.Exception ex)
        //             {
        //                 // Console.WriteLine(ex);
        //                 //  Console.WriteLine("Posição Vazia"+ i);
        //             }
                    
        //         }
        }
    }
}
