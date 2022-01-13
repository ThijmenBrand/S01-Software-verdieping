using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EendenVijverForms;
internal interface IDier
{
    geslacht Geslacht
    {
        get => Geslacht;
        private set => Geslacht = value;
    }

    public string VraagGeslacht();
}
