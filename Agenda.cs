using System.Collections.Generic;
using System.IO;
using System;
using System.Linq;

namespace ProjetoWhatsapp
{
    public class Agenda : IAgenda
    {
        List<Contato> contatos = new List<Contato>();

        private const string PATH = "Database/agenda.csv";

        public Agenda(){
            // Verifica a existencia da pasta ou do arquivo
            // Caso nao exista, ele cria o diretorio e o arquivo
            string pasta = PATH.Split("/")[0];
            //pasta
            if (!Directory.Exists(pasta)) {
                Directory.CreateDirectory(pasta);
            }
            //arquivo csv
            if(!File.Exists(PATH)){
                File.Create(PATH).Close();
            }
        }

        public void Cadastrar(Contato contato)
        {
            //throw new System.NotImplementedException();
            var linha = new string[] { PrepararLinhaCSV(contato) };

            File.AppendAllLines(PATH, linha);
        }

        public void Excluir(string _contato)
        {
            //throw new System.NotImplementedException();
            List<string> linhas = new List<string>();

            using(StreamReader arquivo = new StreamReader(PATH)){
                string linha;
                while((linha = arquivo.ReadLine()) != null){
                    linhas.Add(linha);
                }
            }

            //remove as linhas que tiverem o argumento (_contato)
            linhas.RemoveAll(l => l.Contains(_contato));

            using(StreamWriter output = new StreamWriter(PATH)){
                foreach(string ln in linhas)
                {
                    output.Write(ln + "\n");
                }
            }
        }

        public void Listar()
        {   
            // retorna criando variavel
            //Unhandled exception. System.IndexOutOfRangeException: Index was outside the bounds of the array.

            //string[] linhas = File.ReadAllLines(PATH);

            //foreach (string linha in linhas){
                //string[] linhas = File.ReadAllLines(PATH);
                //string[] dado = linha.Split(";");

                //Contato c = new Contato( dado[0], dado[1]);
                //contatos.Add(c);
            //}
            
            //return contatos;

            // retorna lendo as linhas de contato no csv
            int counter = 0;
            //throw new System.NotImplementedException();
            System.Console.WriteLine("-- Esses sao os contatos na sua agenda:");
            List<string> linhas = new List<string>();

            using(StreamReader arquivo = new StreamReader(PATH)){
                string linha;
                while((linha = arquivo.ReadLine()) != null){
                    System.Console.WriteLine(linha);  
                    counter++; 
                }    
            }      
        }


        public string PrepararLinhaCSV(Contato x){
            // Organiza a escrita no .csv
            // retorna nome e numero
            return $"Nome - {x.Nome} / Numero - {x.Numero}";
        }
    }
}