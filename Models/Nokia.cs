namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }
        public override void InstalarApp(string nomeApp)
        {
            Console.WriteLine($"Instalando o app {nomeApp} no Nokia");
        }
    }
}