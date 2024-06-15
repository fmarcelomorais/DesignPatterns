using DesignPatterns.Builder;

IPessoaBuilder pessoa = new PessoaBuilder();
pessoa.Nome("Marcelo")
    .Sobrenome("Morais")
    .Apelido("Apelido")
    .Documento("62258932565");

Console.WriteLine(pessoa.ToString());

Console.ReadKey();

