using System.Text;
using DesafioProjetoHospedagem.Models;
using System;

Console.OutputEncoding = Encoding.UTF8;

// Cria a lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

// Solicita ao usuário o número de hóspedes
Console.Write("Informe o número de hóspedes: ");
int numeroDeHospedes = int.Parse(Console.ReadLine());

// Cria a suíte com capacidade 2
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

// Verifica se o número de hóspedes não excede a capacidade da suíte
if (numeroDeHospedes > suite.Capacidade)
{
    Console.WriteLine("A quantidade de hóspedes excede o limite da suíte.");
}
else
{
    // Solicita ao usuário que informe os nomes dos hóspedes
    for (int i = 0; i < numeroDeHospedes; i++)
    {
        Console.Write($"Informe o nome do hóspede {i + 1}: ");
        string nomeHospede = Console.ReadLine();
        Pessoa hospede = new Pessoa(nome: nomeHospede);
        hospedes.Add(hospede);
    }

    // Solicita ao usuário o número de dias reservados
    Console.Write("Informe o número de dias reservados: ");
    int diasReservados = int.Parse(Console.ReadLine());

    // Cria uma nova reserva, passando a suíte e os hóspedes
    Reserva reserva = new Reserva(diasReservados);
    reserva.CadastrarSuite(suite);
    reserva.CadastrarHospedes(hospedes);

    // Exibe a quantidade de hóspedes e o valor da diária
    Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
    Console.WriteLine($"Valor Total das Diárias: {reserva.CalcularValorDiaria()}");
}
