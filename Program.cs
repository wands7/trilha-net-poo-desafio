using DesafioPOO.Models;

Console.WriteLine("Nokia");
Smartphone nokia = new Nokia(numero: "12345", modelo: "O do bom", imei: "7777777", memoria: 240);
nokia.Ligar();
nokia.InstalarAplicativo("whatsapp");

Console.WriteLine("\n");

Smartphone iphone = new Iphone(numero: "54321", modelo: "O do melhor", imei: "6666666", memoria: 500);
iphone.ReceberLigacao();
iphone.InstalarAplicativo();