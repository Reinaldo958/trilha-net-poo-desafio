using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram"); 

Console.WriteLine("\n");

Smartphone iphone = new Iphone(numero: "123456", modelo: "Modelo 1", imei: "111111111", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("WhatsApp");