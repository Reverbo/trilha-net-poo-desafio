namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
         public Nokia () : base("9622-7922", "nokia", "ACX1678032", 64)
        {
            Numero = "9622-7922";
            Modelo = "nokia";
            Imei = "ACX1678032";
            Memoria = 128;
        }

        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string telegram)
        {
            Console.WriteLine($"Instalando o aplicativo {telegram} no Nokia");
        }
    }
}