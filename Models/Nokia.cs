namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        private string numero;
        private string modelo;
        private string imei;
        private int memoria;

        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            this.numero = numero;
            this.modelo = modelo;
            this.imei = imei;
            this.memoria = memoria;
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando o aplicativo " + nomeApp + "...");
        }
    }
}