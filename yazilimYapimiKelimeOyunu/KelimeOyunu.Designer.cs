namespace yazilimYapimiKelimeOyunu
{
    partial class KelimeOyunu
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
            this.radioRandom = new System.Windows.Forms.RadioButton();
            this.radioManual = new System.Windows.Forms.RadioButton();
            this.lblOyun = new System.Windows.Forms.Label();
            this.lblBildirim = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtJokerHarf = new System.Windows.Forms.TextBox();
            this.lblKural = new System.Windows.Forms.Label();
            this.lblKural15 = new System.Windows.Forms.Label();
            this.lblKural14 = new System.Windows.Forms.Label();
            this.lblBilgi = new System.Windows.Forms.Label();
            this.lblKural11 = new System.Windows.Forms.Label();
            this.lblKural12 = new System.Windows.Forms.Label();
            this.lblKural13 = new System.Windows.Forms.Label();
            this.lblKural10 = new System.Windows.Forms.Label();
            this.lblKural1 = new System.Windows.Forms.Label();
            this.lblKural2 = new System.Windows.Forms.Label();
            this.lblKural3 = new System.Windows.Forms.Label();
            this.lblKural4 = new System.Windows.Forms.Label();
            this.lblKural5 = new System.Windows.Forms.Label();
            this.lblKural6 = new System.Windows.Forms.Label();
            this.lblKural7 = new System.Windows.Forms.Label();
            this.lblKural8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalPoint = new System.Windows.Forms.Label();
            this.lblPuan = new System.Windows.Forms.Label();
            this.btnKelimeyiBul = new System.Windows.Forms.Button();
            this.btnYenile = new System.Windows.Forms.Button();
            this.lblKelimeMesaj = new System.Windows.Forms.Label();
            this.lblEnUzunKelime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblJokerHarf = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioRandom
            // 
            this.radioRandom.AutoSize = true;
            this.radioRandom.Location = new System.Drawing.Point(12, 87);
            this.radioRandom.Name = "radioRandom";
            this.radioRandom.Size = new System.Drawing.Size(126, 17);
            this.radioRandom.TabIndex = 0;
            this.radioRandom.Text = "Harfler rastgele gelsin";
            this.radioRandom.UseVisualStyleBackColor = true;
            // 
            // radioManual
            // 
            this.radioManual.AutoSize = true;
            this.radioManual.Location = new System.Drawing.Point(12, 110);
            this.radioManual.Name = "radioManual";
            this.radioManual.Size = new System.Drawing.Size(172, 17);
            this.radioManual.TabIndex = 1;
            this.radioManual.Text = "Harfleri kendim girmek istiyorum";
            this.radioManual.UseVisualStyleBackColor = true;
            // 
            // lblOyun
            // 
            this.lblOyun.AutoSize = true;
            this.lblOyun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblOyun.Font = new System.Drawing.Font("Times New Roman", 16.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOyun.ForeColor = System.Drawing.Color.Black;
            this.lblOyun.Location = new System.Drawing.Point(269, 9);
            this.lblOyun.Name = "lblOyun";
            this.lblOyun.Size = new System.Drawing.Size(235, 25);
            this.lblOyun.TabIndex = 3;
            this.lblOyun.Text = "BİR KELİME OYUNU";
            // 
            // lblBildirim
            // 
            this.lblBildirim.AutoSize = true;
            this.lblBildirim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblBildirim.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBildirim.Location = new System.Drawing.Point(41, 195);
            this.lblBildirim.Name = "lblBildirim";
            this.lblBildirim.Size = new System.Drawing.Size(56, 18);
            this.lblBildirim.TabIndex = 13;
            this.lblBildirim.Text = "Harfler:";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStart.Location = new System.Drawing.Point(339, 193);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(116, 23);
            this.btnStart.TabIndex = 14;
            this.btnStart.Text = "Oyunu Başlat";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtJokerHarf
            // 
            this.txtJokerHarf.Location = new System.Drawing.Point(313, 195);
            this.txtJokerHarf.Name = "txtJokerHarf";
            this.txtJokerHarf.ReadOnly = true;
            this.txtJokerHarf.Size = new System.Drawing.Size(20, 20);
            this.txtJokerHarf.TabIndex = 12;
            this.txtJokerHarf.Text = "?";
            this.txtJokerHarf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblKural
            // 
            this.lblKural.AutoSize = true;
            this.lblKural.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblKural.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKural.Location = new System.Drawing.Point(21, 265);
            this.lblKural.MaximumSize = new System.Drawing.Size(450, 0);
            this.lblKural.Name = "lblKural";
            this.lblKural.Size = new System.Drawing.Size(418, 30);
            this.lblKural.TabIndex = 30;
            this.lblKural.Text = "~ Bu oyunun tek amacı oluşturulan harflerle en uzun kelimeyi bulmaktır, bunu prog" +
    "ramın kendisi yapacaktır";
            // 
            // lblKural15
            // 
            this.lblKural15.AutoSize = true;
            this.lblKural15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblKural15.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKural15.Location = new System.Drawing.Point(21, 295);
            this.lblKural15.MaximumSize = new System.Drawing.Size(200, 0);
            this.lblKural15.Name = "lblKural15";
            this.lblKural15.Size = new System.Drawing.Size(181, 30);
            this.lblKural15.TabIndex = 29;
            this.lblKural15.Text = "~ En uzun kelime bulunduğunda oyun sonlanır";
            // 
            // lblKural14
            // 
            this.lblKural14.AutoSize = true;
            this.lblKural14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblKural14.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKural14.Location = new System.Drawing.Point(21, 325);
            this.lblKural14.MaximumSize = new System.Drawing.Size(200, 0);
            this.lblKural14.Name = "lblKural14";
            this.lblKural14.Size = new System.Drawing.Size(153, 15);
            this.lblKural14.TabIndex = 28;
            this.lblKural14.Text = "~ \"?\" joker harfi temsil eder.";
            // 
            // lblBilgi
            // 
            this.lblBilgi.AutoSize = true;
            this.lblBilgi.BackColor = System.Drawing.Color.MediumAquamarine;
            this.lblBilgi.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBilgi.Location = new System.Drawing.Point(9, 233);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Size = new System.Drawing.Size(198, 17);
            this.lblBilgi.TabIndex = 27;
            this.lblBilgi.Text = "Oyun Özellikleri ve Kuralları";
            // 
            // lblKural11
            // 
            this.lblKural11.AutoSize = true;
            this.lblKural11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblKural11.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKural11.Location = new System.Drawing.Point(21, 385);
            this.lblKural11.MaximumSize = new System.Drawing.Size(350, 0);
            this.lblKural11.Name = "lblKural11";
            this.lblKural11.Size = new System.Drawing.Size(327, 30);
            this.lblKural11.TabIndex = 33;
            this.lblKural11.Text = "~ Harfleri girdikten sonra \"En Uzun Kelimeyi Bul\" butonuna tıklayın.";
            // 
            // lblKural12
            // 
            this.lblKural12.AutoSize = true;
            this.lblKural12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblKural12.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKural12.Location = new System.Drawing.Point(21, 370);
            this.lblKural12.MaximumSize = new System.Drawing.Size(350, 0);
            this.lblKural12.Name = "lblKural12";
            this.lblKural12.Size = new System.Drawing.Size(255, 15);
            this.lblKural12.TabIndex = 32;
            this.lblKural12.Text = "~ Eğer isterseniz harfleri siz elle de girebilirsiniz";
            // 
            // lblKural13
            // 
            this.lblKural13.AutoSize = true;
            this.lblKural13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblKural13.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKural13.Location = new System.Drawing.Point(21, 340);
            this.lblKural13.MaximumSize = new System.Drawing.Size(350, 0);
            this.lblKural13.Name = "lblKural13";
            this.lblKural13.Size = new System.Drawing.Size(331, 30);
            this.lblKural13.TabIndex = 31;
            this.lblKural13.Text = "~ Rastgele oluşturulan harfleri beğenmediyseniz eğer harfleri yenileyebilirsiniz";
            // 
            // lblKural10
            // 
            this.lblKural10.AutoSize = true;
            this.lblKural10.BackColor = System.Drawing.Color.Silver;
            this.lblKural10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKural10.Location = new System.Drawing.Point(21, 415);
            this.lblKural10.MaximumSize = new System.Drawing.Size(350, 0);
            this.lblKural10.Name = "lblKural10";
            this.lblKural10.Size = new System.Drawing.Size(316, 30);
            this.lblKural10.TabIndex = 34;
            this.lblKural10.Text = "~ Oyuna başlamak için seçeneklerden birini seçip \"Oyunu Başlat\" butonuna basın";
            // 
            // lblKural1
            // 
            this.lblKural1.AutoSize = true;
            this.lblKural1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblKural1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKural1.Location = new System.Drawing.Point(530, 423);
            this.lblKural1.Name = "lblKural1";
            this.lblKural1.Size = new System.Drawing.Size(266, 15);
            this.lblKural1.TabIndex = 42;
            this.lblKural1.Text = "~Kelime uzunluğu 9 harf ise 15 puan kazanırsınız.";
            // 
            // lblKural2
            // 
            this.lblKural2.AutoSize = true;
            this.lblKural2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblKural2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKural2.Location = new System.Drawing.Point(530, 408);
            this.lblKural2.Name = "lblKural2";
            this.lblKural2.Size = new System.Drawing.Size(266, 15);
            this.lblKural2.TabIndex = 41;
            this.lblKural2.Text = "~Kelime uzunluğu 8 harf ise 11 puan kazanırsınız.";
            // 
            // lblKural3
            // 
            this.lblKural3.AutoSize = true;
            this.lblKural3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblKural3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKural3.Location = new System.Drawing.Point(530, 393);
            this.lblKural3.Name = "lblKural3";
            this.lblKural3.Size = new System.Drawing.Size(260, 15);
            this.lblKural3.TabIndex = 40;
            this.lblKural3.Text = "~Kelime uzunluğu 7 harf ise 9 puan kazanırsınız.";
            // 
            // lblKural4
            // 
            this.lblKural4.AutoSize = true;
            this.lblKural4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblKural4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKural4.Location = new System.Drawing.Point(530, 378);
            this.lblKural4.Name = "lblKural4";
            this.lblKural4.Size = new System.Drawing.Size(260, 15);
            this.lblKural4.TabIndex = 39;
            this.lblKural4.Text = "~Kelime uzunluğu 6 harf ise 7 puan kazanırsınız.";
            // 
            // lblKural5
            // 
            this.lblKural5.AutoSize = true;
            this.lblKural5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblKural5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKural5.Location = new System.Drawing.Point(530, 363);
            this.lblKural5.Name = "lblKural5";
            this.lblKural5.Size = new System.Drawing.Size(260, 15);
            this.lblKural5.TabIndex = 38;
            this.lblKural5.Text = "~Kelime uzunluğu 5 harf ise 5 puan kazanırsınız.";
            // 
            // lblKural6
            // 
            this.lblKural6.AutoSize = true;
            this.lblKural6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblKural6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKural6.Location = new System.Drawing.Point(530, 348);
            this.lblKural6.Name = "lblKural6";
            this.lblKural6.Size = new System.Drawing.Size(260, 15);
            this.lblKural6.TabIndex = 37;
            this.lblKural6.Text = "~Kelime uzunluğu 4 harf ise 4 puan kazanırsınız.";
            // 
            // lblKural7
            // 
            this.lblKural7.AutoSize = true;
            this.lblKural7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblKural7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKural7.Location = new System.Drawing.Point(530, 333);
            this.lblKural7.Name = "lblKural7";
            this.lblKural7.Size = new System.Drawing.Size(260, 15);
            this.lblKural7.TabIndex = 36;
            this.lblKural7.Text = "~Kelime uzunluğu 3 harf ise 3 puan kazanırsınız.";
            // 
            // lblKural8
            // 
            this.lblKural8.AutoSize = true;
            this.lblKural8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblKural8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKural8.Location = new System.Drawing.Point(487, 318);
            this.lblKural8.Name = "lblKural8";
            this.lblKural8.Size = new System.Drawing.Size(278, 15);
            this.lblKural8.TabIndex = 35;
            this.lblKural8.Text = "~Kelime uzunluğuna göre puan alırsınız.Buna göre;";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(600, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 43;
            this.label1.Text = "Puanlama";
            // 
            // lblTotalPoint
            // 
            this.lblTotalPoint.AutoSize = true;
            this.lblTotalPoint.BackColor = System.Drawing.Color.MediumAquamarine;
            this.lblTotalPoint.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalPoint.Location = new System.Drawing.Point(529, 61);
            this.lblTotalPoint.Name = "lblTotalPoint";
            this.lblTotalPoint.Size = new System.Drawing.Size(100, 19);
            this.lblTotalPoint.TabIndex = 44;
            this.lblTotalPoint.Text = "Toplam Puan:";
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblPuan.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPuan.Location = new System.Drawing.Point(635, 62);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(16, 18);
            this.lblPuan.TabIndex = 45;
            this.lblPuan.Text = "0";
            // 
            // btnKelimeyiBul
            // 
            this.btnKelimeyiBul.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKelimeyiBul.Location = new System.Drawing.Point(339, 222);
            this.btnKelimeyiBul.Name = "btnKelimeyiBul";
            this.btnKelimeyiBul.Size = new System.Drawing.Size(116, 23);
            this.btnKelimeyiBul.TabIndex = 46;
            this.btnKelimeyiBul.Text = "En Uzun Kelimeyi Bul";
            this.btnKelimeyiBul.UseVisualStyleBackColor = true;
            this.btnKelimeyiBul.Click += new System.EventHandler(this.btnKelimeyiBul_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.Location = new System.Drawing.Point(461, 193);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(95, 22);
            this.btnYenile.TabIndex = 47;
            this.btnYenile.Text = "Harfleri Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // lblKelimeMesaj
            // 
            this.lblKelimeMesaj.AutoSize = true;
            this.lblKelimeMesaj.BackColor = System.Drawing.Color.MediumAquamarine;
            this.lblKelimeMesaj.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKelimeMesaj.Location = new System.Drawing.Point(514, 85);
            this.lblKelimeMesaj.Name = "lblKelimeMesaj";
            this.lblKelimeMesaj.Size = new System.Drawing.Size(115, 19);
            this.lblKelimeMesaj.TabIndex = 48;
            this.lblKelimeMesaj.Text = "En uzun kelime:";
            // 
            // lblEnUzunKelime
            // 
            this.lblEnUzunKelime.AutoSize = true;
            this.lblEnUzunKelime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblEnUzunKelime.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEnUzunKelime.Location = new System.Drawing.Point(635, 85);
            this.lblEnUzunKelime.Name = "lblEnUzunKelime";
            this.lblEnUzunKelime.Size = new System.Drawing.Size(13, 18);
            this.lblEnUzunKelime.TabIndex = 49;
            this.lblEnUzunKelime.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(545, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 50;
            this.label2.Text = "Joker harf:";
            // 
            // lblJokerHarf
            // 
            this.lblJokerHarf.AutoSize = true;
            this.lblJokerHarf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblJokerHarf.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblJokerHarf.Location = new System.Drawing.Point(635, 111);
            this.lblJokerHarf.Name = "lblJokerHarf";
            this.lblJokerHarf.Size = new System.Drawing.Size(13, 18);
            this.lblJokerHarf.TabIndex = 51;
            this.lblJokerHarf.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(21, 250);
            this.label3.MaximumSize = new System.Drawing.Size(350, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 15);
            this.label3.TabIndex = 52;
            this.label3.Text = "~ Harfleri manuel girerken \"küçük harf\" girin lütfen";
            // 
            // KelimeOyunu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblJokerHarf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblEnUzunKelime);
            this.Controls.Add(this.lblKelimeMesaj);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.btnKelimeyiBul);
            this.Controls.Add(this.lblPuan);
            this.Controls.Add(this.lblTotalPoint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblKural1);
            this.Controls.Add(this.lblKural2);
            this.Controls.Add(this.lblKural3);
            this.Controls.Add(this.lblKural4);
            this.Controls.Add(this.lblKural5);
            this.Controls.Add(this.lblKural6);
            this.Controls.Add(this.lblKural7);
            this.Controls.Add(this.lblKural8);
            this.Controls.Add(this.lblKural10);
            this.Controls.Add(this.lblKural11);
            this.Controls.Add(this.lblKural12);
            this.Controls.Add(this.lblKural13);
            this.Controls.Add(this.lblKural);
            this.Controls.Add(this.lblKural15);
            this.Controls.Add(this.lblKural14);
            this.Controls.Add(this.lblBilgi);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblBildirim);
            this.Controls.Add(this.txtJokerHarf);
            this.Controls.Add(this.lblOyun);
            this.Controls.Add(this.radioManual);
            this.Controls.Add(this.radioRandom);
            this.Name = "KelimeOyunu";
            this.Text = "Kelime Oyunu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioRandom;
        private System.Windows.Forms.RadioButton radioManual;
        private System.Windows.Forms.Label lblOyun;
        private System.Windows.Forms.Label lblBildirim;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtJokerHarf;
        private System.Windows.Forms.Label lblKural;
        private System.Windows.Forms.Label lblKural15;
        private System.Windows.Forms.Label lblKural14;
        private System.Windows.Forms.Label lblBilgi;
        private System.Windows.Forms.Label lblKural11;
        private System.Windows.Forms.Label lblKural12;
        private System.Windows.Forms.Label lblKural13;
        private System.Windows.Forms.Label lblKural10;
        private System.Windows.Forms.Label lblKural1;
        private System.Windows.Forms.Label lblKural2;
        private System.Windows.Forms.Label lblKural3;
        private System.Windows.Forms.Label lblKural4;
        private System.Windows.Forms.Label lblKural5;
        private System.Windows.Forms.Label lblKural6;
        private System.Windows.Forms.Label lblKural7;
        private System.Windows.Forms.Label lblKural8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalPoint;
        private System.Windows.Forms.Label lblPuan;
        private System.Windows.Forms.Button btnKelimeyiBul;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Label lblKelimeMesaj;
        private System.Windows.Forms.Label lblEnUzunKelime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblJokerHarf;
        private System.Windows.Forms.Label label3;
    }
}

