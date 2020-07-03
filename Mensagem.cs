namespace ProjetoWhatsapp
{
    public class Mensagem
    {
        public string Texto {get; set;}
        public Contato Destinatario {get; set;}

        public string Enviar(Contato _destinatario){
            return $"Mensagem enviada para {_destinatario.Nome} com sucesso";
        }

    }
}