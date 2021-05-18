﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Savas.Library.Enum;
using Savas.Library.internalinterface;
using System.Windows.Forms;
using System.Drawing;
using Savas.Library.Interface;

namespace Savas.Library.concrete
{
   
    public class Oyun : IOyun
    {
        #region alanalar

        private readonly Timer _gecensureTimer = new Timer { Interval = 1000 };
        private readonly Timer _hareketTimer = new Timer { Interval = 100 };
        private TimeSpan _gecensure;
        private readonly Panel _ucaksavarpanel;
        private readonly Panel _savasAlaniPanel;
        private Ucaksavar _ucaksavar;
        private readonly List<Mermi> _mermiler = new List<Mermi>();

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
        


        public Oyun(Panel ucaksavarpanel, Panel savasAlanipanel)
        {
            _gecensureTimer.Tick += GecensureTimer_Tick;
            _savasAlaniPanel = savasAlanipanel;
            _ucaksavarpanel = ucaksavarpanel;
            _hareketTimer.Tick += hareketTimer_Tick;
        }
        
        private void GecensureTimer_Tick(object sender, EventArgs e)
        {
            Gecensure += TimeSpan.FromSeconds(1);
        }
        private void hareketTimer_Tick(object sender, EventArgs e)
        {
            MermileriHareketEttir();
        }

        private void MermileriHareketEttir()
        {
            for (int i = _mermiler.Count - 1; i >= 0; i--)
            {
                var mermi = _mermiler[i];
                var carptiMi = mermi.HarekEtttir(Yon.Yukari);

                if (carptiMi)
                {
                    _mermiler.Remove(mermi);
                    _savasAlaniPanel.Controls.Remove(mermi);
                }
            }
        }

        public void ateset()
        {
            if (!DevamEdiyorMu) return;

            var mermi = new Mermi(_savasAlaniPanel.Size, _ucaksavar.Center);
            _mermiler.Add(mermi);
            _savasAlaniPanel.Controls.Add(mermi);
        }

        public void baslat()
        {
            if (DevamEdiyorMu) return;
            zamanlayicilaribaslat();
            DevamEdiyorMu = true;
            Ucaksavarolustur();
        }

        private void zamanlayicilaribaslat()
        {
            _hareketTimer.Start();
            _gecensureTimer.Start();
        }

        private void Ucaksavarolustur()
        {
            _ucaksavar = new Ucaksavar(_ucaksavarpanel.Width, _ucaksavarpanel.Size);
           
            _ucaksavarpanel.Controls.Add(_ucaksavar);
        }

        private void bitir()
        {
            if (!DevamEdiyorMu) return;
            zamanlayicilaribitir();

            DevamEdiyorMu = false;
        }

        private void zamanlayicilaribitir()
        {
            _gecensureTimer.Stop();
            _hareketTimer.Stop();
        }

        public void ucaksavarihareketettir(Yon yon)
        {

            if (!DevamEdiyorMu) return;

            _ucaksavar.HarekEtttir(yon);

        }
        #endregion
    }
}
