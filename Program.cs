using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
// IMPLEMENTADO

Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia(numero: "123456789", modelo: "Tijolão", imei: "001100110011", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("DIO");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Iphone iphone = new Iphone(numero: "123456789", modelo: "XS", imei: "110011001100", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("DIO");

Console.WriteLine("\n");