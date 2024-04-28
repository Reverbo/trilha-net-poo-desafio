using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia (numero: "9622-7922", modelo: "nokia", imei: "ACX1678032", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("telegram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone (numero: "4002-8922",modelo: "Iphone",imei: "ABC00221525",memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("tinder");