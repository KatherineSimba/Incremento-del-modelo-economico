namespace App1.Logica
{
    public class Producto : GeneradorAutomaticoIdentificador
    {
        public Producto() : base()
        {
        }
        public string Nombre { get; set; }
        public string Material { get; set; }
        public TipoMercaderia Produccion { get; set; }
        public string Producir()
        {
            return $"La empresa produce mercadería de {Produccion} con materiales biodegradables.";
        }
    }
}