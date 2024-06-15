
namespace DesignPatterns.Builder;

public interface IPessoaBuilder
{
    PessoaBuilder Nome(string nome);
    PessoaBuilder Sobrenome(string sobrenome);
    PessoaBuilder Documento(string documento);
    PessoaBuilder Email(string email);
    PessoaBuilder DataNascimento(string dataNascimento);
    PessoaBuilder Apelido(string apelido);
    Pessoa ConstroiPessoa();
}
