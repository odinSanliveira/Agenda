using System;
using System.Linq;

namespace Agenda
{
    class Program
    {       static bool running = true;
            static Contact[] planner = new Contact[100];
            static int index = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Funfando");

            

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
                            // contato.dataNascimento = Convert.ToDateTime(nascimento);
                            contato.dataNascimento = nascimento;
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
                            // Console.WriteLine($"O index atual é {index}");
                            // index++;
                            // Console.WriteLine($"O index passou a ser {index}");
                        }else{

                            Console.WriteLine("Não há mais espaço na agenda");
                        }
                        
                        break;

                    case 2:
                        listarTodosContatos();                        
                        break;
                    case 3:
                        busca();
                        break;

                    case 4:
                        Console.WriteLine("Qual nome quer remover?");
                        string nomeParaRemocao = Console.ReadLine();
                        removerContato(nomeParaRemocao);
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

        public static void procuraPorNomeCompleto(){
            Console.WriteLine("Qual é o nome que busca?");
                string busca = Console.ReadLine();
                for (var i = 0; i < planner.Length; i++)
                {   
                    
                    try
                    {
                        if (string.Equals(busca, planner[i].nomeCompleto, StringComparison.InvariantCultureIgnoreCase))
                        {
                            Console.WriteLine(planner[i].toString());
                            Console.WriteLine(diaDoAniversario(i));
                            
                        }
                        
                    }
                    catch (System.Exception ex)
                    {
                        
                            // TODO
                        //  Console.WriteLine("Posição Vazia"+ i);
                    }
                    
                }
        }
        public static void procuraPorNome(){
            Console.WriteLine("Qual é o nome que busca?");
                string busca = Console.ReadLine();
                for (var i = 0; i < planner.Length; i++)
                {
                    try
                    {
                        if (string.Equals(busca, planner[i].primeiroNome, StringComparison.InvariantCultureIgnoreCase))
                        {
                            Console.WriteLine(planner[i].toString());
                            Console.WriteLine(diaDoAniversario(i));

                        }
                        
                    }
                    catch (System.Exception ex)
                    {
                        //  Console.WriteLine("Posição Vazia"+ i);
                    }
                    
                }
        }
        public static void procuraPorEmail(){
            Console.WriteLine("Qual é o Email que busca?");
                string busca = Console.ReadLine();
                for (var i = 0; i < planner.Length; i++)
                {
                    try
                    {
                        if (string.Equals(busca, planner[i].email, StringComparison.InvariantCultureIgnoreCase))
                        {
                            Console.WriteLine(planner[i].toString());
                            Console.WriteLine(diaDoAniversario(i));
                        }
                        
                    }
                    catch (System.Exception ex)
                    {
                        // Console.WriteLine(ex);
                        //  Console.WriteLine("Posição Vazia"+ i);
                    }
                    
                }
        }
        public static void procuraPorCidade(){
            Console.WriteLine("Qual é o cidade do seu contato?");
                string busca = Console.ReadLine();
                for (var i = 0; i < planner.Length; i++)
                {
                    try
                    {
                        if (string.Equals(busca, planner[i].cidade, StringComparison.InvariantCultureIgnoreCase))
                        {
                            Console.WriteLine(planner[i].toString());
                            Console.WriteLine(diaDoAniversario(i));
                        }
                        
                    }
                    catch (System.Exception ex)
                    {
                        // Console.WriteLine(ex);
                        //  Console.WriteLine("Posição Vazia"+ i);
                    }
                    
                }
        }
        public static void procuraPorTipo(){
            Console.WriteLine("Qual é tipo seu contato?");
            Console.WriteLine("*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*");
            Console.WriteLine("1 - Celular, 2 - Trabalho, 3 - Casa, 4 - Principal");
            Console.WriteLine("5 - Pager, 6 - Fax Trabalho, 7 - Fax Casa, 8 - Outro");
            Console.WriteLine("*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*");
               int busca = int.Parse(Console.ReadLine());
                for (var i = 0; i < planner.Length; i++)
                {
                    try
                    {
                        if ((PhoneType)planner[i].tipoContato == (PhoneType)busca)
                        {
                            Console.WriteLine(planner[i].toString());
                            Console.WriteLine(diaDoAniversario(i));
                        }
                        
                    }
                    catch (System.Exception ex)
                    {
                        // Console.WriteLine(ex);
                        //  Console.WriteLine("Posição Vazia"+ i);
                    }
                    
                }
        }

        public static void listarTodosContatos(){
            Console.WriteLine("Listar todos os contatos");
                        for (var i = 0; i < planner.Length; i++)
                        {   if (planner[i].primeiroNome != null)
                            {
                                Console.WriteLine(planner[i].toString());
                                
                            }
                            
                        }
        }
        public static void busca(){
            Console.WriteLine("Qual o tipo de busca quer fazer?");
            Console.WriteLine("1 - Nome, 2 - Nome Completo, 3 - Email");
            Console.WriteLine("4 - Cidade, 5 - Tipo de Telefone");
            int escolhaDeBusca =  int.Parse(Console.ReadLine());
            if (escolhaDeBusca == 1)
            {   
                procuraPorNome();
                
            }else if(escolhaDeBusca == 2){
                procuraPorNomeCompleto();
            
            }else if(escolhaDeBusca == 3){
                procuraPorEmail();
            
            }else if(escolhaDeBusca == 4){
                procuraPorCidade();
            
            }else if(escolhaDeBusca == 5){
                procuraPorTipo();
            }
        }
        public static void removerContato(string nome){
            
            for (int i = 0; i < planner.Length; i++){
                if(planner[i].primeiroNome != null) {
                    if(planner[i].primeiroNome == nome){
                        planner = planner.Where((e, contact) => contact != i).ToArray();
                    }
                }
            }
        }

        public static string diaDoAniversario(int index){
            DateTime hoje = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);    
            string[] diaDoAniversario = planner[index].dataNascimento.Split('/');
            DateTime aniversario = new DateTime(DateTime.Today.Year,int.Parse(diaDoAniversario[1]),int.Parse(diaDoAniversario[0]));

            if (hoje == aniversario){
                return "Parabéns hoje é seu aniversário!!";
            }else if(hoje > aniversario){
                return "Seu aniversário já passou!";
                       
            }else{
                return $"Ainda faltam {aniversario.Subtract(DateTime.Today).TotalDays} dias!";
            }


        }
    }
}
