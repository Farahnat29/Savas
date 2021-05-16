using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Savas.Library.Enum;
using Savas.Library.internalinterface;
using System.Windows.Forms;

namespace Savas.Library.concrete
{
    public class Oyun : IOyun
    {

        public bool DevamEdiyorMu { get; private set; }

        public TimeSpan Gecensure { get; }

        public void ateset()
        {
            throw new NotImplementedException();
        }

        public void baslat()
        {
            if (DevamEdiyorMu) return;
            MessageBox.Show("Oyun basladi.");
                DevamEdiyorMu = true;
        }
        private void bitir()
        {
            if (!DevamEdiyorMu) return;
            DevamEdiyorMu = false;

        }
        public void ucaksavarihareketettir(Yon yon)
        {
            throw new NotImplementedException();
        }
    }
}
