using System;
using System.Collections.Generic;

namespace Emuparadise.Models
{
    public partial class Videojuego
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Genero { get; set; }
        public string Descripcion { get; set; }
        public int IdConsola { get; set; }

        public virtual Consola IdConsolaNavigation { get; set; }
    }
}
