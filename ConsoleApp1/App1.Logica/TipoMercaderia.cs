using System;
using System.Collections.Generic;
using System.Text;

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

    public enum TipoMercaderia
    {
        Vasos,
        Cuertos,
        Platos,
        Fundas,
        Sorbetes,
        Contenedores
    }
}