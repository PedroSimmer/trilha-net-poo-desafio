using System.ComponentModel;
using DesafioPOO.Models;

Smartphone nokia = new Nokia(numero:"456",modelo:"modelo1",imei:"22222222",memoria:32);
Smartphone iphone = new Iphone(numero:"123",modelo:"modelo2",imei:"11111111",memoria:128);

Console.WriteLine($"Telefone NOKIA");
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("\n");

Console.WriteLine("Telefone IPHONE :");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whats'up");

