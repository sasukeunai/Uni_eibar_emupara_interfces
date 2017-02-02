using System;
using System.Collections.Generic;

namespace Emuparadise.Models
{
    public partial class CE
    {
        public int IdConsola { get; set; }
        public int IdEmulador { get; set; }

        public virtual Consola IdConsolaNavigation { get; set; }
        public virtual Emulador IdEmuladorNavigation { get; set; }
    }
}
