using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Nokia nokia = new Nokia(numero: "123", modelo: "Tijolão", imei: "111", memoria: 8);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarApp("Snake Game");

Console.WriteLine("\n");


Console.WriteLine("Smartphone Iphone");
Iphone iphone = new Iphone(numero: "789", modelo: "14 Pro Max", imei: "222", memoria: 4);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarApp("Instagram");

