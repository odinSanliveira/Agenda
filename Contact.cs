using System;

namespace Agenda{


        public struct Contact
        {
            
        
            public Contact(string name  , string lastname, string phone, 
            string emailAddress, string city, string district, string state,
            string address, PhoneType type, 
            string observation, string birthday)
                {   
                    primeiroNome = name;
                    sobrenome = lastname;         
                    nomeCompleto = name + " " + lastname;
                    tipoContato = type;
                    telefone = phone;
                    email = emailAddress;
                    cidade = city;
                    bairro = district;
                    estado = state;
                    endereco = address;
                    observacao = observation;
                    dataNascimento = birthday;

                }

                
                public string primeiroNome { get; set; }
                public string sobrenome { get; set; }
                public string nomeCompleto { get; set; }
                public PhoneType tipoContato { get; set; }
                public string telefone { get; set; }
                public string email { get; set; }
                public string cidade { get; set; }
                public string estado { get; set; }
                public string bairro { get; set; }
                public string endereco { get; set; }
                public string dataNascimento{get; set;}
                public string observacao{get; set;}

                public string toString(){
                    string retornoDeContato = $"{nomeCompleto} || {telefone} || {tipoContato} ||{dataNascimento} || {email} || {endereco} || {observacao}";
                    return retornoDeContato;
                }
            
        }
    }
