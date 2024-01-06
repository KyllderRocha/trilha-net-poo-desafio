using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smarthphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("Smarthphone iPhone:");
Smartphone iphone = new Iphone(numero: "2342", modelo: "Modelo 5", imei: "2222222", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Nubank");

