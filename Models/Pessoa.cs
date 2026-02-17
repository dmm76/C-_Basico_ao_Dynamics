using projeto01.Models.ValueObjects;

namespace projeto01.Models;

public class Pessoa
{
    public string Nome { get; private set; } = "";
    public int Idade { get; private set; }

    public Cpf Cpf { get; private set; }

    public Pessoa(string nome, int idade, string cpf)
    {
        AdicionarNome(nome);
        AdicionarIdade(idade);
        AdicionarCpf(cpf);
    }

    public void AdicionarNome(string nome)
    {
        var n = NormalizacaoTexto.NormalizarNomePtBr(nome);

        if (Nome == n)
            return;

        Nome = n;
    }

    public void AdicionarCpf(string cpf)
    {
        var digitos = DocumentoBr.ApenasDigitos(cpf);

        if (!DocumentoBr.EhCpf(digitos))
            throw new DomainException("CPF_INVALIDO", "CPF inválido");

        Cpf = new Cpf(digitos);
    }

    public void AdicionarIdade(int idade)
    {
        if (int.IsNegative(idade))
            throw new Exception("Idade não pode ser negativa");

        var i = idade;

        if (i > 130)
            throw new Exception("valor de idade inválido");

        Idade = i;
    }

    public void Apresentar()
    {
        Console.WriteLine($"Ola! Meu nome é {Nome} e tenho {Idade} anos e meu cpf é {Cpf}");
    }
}
