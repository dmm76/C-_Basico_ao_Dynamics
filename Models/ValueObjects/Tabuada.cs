namespace projeto01.Models.ValueObjects
{
    public class Tabuada
    {
        public int Numero { get; set; }
        public List<string> Resultados { get; set; }

        public Tabuada(int numero)
        {
            Numero = numero;
            Resultados = new List<string>();

            for (int i = 1; i <= 10; i++)
            {
                Resultados.Add($"{Numero} x {i} = {Numero * i}");
            }
        }
    }
}
