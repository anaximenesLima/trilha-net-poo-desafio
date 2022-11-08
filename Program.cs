using DesafioPOO.Models;



Console.WriteLine("Srmatphone Nokia: ");
Nokia n = new Nokia(numero: "9999-9999", modelo: "N1234", imei: "1234", memoria: 64);
n.Ligar("1123-1234");
n.InstalarAplicativo("WhatsApp");

Console.WriteLine();

Console.WriteLine("Srmatphone Iphone: ");
Iphone i = new Iphone(numero: "1111-1111",modelo: "I123",imei:  "123", memoria:  128);
i.ReceberLigacao("9991-9992");
i.InstalarAplicativo("Spotfy");