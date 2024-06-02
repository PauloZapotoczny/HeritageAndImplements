using ObjetoCelular.Models;

Console.WriteLine("Smartphone: NOKIA");
Nokia nokia = new Nokia("12344321","Modelo 12G", "31238191", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone: IPHONE");
Iphone iphone = new Iphone("56788765", "Modelo 12 Pro",  "987987987", 128);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");