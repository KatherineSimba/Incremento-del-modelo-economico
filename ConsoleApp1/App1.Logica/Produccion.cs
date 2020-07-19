namespace App1.Logica
{
    public class Produccion : GeneradorAutomaticoIdentificador
    {
        public Produccion() : base()
        {
        }
        public TipoMercaderia TipoMercaderia { get; set; }
        public string Material { get; set; }
    }
}