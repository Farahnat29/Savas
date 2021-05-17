﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Savas.Library.concrete;
using Savas.Library.Enum;

namespace Savas.Desktop
{
    public partial class AnaForm : Form
    {
        private readonly Oyun _oyun=new Oyun();
        public AnaForm()
        {
            InitializeComponent();
            _oyun.GecenSureDegisti += Oyun_GecenSureDegisti;
        }

        private void AnaForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    _oyun.baslat();
                    break;
                case Keys.Right:
                    _oyun.ucaksavarihareketettir(Yon.saga);
                    break;
                case Keys.Left:
                    _oyun.ucaksavarihareketettir(Yon.sola);

                    break;
                case Keys.Space:
                    _oyun.ateset();
                    break;
            }



        }
        private void Oyun_GecenSureDegisti(object sender, EventArgs e)
        {
            surelabel.Text = $"{_oyun.Gecensure.Minutes}:{_oyun.Gecensure.Seconds.ToString("D2")}";
        }
    }
}
