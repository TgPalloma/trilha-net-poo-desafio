namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        protected string Numero { get; set; }
        protected string Modelo { get; }
        protected string Imei { get; }
        protected int Memoria { get; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;            
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);

        public override string ToString()
        {
            return $"Numero: {Numero}, Modelo: {Modelo}, Imei: {Imei}, Memoria: {Memoria}GB";
        }
    }
}