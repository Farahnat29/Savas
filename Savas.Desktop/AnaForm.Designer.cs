
namespace Savas.Desktop
{
    partial class AnaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.bilgipanel = new System.Windows.Forms.Panel();
            this.surelabel = new System.Windows.Forms.Label();
            this.bilgilabel = new System.Windows.Forms.Label();
            this.ucaksavarpanel = new System.Windows.Forms.Panel();
            this.savasAlanipanel = new System.Windows.Forms.Panel();
            this.bilgipanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bilgipanel
            // 
            this.bilgipanel.BackColor = System.Drawing.Color.SteelBlue;
            this.bilgipanel.Controls.Add(this.surelabel);
            this.bilgipanel.Controls.Add(this.bilgilabel);
            this.bilgipanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.bilgipanel.Location = new System.Drawing.Point(0, 0);
            this.bilgipanel.Name = "bilgipanel";
            this.bilgipanel.Size = new System.Drawing.Size(1213, 147);
            this.bilgipanel.TabIndex = 0;
            // 
            // surelabel
            // 
            this.surelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.surelabel.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surelabel.ForeColor = System.Drawing.SystemColors.Control;
            this.surelabel.Location = new System.Drawing.Point(919, 34);
            this.surelabel.Name = "surelabel";
            this.surelabel.Size = new System.Drawing.Size(291, 82);
            this.surelabel.TabIndex = 0;
            this.surelabel.Text = "0:00";
            this.surelabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bilgilabel
            // 
            this.bilgilabel.AutoSize = true;
            this.bilgilabel.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bilgilabel.ForeColor = System.Drawing.SystemColors.Control;
            this.bilgilabel.Location = new System.Drawing.Point(12, 34);
            this.bilgilabel.Name = "bilgilabel";
            this.bilgilabel.Size = new System.Drawing.Size(738, 120);
            this.bilgilabel.TabIndex = 0;
            this.bilgilabel.Text = "Oyunu başlamak için ENTER tuşuna basınç.\r\nUçaksavarı hareket ettirmek için SAĞ/SO" +
    "L yön tuşlarına basın.\r\nAteş etmek için BOŞLUK tuşuna basın.\r\n\r\n";
            // 
            // ucaksavarpanel
            // 
            this.ucaksavarpanel.BackColor = System.Drawing.Color.Teal;
            this.ucaksavarpanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucaksavarpanel.Location = new System.Drawing.Point(0, 516);
            this.ucaksavarpanel.Name = "ucaksavarpanel";
            this.ucaksavarpanel.Size = new System.Drawing.Size(1213, 79);
            this.ucaksavarpanel.TabIndex = 0;
            // 
            // savasAlanipanel
            // 
            this.savasAlanipanel.BackColor = System.Drawing.Color.PeachPuff;
            this.savasAlanipanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.savasAlanipanel.Location = new System.Drawing.Point(0, 147);
            this.savasAlanipanel.Name = "savasAlanipanel";
            this.savasAlanipanel.Size = new System.Drawing.Size(1213, 369);
            this.savasAlanipanel.TabIndex = 1;
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 595);
            this.Controls.Add(this.savasAlanipanel);
            this.Controls.Add(this.ucaksavarpanel);
            this.Controls.Add(this.bilgipanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnaForm";
            this.Text = "SavaşOyunu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AnaForm_KeyDown);
            this.bilgipanel.ResumeLayout(false);
            this.bilgipanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bilgipanel;
        private System.Windows.Forms.Label surelabel;
        private System.Windows.Forms.Label bilgilabel;
        private System.Windows.Forms.Panel ucaksavarpanel;
        private System.Windows.Forms.Panel savasAlanipanel;
    }
}

