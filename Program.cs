using DesafioPOO.Models;

// Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "12345", modelo: "Modelo 1", imei: "111111", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");


Console.WriteLine("Smartphone iPhone");
Smartphone iphone = new Iphone(numero: "6789", modelo: "Modelo 2", imei: "222222", memoria: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");