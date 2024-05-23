using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
Console.WriteLine("iPhone");
Smartphone iphone = new Iphone(numero: "(11)99999-9999", modelo: "Tester 9", imei: "98765431", memoria: 32);
Console.WriteLine($"Numero: {iphone.Numero}");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Call of Duty"); 
Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
Console.WriteLine("Nokia");
Smartphone nokia = new Nokia(numero: "(11)00000-0000", modelo: "Tech 10", imei: "5678901234", memoria: 128);
Console.WriteLine($"Numero: {nokia.Numero}");
nokia.Ligar();
nokia.InstalarAplicativo("Wild Rift");
Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");