using projeto01.Models;

var calculadora = new Calculadora();
calculadora.Dividir(120, 0);
calculadora.Potencia(2, 12);
calculadora.Seno(30);
calculadora.Cosseno(30);
calculadora.Tangente(30);

// try
// {
//     var p1 = new Pessoa("dOuGlAS MARCelO MONquerO", 10, "021.687.109-37");
//     p1.Apresentar();
//     var p2 = new Pessoa("marcio DA silva", 20, "02168710937");
//     p2.Apresentar();
// }
// catch (DomainException ex) when (ex.Code == "CPF_INVALIDO")
// {
//     Console.WriteLine($"Erro de documento: {ex.Message}");
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"Erro inesperado: {ex.Message}");
// }
