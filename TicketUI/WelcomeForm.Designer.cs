namespace TicketUI
{
    partial class WelcomeForm
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
            this.grpBoxBig = new System.Windows.Forms.GroupBox();
            this.grpBoxUserDetails = new System.Windows.Forms.GroupBox();
            this.btnSatin = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.grpBoxEkKoltuk = new System.Windows.Forms.GroupBox();
            this.pnlEkKoltuk = new System.Windows.Forms.Panel();
            this.btnKoltukEkle = new System.Windows.Forms.Button();
            this.txtBoxKoltukNo = new System.Windows.Forms.TextBox();
            this.txtBoxMail = new System.Windows.Forms.TextBox();
            this.txtBoxCepNo = new System.Windows.Forms.TextBox();
            this.txtBoxKullAd = new System.Windows.Forms.TextBox();
            this.lblSelectedSeat = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblCepTel = new System.Windows.Forms.Label();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.pnlSeats = new System.Windows.Forms.Panel();
            this.fwCurtain = new System.Windows.Forms.FlowLayoutPanel();
            this.grpBoxBig.SuspendLayout();
            this.grpBoxUserDetails.SuspendLayout();
            this.grpBoxEkKoltuk.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxBig
            // 
            this.grpBoxBig.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpBoxBig.Controls.Add(this.grpBoxUserDetails);
            this.grpBoxBig.Controls.Add(this.pnlSeats);
            this.grpBoxBig.Controls.Add(this.fwCurtain);
            this.grpBoxBig.Location = new System.Drawing.Point(12, 12);
            this.grpBoxBig.Name = "grpBoxBig";
            this.grpBoxBig.Size = new System.Drawing.Size(795, 408);
            this.grpBoxBig.TabIndex = 0;
            this.grpBoxBig.TabStop = false;
            // 
            // grpBoxUserDetails
            // 
            this.grpBoxUserDetails.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.grpBoxUserDetails.Controls.Add(this.btnSatin);
            this.grpBoxUserDetails.Controls.Add(this.btnIptal);
            this.grpBoxUserDetails.Controls.Add(this.grpBoxEkKoltuk);
            this.grpBoxUserDetails.Controls.Add(this.btnKoltukEkle);
            this.grpBoxUserDetails.Controls.Add(this.txtBoxKoltukNo);
            this.grpBoxUserDetails.Controls.Add(this.txtBoxMail);
            this.grpBoxUserDetails.Controls.Add(this.txtBoxCepNo);
            this.grpBoxUserDetails.Controls.Add(this.txtBoxKullAd);
            this.grpBoxUserDetails.Controls.Add(this.lblSelectedSeat);
            this.grpBoxUserDetails.Controls.Add(this.lblMail);
            this.grpBoxUserDetails.Controls.Add(this.lblCepTel);
            this.grpBoxUserDetails.Controls.Add(this.lblKullaniciAdi);
            this.grpBoxUserDetails.Location = new System.Drawing.Point(443, 19);
            this.grpBoxUserDetails.Name = "grpBoxUserDetails";
            this.grpBoxUserDetails.Size = new System.Drawing.Size(346, 373);
            this.grpBoxUserDetails.TabIndex = 4;
            this.grpBoxUserDetails.TabStop = false;
            this.grpBoxUserDetails.Text = "User Information";
            // 
            // btnSatin
            // 
            this.btnSatin.Location = new System.Drawing.Point(246, 335);
            this.btnSatin.Name = "btnSatin";
            this.btnSatin.Size = new System.Drawing.Size(75, 23);
            this.btnSatin.TabIndex = 11;
            this.btnSatin.Text = "Book";
            this.btnSatin.UseVisualStyleBackColor = true;
            this.btnSatin.Click += new System.EventHandler(this.btnSatin_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(34, 336);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(75, 23);
            this.btnIptal.TabIndex = 10;
            this.btnIptal.Text = "Cancel";
            this.btnIptal.UseVisualStyleBackColor = true;
            // 
            // grpBoxEkKoltuk
            // 
            this.grpBoxEkKoltuk.Controls.Add(this.pnlEkKoltuk);
            this.grpBoxEkKoltuk.Cursor = System.Windows.Forms.Cursors.Default;
            this.grpBoxEkKoltuk.Location = new System.Drawing.Point(34, 125);
            this.grpBoxEkKoltuk.Name = "grpBoxEkKoltuk";
            this.grpBoxEkKoltuk.Size = new System.Drawing.Size(287, 204);
            this.grpBoxEkKoltuk.TabIndex = 9;
            this.grpBoxEkKoltuk.TabStop = false;
            // 
            // pnlEkKoltuk
            // 
            this.pnlEkKoltuk.AutoScroll = true;
            this.pnlEkKoltuk.Location = new System.Drawing.Point(6, 10);
            this.pnlEkKoltuk.Name = "pnlEkKoltuk";
            this.pnlEkKoltuk.Size = new System.Drawing.Size(275, 188);
            this.pnlEkKoltuk.TabIndex = 0;
            // 
            // btnKoltukEkle
            // 
            this.btnKoltukEkle.Location = new System.Drawing.Point(172, 96);
            this.btnKoltukEkle.Name = "btnKoltukEkle";
            this.btnKoltukEkle.Size = new System.Drawing.Size(31, 23);
            this.btnKoltukEkle.TabIndex = 8;
            this.btnKoltukEkle.Text = "+";
            this.btnKoltukEkle.UseVisualStyleBackColor = true;
            this.btnKoltukEkle.Click += new System.EventHandler(this.btnKoltukEkle_Click);
            // 
            // txtBoxKoltukNo
            // 
            this.txtBoxKoltukNo.Location = new System.Drawing.Point(116, 96);
            this.txtBoxKoltukNo.Name = "txtBoxKoltukNo";
            this.txtBoxKoltukNo.Size = new System.Drawing.Size(50, 20);
            this.txtBoxKoltukNo.TabIndex = 7;
            // 
            // txtBoxMail
            // 
            this.txtBoxMail.Location = new System.Drawing.Point(116, 69);
            this.txtBoxMail.Name = "txtBoxMail";
            this.txtBoxMail.Size = new System.Drawing.Size(161, 20);
            this.txtBoxMail.TabIndex = 6;
            // 
            // txtBoxCepNo
            // 
            this.txtBoxCepNo.Location = new System.Drawing.Point(116, 44);
            this.txtBoxCepNo.Name = "txtBoxCepNo";
            this.txtBoxCepNo.Size = new System.Drawing.Size(161, 20);
            this.txtBoxCepNo.TabIndex = 5;
            // 
            // txtBoxKullAd
            // 
            this.txtBoxKullAd.Location = new System.Drawing.Point(116, 19);
            this.txtBoxKullAd.Name = "txtBoxKullAd";
            this.txtBoxKullAd.Size = new System.Drawing.Size(224, 20);
            this.txtBoxKullAd.TabIndex = 4;
            // 
            // lblSelectedSeat
            // 
            this.lblSelectedSeat.AutoSize = true;
            this.lblSelectedSeat.Location = new System.Drawing.Point(28, 101);
            this.lblSelectedSeat.Name = "lblSelectedSeat";
            this.lblSelectedSeat.Size = new System.Drawing.Size(77, 13);
            this.lblSelectedSeat.TabIndex = 3;
            this.lblSelectedSeat.Text = "Selected Seat:";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(66, 72);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(39, 13);
            this.lblMail.TabIndex = 2;
            this.lblMail.Text = "E-Mail:";
            // 
            // lblCepTel
            // 
            this.lblCepTel.AutoSize = true;
            this.lblCepTel.Location = new System.Drawing.Point(64, 47);
            this.lblCepTel.Name = "lblCepTel";
            this.lblCepTel.Size = new System.Drawing.Size(41, 13);
            this.lblCepTel.TabIndex = 1;
            this.lblCepTel.Text = "Mobile:";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(42, 27);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(63, 13);
            this.lblKullaniciAdi.TabIndex = 0;
            this.lblKullaniciAdi.Text = "User Name:";
            // 
            // pnlSeats
            // 
            this.pnlSeats.Location = new System.Drawing.Point(15, 116);
            this.pnlSeats.Name = "pnlSeats";
            this.pnlSeats.Size = new System.Drawing.Size(422, 286);
            this.pnlSeats.TabIndex = 3;
            // 
            // fwCurtain
            // 
            this.fwCurtain.Location = new System.Drawing.Point(15, 19);
            this.fwCurtain.Name = "fwCurtain";
            this.fwCurtain.Size = new System.Drawing.Size(422, 77);
            this.fwCurtain.TabIndex = 2;
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 432);
            this.Controls.Add(this.grpBoxBig);
            this.Name = "WelcomeForm";
            this.Text = "WelcomeForm";
            this.Load += new System.EventHandler(this.WelcomeForm_Load);
            this.grpBoxBig.ResumeLayout(false);
            this.grpBoxUserDetails.ResumeLayout(false);
            this.grpBoxUserDetails.PerformLayout();
            this.grpBoxEkKoltuk.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxBig;
        private System.Windows.Forms.FlowLayoutPanel fwCurtain;
        private System.Windows.Forms.Panel pnlSeats;
        private System.Windows.Forms.GroupBox grpBoxUserDetails;
        private System.Windows.Forms.Label lblSelectedSeat;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblCepTel;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.TextBox txtBoxCepNo;
        private System.Windows.Forms.TextBox txtBoxKullAd;
        private System.Windows.Forms.TextBox txtBoxMail;
        private System.Windows.Forms.Button btnKoltukEkle;
        private System.Windows.Forms.TextBox txtBoxKoltukNo;
        private System.Windows.Forms.GroupBox grpBoxEkKoltuk;
        private System.Windows.Forms.Button btnSatin;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Panel pnlEkKoltuk;
    }
}