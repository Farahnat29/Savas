using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Savas.Library.Abstract;
using System.Drawing;

namespace Savas.Library.concrete
{
  internal  class Ucaksavar:Cisim
    {
        public Ucaksavar(int panelgenisligi, Size hareketAlaniBoyutlari):base(hareketAlaniBoyutlari)
        {
            Center = panelgenisligi / 2;
                    
            HareketMesafesi = Width;
        }
    }
}
