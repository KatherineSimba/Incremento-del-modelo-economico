using System;

namespace App1.Logica
{
    public class Empresa : GeneradorAutomaticoIdentificador
    {
        public Empresa() : base()
        {
        }
        public string Nombre { get; set; }
        public string Direccion { get; set; }

        public Persona Contador { get; set; }
    }
}