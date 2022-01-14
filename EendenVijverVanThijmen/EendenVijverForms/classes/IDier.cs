using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EendenVijverForms;
internal interface IDier
{
    public geslacht geslacht { get; set; }


    public string VraagGeslacht();
    public void moveDier(int locationX, int locationY);
}
