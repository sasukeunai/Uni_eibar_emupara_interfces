using System;
using System.Collections.Generic;

namespace Emuparadise.Models
{
    public partial class Plataforma
    {
        public Plataforma()
        {
            Consola = new HashSet<Consola>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Consola> Consola { get; set; }
    }
}
