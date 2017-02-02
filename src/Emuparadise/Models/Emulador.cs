using System;
using System.Collections.Generic;

namespace Emuparadise.Models
{
    public partial class Emulador
    {
        public Emulador()
        {
            CE = new HashSet<CE>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Plataforma { get; set; }

        public virtual ICollection<CE> CE { get; set; }
    }
}
