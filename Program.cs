using System;
using System.Collections.Generic;

namespace ProjetoWhatsapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Agenda agenda = new Agenda();


            Contato contato1 = new Contato();
            contato1.Numero = "5345-9875";
            contato1.Nome = "Pedro";

            agenda.Cadastrar(contato1);

            Contato contato2 = new Contato();
            contato2.Numero = "4564-4564";
            contato2.Nome = "Jon";

            agenda.Cadastrar(contato2);

            agenda.Excluir("perdo");

            List<Contato> lista = new List<Contato>();

            agenda.Listar();
            //foreach(Contato c in agenda.Listar()){
                //System.Console.WriteLine($"Nome: {c.Nome} / Tel: {c.Numero}");
            //}

            Mensagem mensagem = new Mensagem();
            mensagem.Texto = "Olá";
            mensagem.Destinatario = contato2;

            Console.WriteLine( mensagem.Enviar(mensagem.Destinatario) );


        }
    }
}
