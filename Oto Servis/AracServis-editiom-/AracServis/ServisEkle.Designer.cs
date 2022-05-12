namespace AracServis
{
    partial class ServisEkle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServisEkle));
            this.label7 = new System.Windows.Forms.Label();
            this.BtnLi = new System.Windows.Forms.Button();
            this.BtnKa = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TxtYapilanI = new System.Windows.Forms.GroupBox();
            this.TxtYedekPK = new System.Windows.Forms.TextBox();
            this.TxtMusteriK = new System.Windows.Forms.TextBox();
            this.TxtServisN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtarackodu = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtİscilikU = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtYapilan = new System.Windows.Forms.TextBox();
            this.TxtAracD = new System.Windows.Forms.Label();
            this.TxtCikisT = new System.Windows.Forms.TextBox();
            this.TxtGirisT = new System.Windows.Forms.TextBox();
            this.TxtAracK = new System.Windows.Forms.TextBox();
            this.TxtToplamT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Btnsus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.TxtYapilanI.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Banner", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(153, -10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 30);
            this.label7.TabIndex = 0;
            this.label7.Text = "Servis Ekle";
            // 
            // BtnLi
            // 
            this.BtnLi.BackColor = System.Drawing.Color.Bisque;
            this.BtnLi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnLi.Location = new System.Drawing.Point(87, 593);
            this.BtnLi.Name = "BtnLi";
            this.BtnLi.Size = new System.Drawing.Size(106, 31);
            this.BtnLi.TabIndex = 11;
            this.BtnLi.Text = "Listele";
            this.BtnLi.UseVisualStyleBackColor = false;
            this.BtnLi.Click += new System.EventHandler(this.BtnLi_Click);
            // 
            // BtnKa
            // 
            this.BtnKa.BackColor = System.Drawing.Color.Bisque;
            this.BtnKa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKa.Location = new System.Drawing.Point(256, 593);
            this.BtnKa.Name = "BtnKa";
            this.BtnKa.Size = new System.Drawing.Size(106, 31);
            this.BtnKa.TabIndex = 10;
            this.BtnKa.Text = "Kaydet";
            this.BtnKa.UseVisualStyleBackColor = false;
            this.BtnKa.Click += new System.EventHandler(this.BtnKa_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(1112, 647);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // TxtYapilanI
            // 
            this.TxtYapilanI.Controls.Add(this.dataGridView1);
            this.TxtYapilanI.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtYapilanI.Location = new System.Drawing.Point(445, 11);
            this.TxtYapilanI.Name = "TxtYapilanI";
            this.TxtYapilanI.Size = new System.Drawing.Size(1118, 666);
            this.TxtYapilanI.TabIndex = 28;
            this.TxtYapilanI.TabStop = false;
            this.TxtYapilanI.Text = "Servistekiler";
            // 
            // TxtYedekPK
            // 
            this.TxtYedekPK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtYedekPK.Location = new System.Drawing.Point(206, 198);
            this.TxtYedekPK.Name = "TxtYedekPK";
            this.TxtYedekPK.Size = new System.Drawing.Size(156, 26);
            this.TxtYedekPK.TabIndex = 2;
            // 
            // TxtMusteriK
            // 
            this.TxtMusteriK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMusteriK.Location = new System.Drawing.Point(206, 144);
            this.TxtMusteriK.Name = "TxtMusteriK";
            this.TxtMusteriK.Size = new System.Drawing.Size(156, 26);
            this.TxtMusteriK.TabIndex = 1;
            // 
            // TxtServisN
            // 
            this.TxtServisN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtServisN.Location = new System.Drawing.Point(206, 98);
            this.TxtServisN.Name = "TxtServisN";
            this.TxtServisN.Size = new System.Drawing.Size(156, 26);
            this.TxtServisN.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Banner", 16F);
            this.label6.Location = new System.Drawing.Point(74, 431);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 32);
            this.label6.TabIndex = 21;
            this.label6.Text = "Çıkış Tarihi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Banner", 16F);
            this.label5.Location = new System.Drawing.Point(74, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 32);
            this.label5.TabIndex = 20;
            this.label5.Text = "Giriş Tarihi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Banner", 16F);
            this.label4.Location = new System.Drawing.Point(55, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 32);
            this.label4.TabIndex = 19;
            this.label4.Text = "Araç Durumu :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 16F);
            this.label3.Location = new System.Drawing.Point(23, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 32);
            this.label3.TabIndex = 18;
            this.label3.Text = "Yedek Parça Kodu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 16F);
            this.label2.Location = new System.Drawing.Point(52, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 32);
            this.label2.TabIndex = 17;
            this.label2.Text = "Müşteri Kodu :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 16F);
            this.label1.Location = new System.Drawing.Point(31, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "Servis Numarası :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtarackodu);
            this.groupBox2.Controls.Add(this.TxtYedekPK);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.TxtMusteriK);
            this.groupBox2.Controls.Add(this.TxtİscilikU);
            this.groupBox2.Controls.Add(this.TxtServisN);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.TxtYapilan);
            this.groupBox2.Controls.Add(this.TxtAracD);
            this.groupBox2.Controls.Add(this.TxtCikisT);
            this.groupBox2.Controls.Add(this.TxtGirisT);
            this.groupBox2.Controls.Add(this.TxtAracK);
            this.groupBox2.Controls.Add(this.BtnLi);
            this.groupBox2.Controls.Add(this.BtnKa);
            this.groupBox2.Controls.Add(this.TxtToplamT);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Btnsus);
            this.groupBox2.Location = new System.Drawing.Point(12, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(421, 651);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtarackodu
            // 
            this.txtarackodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtarackodu.Location = new System.Drawing.Point(206, 246);
            this.txtarackodu.Name = "txtarackodu";
            this.txtarackodu.Size = new System.Drawing.Size(156, 26);
            this.txtarackodu.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sitka Banner", 16F);
            this.label10.Location = new System.Drawing.Point(76, 240);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 32);
            this.label10.TabIndex = 40;
            this.label10.Text = "Araç Kodu : ";
            // 
            // TxtİscilikU
            // 
            this.TxtİscilikU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtİscilikU.Location = new System.Drawing.Point(206, 487);
            this.TxtİscilikU.Name = "TxtİscilikU";
            this.TxtİscilikU.Size = new System.Drawing.Size(156, 26);
            this.TxtİscilikU.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Banner", 16F);
            this.label9.Location = new System.Drawing.Point(66, 481);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 32);
            this.label9.TabIndex = 38;
            this.label9.Text = "İşcilik Ücreti :";
            // 
            // TxtYapilan
            // 
            this.TxtYapilan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtYapilan.Location = new System.Drawing.Point(206, 336);
            this.TxtYapilan.Name = "TxtYapilan";
            this.TxtYapilan.Size = new System.Drawing.Size(156, 26);
            this.TxtYapilan.TabIndex = 5;
            // 
            // TxtAracD
            // 
            this.TxtAracD.AutoSize = true;
            this.TxtAracD.Font = new System.Drawing.Font("Sitka Banner", 16F);
            this.TxtAracD.Location = new System.Drawing.Point(57, 330);
            this.TxtAracD.Name = "TxtAracD";
            this.TxtAracD.Size = new System.Drawing.Size(136, 32);
            this.TxtAracD.TabIndex = 36;
            this.TxtAracD.Text = "Yapılan İşlem :";
            // 
            // TxtCikisT
            // 
            this.TxtCikisT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtCikisT.Location = new System.Drawing.Point(206, 437);
            this.TxtCikisT.Name = "TxtCikisT";
            this.TxtCikisT.Size = new System.Drawing.Size(156, 26);
            this.TxtCikisT.TabIndex = 7;
            // 
            // TxtGirisT
            // 
            this.TxtGirisT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtGirisT.Location = new System.Drawing.Point(206, 385);
            this.TxtGirisT.Name = "TxtGirisT";
            this.TxtGirisT.Size = new System.Drawing.Size(156, 26);
            this.TxtGirisT.TabIndex = 6;
            // 
            // TxtAracK
            // 
            this.TxtAracK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAracK.Location = new System.Drawing.Point(206, 293);
            this.TxtAracK.Name = "TxtAracK";
            this.TxtAracK.Size = new System.Drawing.Size(156, 26);
            this.TxtAracK.TabIndex = 4;
            // 
            // TxtToplamT
            // 
            this.TxtToplamT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtToplamT.Location = new System.Drawing.Point(206, 533);
            this.TxtToplamT.Name = "TxtToplamT";
            this.TxtToplamT.Size = new System.Drawing.Size(156, 26);
            this.TxtToplamT.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Banner", 16F);
            this.label8.Location = new System.Drawing.Point(54, 527);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 32);
            this.label8.TabIndex = 22;
            this.label8.Text = "Toplam Tutar :";
            // 
            // Btnsus
            // 
            this.Btnsus.AccessibleRole = System.Windows.Forms.AccessibleRole.Caret;
            this.Btnsus.BackColor = System.Drawing.Color.PapayaWhip;
            this.Btnsus.Enabled = false;
            this.Btnsus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btnsus.Location = new System.Drawing.Point(145, -9);
            this.Btnsus.Name = "Btnsus";
            this.Btnsus.Size = new System.Drawing.Size(125, 36);
            this.Btnsus.TabIndex = 34;
            this.Btnsus.UseVisualStyleBackColor = false;
            // 
            // ServisEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1577, 678);
            this.Controls.Add(this.TxtYapilanI);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ServisEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servis Ekle";
            this.Load += new System.EventHandler(this.ServisEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.TxtYapilanI.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnLi;
        private System.Windows.Forms.Button BtnKa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox TxtYapilanI;
        private System.Windows.Forms.TextBox TxtYedekPK;
        private System.Windows.Forms.TextBox TxtMusteriK;
        private System.Windows.Forms.TextBox TxtServisN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtToplamT;
        private System.Windows.Forms.Button Btnsus;
        private System.Windows.Forms.TextBox TxtYapilan;
        private System.Windows.Forms.Label TxtAracD;
        private System.Windows.Forms.TextBox TxtCikisT;
        private System.Windows.Forms.TextBox TxtGirisT;
        private System.Windows.Forms.TextBox TxtAracK;
        private System.Windows.Forms.TextBox TxtİscilikU;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtarackodu;
        private System.Windows.Forms.Label label10;
    }
}