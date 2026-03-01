namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        //Numero, Modelo, IMEI e Memoria
        public string Numero { get; set; }
        // Implementar as propriedades faltantes de acordo com o diagrama
        public string Modelo { get; set; }

        public string IMEI { get; set; }
        public int Memoria { get; set; }


        public string GetModelo()
        {
            return Modelo;
        }

        public Smartphone(string numero)
        {
            Numero = numero;
        }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
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
    }
}