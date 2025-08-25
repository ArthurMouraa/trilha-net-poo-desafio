namespace DesafioPOO.Models
{
  //IMPLEMENTADO!!
  public class Nokia : Smartphone
  {

    //IMPLEMENTADO!!
    public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        
        //IMPLEMENTADO!!
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando Aplicativos no seu Nokia...");
            Console.WriteLine($"Informções do aparelho: Numero: {Numero}, Modelo: {Modelo}, Imei: {Imei}, Memoria: {Memoria}... ");
            Console.WriteLine($"Aplicativo {nomeApp} instalado com sucesso");
        }
  }
}