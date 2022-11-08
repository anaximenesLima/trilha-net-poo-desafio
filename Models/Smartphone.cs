namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
            
        }

        public void Ligar(string contato)
        {
            Console.WriteLine("Ligando... para " + contato);
        }

        public void ReceberLigacao(string contato)
        {
            Console.WriteLine("Recebendo ligação... de " + contato);
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}