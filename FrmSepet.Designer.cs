using System.Drawing;
using System.Windows.Forms;

namespace OnlineRestoranSiparisTakipSistemi
{
    partial class FrmSepet
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
            this.cartPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnConfirmOrder = new System.Windows.Forms.Button();
            this.lblAd = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.Urunler = new System.Windows.Forms.ListBox();
            this.cartPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cartPanel
            // 
            this.cartPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.cartPanel.Controls.Add(this.Urunler);
            this.cartPanel.Controls.Add(this.button1);
            this.cartPanel.Location = new System.Drawing.Point(259, 12);
            this.cartPanel.Name = "cartPanel";
            this.cartPanel.Size = new System.Drawing.Size(503, 300);
            this.cartPanel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(20, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(316, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Seçili Ürünü Sepetden Kaldır";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnConfirmOrder
            // 
            this.btnConfirmOrder.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnConfirmOrder.Location = new System.Drawing.Point(279, 339);
            this.btnConfirmOrder.Name = "btnConfirmOrder";
            this.btnConfirmOrder.Size = new System.Drawing.Size(200, 41);
            this.btnConfirmOrder.TabIndex = 2;
            this.btnConfirmOrder.Text = "Siparişi Onayla";
            this.btnConfirmOrder.Click += new System.EventHandler(this.btnConfirmOrder_Click);
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(28, 12);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(0, 16);
            this.lblAd.TabIndex = 3;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMenu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnMenu.Location = new System.Drawing.Point(562, 339);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(200, 41);
            this.btnMenu.TabIndex = 4;
            this.btnMenu.Text = "Menüye Geri Dön";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // Urunler
            // 
            this.Urunler.FormattingEnabled = true;
            this.Urunler.ItemHeight = 16;
            this.Urunler.Location = new System.Drawing.Point(20, 31);
            this.Urunler.Name = "Urunler";
            this.Urunler.Size = new System.Drawing.Size(451, 132);
            this.Urunler.TabIndex = 4;
            // 
            // FrmSepet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(175)))), ((int)(((byte)(172)))));
            this.ClientSize = new System.Drawing.Size(912, 435);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.cartPanel);
            this.Controls.Add(this.btnConfirmOrder);
            this.MaximizeBox = false;
            this.Name = "FrmSepet";
            this.Text = "Sepet";
            this.Load += new System.EventHandler(this.FrmSepet_Load);
            this.cartPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel cartPanel;
        private Button btnConfirmOrder;
        private Button button1;
        private Label lblAd;
        private Button btnMenu;
        private ListBox Urunler;
    }
}