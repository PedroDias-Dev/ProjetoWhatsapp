using System.Collections.Generic;

namespace ProjetoWhatsapp
{
    public interface IAgenda
    {
        void Cadastrar(Contato contato);

        void Excluir(string _contato);
        void Listar();
    }
}