namespace DesignPatterns.Builder;

public class Pessoa
{ 
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public string Documento { get; set; }
    public string Email { get; set; }
    public string DataNascimento { get; set; }
    public string Apelido { get; set; }

    //public override string ToString()
    //{
    //    return $"Nome: {Nome ?? ""}\nSobrenome: {Sobrenome ?? ""}\nDocumento:{}\nApelido: {Apelido ?? ""}";
    //}

}


