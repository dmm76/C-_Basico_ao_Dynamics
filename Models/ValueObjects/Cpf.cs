namespace projeto01.Models.ValueObjects;

public readonly record struct Cpf
{
    public string Valor { get; }

    public Cpf(string valor)
    {
        var digitos = DocumentoBr.ApenasDigitos(valor);

        if (!DocumentoBr.EhCpf(digitos))
            throw new DomainException("CPF_INVALIDO", "CPF inválido");

        Valor = digitos;
    }

    public override string ToString()
    {
        // Valor tem 11 dígitos: 00000000000
        return $"{Valor[..3]}.{Valor[3..6]}.{Valor[6..9]}-{Valor[9..]}";
    }
}
