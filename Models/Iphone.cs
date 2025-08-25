namespace DesafioPOO.Models
{
    
  //IMPLEMENTADO!!
  public class Iphone : Smartphone
    {

        //IMPLEMENTADO!!
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        //IMPLEMENTADO!!
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando Aplicativos no seu Iphone...");
            Console.WriteLine($"Informções do aparelho: Numero: {Numero}, Modelo: {Modelo}, Imei: {Imei}, Memoria: {Memoria} ");
            Console.WriteLine($"Aplicativo {nomeApp} instalado com sucesso");
        }

    }
}