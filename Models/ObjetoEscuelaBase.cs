using System;

namespace escuela_aspnet_core_app.Models
{
    public abstract class ObjetoEscuelaBase
    {
        public string UniqueId { get; set; }
        public string Nombre { get; set; }

        public ObjetoEscuelaBase()
        {
            UniqueId = Guid.NewGuid().ToString();
        }

        public override string ToString()
        {
            return $"{Nombre},{UniqueId}";
        }
    }
}