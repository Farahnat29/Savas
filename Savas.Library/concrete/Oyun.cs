using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Savas.Library.Enum;
using Savas.Library.internalinterface;
using System.Windows.Forms;
using System.Drawing;

namespace Savas.Library.concrete
{
   
    public class Oyun : IOyun
    {
        #region alanalar

        private readonly Timer _gecensureTimer = new Timer { Interval = 1000 };
        private TimeSpan _gecensure;
        private readonly Panel _ucaksavarpanel;
        private Ucaksavar _ucaksavar;

        #endregion
        #region olaylar
        public event EventHandler GecenSureDegisti;

        #endregion
        #region ozellikler
        public bool DevamEdiyorMu { get; private set; }

        public TimeSpan Gecensure {
            get => _gecensure;
            private set
            {
                _gecensure = value;
                GecenSureDegisti?.Invoke(this, EventArgs.Empty);
            }
        }
        #endregion
        #region metotlar
        


        public Oyun(Panel ucaksavarpanel)
        {
            _gecensureTimer.Tick += GecensureTimer_Tick;
            _ucaksavarpanel = ucaksavarpanel;
        }
        
        private void GecensureTimer_Tick(object sender, EventArgs e)
        {
            Gecensure += TimeSpan.FromSeconds(1);
        }

        public void ateset()
        {
            throw new NotImplementedException();
        }

        public void baslat()
        {
            if (DevamEdiyorMu) return;
            _gecensureTimer.Start();
                DevamEdiyorMu = true;
            Ucaksavarolustur();
        }

        private void Ucaksavarolustur()
        {
            _ucaksavar = new Ucaksavar(_ucaksavarpanel.Width, _ucaksavarpanel.Size);
           
            _ucaksavarpanel.Controls.Add(_ucaksavar);
        }

        private void bitir()
        {
            if (!DevamEdiyorMu) return;
            _gecensureTimer.Stop();

            DevamEdiyorMu = false;

        }
        public void ucaksavarihareketettir(Yon yon)
        {

            if (!DevamEdiyorMu) return;

            _ucaksavar.HarekEtttir(yon);

        }
        #endregion
    }
}
