namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        // Propriedades
        public string Numero { get; set; }
        // As propriedades faltantes foram implementadas de acordo com o diagrama
        private string Modelo { get;}
        private string IMEI { get;}
        private int Memoria { get;}

        // Construtor
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            // Parâmetros do construtor passados para as propriedades
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }
        ////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////

        // Métodos

        // Método: Ligar
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        // Método: ReceberLigação
        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        // Método abtrato: InstalarAplicativo
        public abstract void InstalarAplicativo(string nomeApp);
    }
}