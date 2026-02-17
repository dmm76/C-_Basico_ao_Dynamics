using System;

public static class DocumentoBr
{
    public static bool EhCpf(string? valor)
    {
        var cpf = ApenasDigitos(valor);

        if (cpf.Length != 11)
            return false;
        if (TodosDigitosIguais(cpf))
            return false;

        // 1º dígito
        int soma = 0;
        for (int i = 0; i < 9; i++)
            soma += (cpf[i] - '0') * (10 - i);

        int d1 = soma % 11;
        d1 = d1 < 2 ? 0 : 11 - d1;

        if ((cpf[9] - '0') != d1)
            return false;

        // 2º dígito
        soma = 0;
        for (int i = 0; i < 10; i++)
            soma += (cpf[i] - '0') * (11 - i);

        int d2 = soma % 11;
        d2 = d2 < 2 ? 0 : 11 - d2;

        return (cpf[10] - '0') == d2;
    }

    public static bool EhCnpj(string? valor)
    {
        var cnpj = ApenasDigitos(valor);

        if (cnpj.Length != 14)
            return false;
        if (TodosDigitosIguais(cnpj))
            return false;

        int[] w1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
        int[] w2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

        // 1º dígito
        int soma = 0;
        for (int i = 0; i < 12; i++)
            soma += (cnpj[i] - '0') * w1[i];

        int d1 = soma % 11;
        d1 = d1 < 2 ? 0 : 11 - d1;

        if ((cnpj[12] - '0') != d1)
            return false;

        // 2º dígito
        soma = 0;
        for (int i = 0; i < 13; i++)
            soma += (cnpj[i] - '0') * w2[i];

        int d2 = soma % 11;
        d2 = d2 < 2 ? 0 : 11 - d2;

        return (cnpj[13] - '0') == d2;
    }

    public static string ApenasDigitos(string? valor)
    {
        if (string.IsNullOrWhiteSpace(valor))
            return "";
        Span<char> buffer = stackalloc char[valor.Length];
        int k = 0;

        foreach (var c in valor)
            if (c >= '0' && c <= '9')
                buffer[k++] = c;

        return new string(buffer[..k]);
    }

    private static bool TodosDigitosIguais(string s)
    {
        for (int i = 1; i < s.Length; i++)
            if (s[i] != s[0])
                return false;
        return true;
    }
}
