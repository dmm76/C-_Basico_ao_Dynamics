public static class NormalizacaoTexto
{
    private static readonly HashSet<string> ParticulasMinusculas = new(
        StringComparer.OrdinalIgnoreCase
    )
    {
        "da",
        "de",
        "do",
        "das",
        "dos",
        "e",
    };

    public static string NormalizarNomePtBr(string nome)
    {
        if (nome is null)
            throw new Exception("Nome nao pode ser nulo");

        var trimmed = nome.Trim();
        if (string.IsNullOrWhiteSpace(trimmed))
            throw new Exception("Nome nao pode ser nulo ou em branco");

        // quebra por qualquer whitespace e remove vazios
        var partes = trimmed.Split((char[])null!, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < partes.Length; i++)
        {
            var p = CapitalizarComSeparadores(partes[i]);

            // regra PT-BR: partículas em minúsculo (exceto se for a primeira palavra)
            if (i > 0 && ParticulasMinusculas.Contains(p))
                p = p.ToLowerInvariant();

            partes[i] = p;
        }

        return string.Join(' ', partes);
    }

    private static string CapitalizarComSeparadores(string palavra)
    {
        palavra = palavra.Trim().ToLowerInvariant();

        palavra = CapitalizarAposSeparador(palavra, '-');
        palavra = CapitalizarAposSeparador(palavra, '\'');
        palavra = CapitalizarAposSeparador(palavra, '’');

        return PrimeiraLetraMaiuscula(palavra);
    }

    private static string CapitalizarAposSeparador(string s, char sep)
    {
        var partes = s.Split(sep);
        for (int i = 0; i < partes.Length; i++)
            partes[i] = PrimeiraLetraMaiuscula(partes[i]);

        return string.Join(sep, partes);
    }

    private static string PrimeiraLetraMaiuscula(string s)
    {
        if (string.IsNullOrEmpty(s))
            return s;
        return char.ToUpperInvariant(s[0]) + s.Substring(1);
    }
}
