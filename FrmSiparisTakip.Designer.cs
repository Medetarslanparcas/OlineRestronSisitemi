using System.Drawing;
using System.Windows.Forms;

namespace OnlineRestoranSiparisTakipSistemi
{
    partial class FrmSiparisTakip
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
            this.orderTrackingGroupBox = new System.Windows.Forms.GroupBox();
            this.lblOrderStatus = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblEstimatedDelivery = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblAd = new System.Windows.Forms.Label();
            this.orderTrackingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderTrackingGroupBox
            // 
            this.orderTrackingGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(225)))), ((int)(((byte)(213)))));
            this.orderTrackingGroupBox.Controls.Add(this.lblOrderStatus);
            this.orderTrackingGroupBox.Controls.Add(this.progressBar);
            this.orderTrackingGroupBox.Controls.Add(this.lblEstimatedDelivery);
            this.orderTrackingGroupBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.orderTrackingGroupBox.Location = new System.Drawing.Point(231, 119);
            this.orderTrackingGroupBox.Name = "orderTrackingGroupBox";
            this.orderTrackingGroupBox.Size = new System.Drawing.Size(500, 150);
            this.orderTrackingGroupBox.TabIndex = 2;
            this.orderTrackingGroupBox.TabStop = false;
            this.orderTrackingGroupBox.Text = "Sipariş Takibi";
            // 
            // lblOrderStatus
            // 
            this.lblOrderStatus.Font = new System.Drawing.Font("Arial", 10F);
            this.lblOrderStatus.Location = new System.Drawing.Point(20, 35);
            this.lblOrderStatus.Name = "lblOrderStatus";
            this.lblOrderStatus.Size = new System.Drawing.Size(329, 23);
            this.lblOrderStatus.TabIndex = 0;
            this.lblOrderStatus.Text = "Sipariş Durumu: Hazırlanıyor";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(20, 70);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(460, 20);
            this.progressBar.TabIndex = 1;
            // 
            // lblEstimatedDelivery
            // 
            this.lblEstimatedDelivery.Font = new System.Drawing.Font("Arial", 10F);
            this.lblEstimatedDelivery.Location = new System.Drawing.Point(20, 110);
            this.lblEstimatedDelivery.Name = "lblEstimatedDelivery";
            this.lblEstimatedDelivery.Size = new System.Drawing.Size(296, 23);
            this.lblEstimatedDelivery.TabIndex = 2;
            this.lblEstimatedDelivery.Text = "Tahmini Teslimat: 30 dakika";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(183)))), ((int)(((byte)(185)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(343, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Menüye Geri Dön";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(37, 61);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(0, 25);
            this.lblAd.TabIndex = 4;
            // 
            // FrmSiparisTakip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(175)))), ((int)(((byte)(172)))));
            this.ClientSize = new System.Drawing.Size(912, 387);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.orderTrackingGroupBox);
            this.MaximizeBox = false;
            this.Name = "FrmSiparisTakip";
            this.Text = "Sipariş Takip Sayfası";
            this.Load += new System.EventHandler(this.FrmSiparisTakip_Load);
            this.orderTrackingGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupBox orderTrackingGroupBox;
        private Label lblOrderStatus;
        private ProgressBar progressBar;
        private Label lblEstimatedDelivery;
        private Button button1;
        private Label lblAd;
    }
}