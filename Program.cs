Console.WriteLine("Média Decimal");

int quantidade;
Console.WriteLine("Digite a quantidade de números a serem usados");
Int32.TryParse(Console.ReadLine(), out quantidade);

decimal NumeroDigitado;
int auxiliar = 0;

decimal soma = 0;
decimal MaiorNumero = 999999.99M;
decimal MenorNumero = 999999.99M;
    

while (auxiliar < quantidade)
{
    auxiliar = auxiliar + 1;
    Console.Write($"Numero #{auxiliar}: ");
    NumeroDigitado = Convert.ToDecimal(Console.ReadLine());
    soma = soma + NumeroDigitado;

      if (auxiliar == 1)
    {
        MaiorNumero = NumeroDigitado;
        MenorNumero = NumeroDigitado;
    }

    if (NumeroDigitado > MaiorNumero)
    {
        MaiorNumero = NumeroDigitado;
    }

    if (NumeroDigitado < MenorNumero)
    {
        MenorNumero = NumeroDigitado;
    };
}

if (auxiliar > 0)
{
    decimal Media = soma / quantidade;
    Console.Clear();
    Console.WriteLine($"Soma...: {soma:N2}");
    Console.WriteLine($"Média..: {Media:N2}");
    Console.WriteLine($"Menor..: {MenorNumero:N2}");
    Console.WriteLine($"Maior..: {MaiorNumero:N2}");
}
