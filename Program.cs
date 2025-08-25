using DesafioPOO.Models;


//IMPLEMENTADO!!
Console.WriteLine("Algo");

Nokia aparelho1 = new Nokia("81 - 94879718", "Nokia Terian", "00392742", 120);

aparelho1.InstalarAplicativo("Facebook");

Iphone iphone1 = new Iphone("82 - 9487000", "Iphone mini", "00392742", 120);
iphone1.InstalarAplicativo("Instagram");
iphone1.Ligar();
iphone1.ReceberLigacao();