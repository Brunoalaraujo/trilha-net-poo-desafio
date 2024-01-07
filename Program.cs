using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "111111111", memoria: 64);
Console.WriteLine("O numero do seu Nokia é: " + nokia.Numero);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "987654", modelo: "Iphone X", imei: "2222222222", memoria: 128);
Console.WriteLine("O numero do seu Iphone é: " + iphone.Numero);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");