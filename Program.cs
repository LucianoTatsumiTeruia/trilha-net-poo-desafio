using System.ComponentModel;
using DesafioPOO.Models;

// Alguns testes realizados com as classes Nokia e Iphone

Nokia n1 = new Nokia(numero: "123", modelo: "Modelo 0", imei: "1111", memoria: 256);
Console.WriteLine($"Smartphone da Nokia de número {n1.Numero}:");
n1.Ligar();
n1.InstalarAplicativo("Pokémon GO");
n1.ReceberLigacao();
n1.Numero = "123";
Console.WriteLine($"O número do smartphone da Nokia foi alterado para: {n1.Numero}");

Console.WriteLine("\n");


Iphone i1 = new Iphone(numero: "456", modelo: "Modelo 1", imei: "2222", memoria: 128);
Console.WriteLine($"Smartphone do Iphone de número {i1.Numero}:");
i1.ReceberLigacao();
i1.InstalarAplicativo("Genshin Impact");
i1.Ligar();
i1.Numero = "123";
Console.WriteLine($"O número do smartphone do Iphone foi alterado para: {i1.Numero}");