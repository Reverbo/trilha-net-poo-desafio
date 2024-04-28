namespace DesafioPOO.Models
{

    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone (string numero) : base("4002-8922", "Iphone", "ABC00221525", 128)
        {
            Numero = "4002-8922";
            Modelo = "Iphone";
            Imei = "ABC00221525";
            Memoria = 128;
        }

public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }
        public override void InstalarAplicativo(string tinder)
        {
             Console.WriteLine($"Instalando o aplicativo {tinder} No Iphone");
        }
    }
}