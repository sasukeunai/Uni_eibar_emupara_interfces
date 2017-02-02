using System;
using System.Collections.Generic;

namespace Emuparadise.Models
{
    public partial class Consola
    {
        public Consola()
        {
            CE = new HashSet<CE>();
            Videojuego = new HashSet<Videojuego>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public int PlataformaId { get; set; }

        public virtual ICollection<CE> CE { get; set; }
        public virtual ICollection<Videojuego> Videojuego { get; set; }
        public virtual Plataforma Plataforma { get; set; }
    }
}
