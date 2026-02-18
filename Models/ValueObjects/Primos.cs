namespace projeto01.Models.ValueObjects
{
    public class Primos
    {
        public int Numero { get; set; }
        public bool EhPrimo { get; set; }

        public Primos(int numero)
        {
            Numero = numero;
            EhPrimo = VerificarPrimo(numero);
        }

        public void ExibirPrimo()
        {
            if (EhPrimo)
            {
                Console.WriteLine($"{Numero} é um número primo.");
            }
            else
            {
                Console.WriteLine($"{Numero} não é um número primo.");
            }
        }

        public bool VerificarPrimo(int numero)
        {
            if (numero <= 1)
                return false; // Números menores ou iguais a 1 não são primos
            if (numero == 2)
                return true; // O número 2 é primo
            if (numero % 2 == 0)
                return false; // Números pares maiores que 2 não são primos

            for (int i = 3; i <= Math.Sqrt(numero); i += 2)
            {
                if (numero % i == 0)
                {
                    return false; // Encontrou um divisor, não é primo
                }
            }

            return true; // É primo
        }
    }
}
