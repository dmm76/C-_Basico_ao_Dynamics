using projeto01.utils;

namespace projeto01.Models;

public readonly record struct Telefone
{
    public string Valor { get; }

    public Telefone(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            throw new DomainException("TELEFONE_VAZIO", "Número de telefone não pode ser vazio");

        var digitos = new string(input.Where(char.IsDigit).ToArray());

        if (digitos.Length < 10 || digitos.Length > 13)
            throw new DomainException("TELEFONE_INVALIDO", "Número de telefone inválido");

        // Se não começar com código do país, assume Brasil
        if (!digitos.StartsWith("55"))
            digitos = "55" + digitos;

        Valor = "+" + digitos;
    }

    public override string ToString() => Valor;
}
