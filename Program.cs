string continuar = "s";

while (continuar == "s")
{
    Console.WriteLine("********** Classificador de nível de Herói **********\n");

    Console.Write("Digite o nome do seu herói: ");
    string? nome = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(nome))
        nome = "Desconhecido";

    Console.Write("Digite a quantidade de experiência (XP): ");

    double experiencia;
    while (!double.TryParse(Console.ReadLine(), out experiencia))
    {
        Console.Write("Valor inválido! Digite um número: ");
    }

    string nivel = experiencia switch
    {
        < 1000 => "Ferro",
        <= 2000 => "Bronze",
        <= 5000 => "Prata",
        <= 7000 => "Ouro",
        <= 8000 => "Platina",
        <= 9000 => "Ascendente",
        <= 10000 => "Imortal",
        _ => "Radiante"
    };

    Console.WriteLine($"\nO Herói de nome {nome} está no nível de {nivel}");

    Console.Write("\nDeseja classificar outro herói? (s/n): ");
    continuar = Console.ReadLine()?.ToLower() ?? "n";

    Console.Clear();
}