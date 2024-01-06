using DesafioPOO.Models;

Nokia nokia = new("51991637852", "Nokia 5125", "45df4d5f5ds6456sd", 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsNokia");
Console.WriteLine(nokia.ToString());

Console.WriteLine("\n*****************************************************************\n");

Iphone iphone = new("51994200462", "Iphone 10", "d4r2d4s4r46a6a877e4g2", 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApple");
Console.WriteLine(iphone.ToString());
