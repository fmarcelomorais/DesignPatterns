namespace DesignPatterns.Builder;

public class PessoaBuilder : IPessoaBuilder
{
    private readonly Pessoa _pessoa = new Pessoa();
    
    public Pessoa ConstroiPessoa()
    {
        return _pessoa;
    }

    public PessoaBuilder DataNascimento(string dataNascimento)
    {
       _pessoa.DataNascimento = dataNascimento;
        return this;
    }

    public PessoaBuilder Documento(string documento)
    {
        _pessoa.Documento = documento;
        return this;
    }

    public PessoaBuilder Email(string email)
    {
        _pessoa.Email = email;
        return this;
    }

    public PessoaBuilder Nome(string nome)
    {
        _pessoa.Nome = nome;
        return this;
    }

    public PessoaBuilder Sobrenome(string sobrenome)
    {
        _pessoa.Sobrenome = sobrenome;
        return this;
    }

    public PessoaBuilder Apelido(string apelido)
    {
        _pessoa.Apelido= apelido;
        return this;
    }

    public override string ToString()
    {
        return $"Nome: {_pessoa.Nome ?? ""}\nSobrenome: {_pessoa.Sobrenome ?? ""}\nDcoumento: {_pessoa.Documento ?? ""}" +
            $"\nEmail: {_pessoa.Email ?? ""}\nData de Nascimento: {_pessoa.DataNascimento ?? ""}\nApelido: {_pessoa.Apelido ?? ""}";
    }

}
