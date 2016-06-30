namespace Barber
{
    partial class Barbershop
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
            this.NewClient = new System.Windows.Forms.Button();
            this.finishCut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.work = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cout = new System.Windows.Forms.Label();
            this.chairCout1 = new System.Windows.Forms.Label();
            this.chairCout2 = new System.Windows.Forms.Label();
            this.chairCout3 = new System.Windows.Forms.Label();
            this.chairCout4 = new System.Windows.Forms.Label();
            this.chair1 = new System.Windows.Forms.PictureBox();
            this.chair2 = new System.Windows.Forms.PictureBox();
            this.chair3 = new System.Windows.Forms.PictureBox();
            this.chair4 = new System.Windows.Forms.PictureBox();
            this.chairBarber = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.hand = new System.Windows.Forms.GroupBox();
            this.auto = new System.Windows.Forms.GroupBox();
            this.stopAuto = new System.Windows.Forms.Button();
            this.startAuto = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.maxClientButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maxClientTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chair1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chair2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chair3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chair4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chairBarber)).BeginInit();
            this.hand.SuspendLayout();
            this.auto.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewClient
            // 
            this.NewClient.Location = new System.Drawing.Point(6, 22);
            this.NewClient.Name = "NewClient";
            this.NewClient.Size = new System.Drawing.Size(173, 23);
            this.NewClient.TabIndex = 0;
            this.NewClient.Text = "Новый посетитель";
            this.NewClient.UseVisualStyleBackColor = true;
            this.NewClient.Click += new System.EventHandler(this.NewClient_Click);
            // 
            // finishCut
            // 
            this.finishCut.Location = new System.Drawing.Point(6, 56);
            this.finishCut.Name = "finishCut";
            this.finishCut.Size = new System.Drawing.Size(173, 23);
            this.finishCut.TabIndex = 1;
            this.finishCut.Text = "Закончить стрижку";
            this.finishCut.UseVisualStyleBackColor = true;
            this.finishCut.Click += new System.EventHandler(this.finishCut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Состояние прикмахера";
            // 
            // work
            // 
            this.work.AutoSize = true;
            this.work.Location = new System.Drawing.Point(167, 216);
            this.work.Name = "work";
            this.work.Size = new System.Drawing.Size(31, 13);
            this.work.TabIndex = 3;
            this.work.Text = "Спит";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Колличество в очереди";
            // 
            // cout
            // 
            this.cout.AutoSize = true;
            this.cout.Location = new System.Drawing.Point(170, 247);
            this.cout.Name = "cout";
            this.cout.Size = new System.Drawing.Size(13, 13);
            this.cout.TabIndex = 5;
            this.cout.Text = "0";
            // 
            // chairCout1
            // 
            this.chairCout1.AutoSize = true;
            this.chairCout1.Location = new System.Drawing.Point(172, 124);
            this.chairCout1.Name = "chairCout1";
            this.chairCout1.Size = new System.Drawing.Size(13, 13);
            this.chairCout1.TabIndex = 6;
            this.chairCout1.Text = "0";
            // 
            // chairCout2
            // 
            this.chairCout2.AutoSize = true;
            this.chairCout2.Location = new System.Drawing.Point(272, 124);
            this.chairCout2.Name = "chairCout2";
            this.chairCout2.Size = new System.Drawing.Size(13, 13);
            this.chairCout2.TabIndex = 7;
            this.chairCout2.Text = "0";
            // 
            // chairCout3
            // 
            this.chairCout3.AutoSize = true;
            this.chairCout3.Location = new System.Drawing.Point(374, 124);
            this.chairCout3.Name = "chairCout3";
            this.chairCout3.Size = new System.Drawing.Size(13, 13);
            this.chairCout3.TabIndex = 8;
            this.chairCout3.Text = "0";
            // 
            // chairCout4
            // 
            this.chairCout4.AutoSize = true;
            this.chairCout4.Location = new System.Drawing.Point(471, 124);
            this.chairCout4.Name = "chairCout4";
            this.chairCout4.Size = new System.Drawing.Size(13, 13);
            this.chairCout4.TabIndex = 9;
            this.chairCout4.Text = "0";
            // 
            // chair1
            // 
            this.chair1.BackColor = System.Drawing.Color.Lime;
            this.chair1.Location = new System.Drawing.Point(148, 49);
            this.chair1.Name = "chair1";
            this.chair1.Size = new System.Drawing.Size(60, 60);
            this.chair1.TabIndex = 10;
            this.chair1.TabStop = false;
            // 
            // chair2
            // 
            this.chair2.BackColor = System.Drawing.Color.Lime;
            this.chair2.Location = new System.Drawing.Point(249, 49);
            this.chair2.Name = "chair2";
            this.chair2.Size = new System.Drawing.Size(60, 60);
            this.chair2.TabIndex = 11;
            this.chair2.TabStop = false;
            // 
            // chair3
            // 
            this.chair3.BackColor = System.Drawing.Color.Lime;
            this.chair3.Location = new System.Drawing.Point(351, 49);
            this.chair3.Name = "chair3";
            this.chair3.Size = new System.Drawing.Size(60, 60);
            this.chair3.TabIndex = 12;
            this.chair3.TabStop = false;
            // 
            // chair4
            // 
            this.chair4.BackColor = System.Drawing.Color.Lime;
            this.chair4.Location = new System.Drawing.Point(449, 49);
            this.chair4.Name = "chair4";
            this.chair4.Size = new System.Drawing.Size(60, 60);
            this.chair4.TabIndex = 13;
            this.chair4.TabStop = false;
            // 
            // chairBarber
            // 
            this.chairBarber.BackColor = System.Drawing.Color.Lime;
            this.chairBarber.Location = new System.Drawing.Point(288, 201);
            this.chairBarber.Name = "chairBarber";
            this.chairBarber.Size = new System.Drawing.Size(75, 73);
            this.chairBarber.TabIndex = 14;
            this.chairBarber.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Время ожидания";
            // 
            // hand
            // 
            this.hand.Controls.Add(this.NewClient);
            this.hand.Controls.Add(this.finishCut);
            this.hand.Location = new System.Drawing.Point(530, 130);
            this.hand.Name = "hand";
            this.hand.Size = new System.Drawing.Size(189, 88);
            this.hand.TabIndex = 16;
            this.hand.TabStop = false;
            this.hand.Text = "Ручной режим";
            // 
            // auto
            // 
            this.auto.Controls.Add(this.stopAuto);
            this.auto.Controls.Add(this.startAuto);
            this.auto.Location = new System.Drawing.Point(530, 224);
            this.auto.Name = "auto";
            this.auto.Size = new System.Drawing.Size(189, 110);
            this.auto.TabIndex = 17;
            this.auto.TabStop = false;
            this.auto.Text = "Автоматический режим";
            // 
            // stopAuto
            // 
            this.stopAuto.Enabled = false;
            this.stopAuto.Location = new System.Drawing.Point(7, 70);
            this.stopAuto.Name = "stopAuto";
            this.stopAuto.Size = new System.Drawing.Size(172, 23);
            this.stopAuto.TabIndex = 1;
            this.stopAuto.Text = "Остановить";
            this.stopAuto.UseVisualStyleBackColor = true;
            this.stopAuto.Click += new System.EventHandler(this.stopAuto_Click);
            // 
            // startAuto
            // 
            this.startAuto.Location = new System.Drawing.Point(7, 31);
            this.startAuto.Name = "startAuto";
            this.startAuto.Size = new System.Drawing.Size(172, 23);
            this.startAuto.TabIndex = 0;
            this.startAuto.Text = "Запустить";
            this.startAuto.UseVisualStyleBackColor = true;
            this.startAuto.Click += new System.EventHandler(this.startAuto_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // maxClientButton
            // 
            this.maxClientButton.Location = new System.Drawing.Point(7, 64);
            this.maxClientButton.Name = "maxClientButton";
            this.maxClientButton.Size = new System.Drawing.Size(172, 23);
            this.maxClientButton.TabIndex = 18;
            this.maxClientButton.Text = "Выбрать из файла";
            this.maxClientButton.UseVisualStyleBackColor = true;
            this.maxClientButton.Click += new System.EventHandler(this.maxClientButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maxClientTextBox);
            this.groupBox1.Controls.Add(this.maxClientButton);
            this.groupBox1.Location = new System.Drawing.Point(530, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 100);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Максимальное число клиентов";
            // 
            // maxClientTextBox
            // 
            this.maxClientTextBox.Location = new System.Drawing.Point(7, 27);
            this.maxClientTextBox.Name = "maxClientTextBox";
            this.maxClientTextBox.Size = new System.Drawing.Size(172, 20);
            this.maxClientTextBox.TabIndex = 19;
            this.maxClientTextBox.Text = "0";
            // 
            // Barbershop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 346);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.auto);
            this.Controls.Add(this.hand);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.chairBarber);
            this.Controls.Add(this.chair4);
            this.Controls.Add(this.chair3);
            this.Controls.Add(this.chair2);
            this.Controls.Add(this.chair1);
            this.Controls.Add(this.chairCout4);
            this.Controls.Add(this.chairCout3);
            this.Controls.Add(this.chairCout2);
            this.Controls.Add(this.chairCout1);
            this.Controls.Add(this.cout);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.work);
            this.Controls.Add(this.label1);
            this.Name = "Barbershop";
            this.Text = "Barbershop";
            ((System.ComponentModel.ISupportInitialize)(this.chair1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chair2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chair3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chair4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chairBarber)).EndInit();
            this.hand.ResumeLayout(false);
            this.auto.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewClient;
        private System.Windows.Forms.Button finishCut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label work;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label cout;
        private System.Windows.Forms.Label chairCout1;
        private System.Windows.Forms.Label chairCout2;
        private System.Windows.Forms.Label chairCout3;
        private System.Windows.Forms.Label chairCout4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox hand;
        private System.Windows.Forms.GroupBox auto;
        private System.Windows.Forms.Button startAuto;
        private System.Windows.Forms.Button stopAuto;
        public System.Windows.Forms.PictureBox chairBarber;
        private System.Windows.Forms.PictureBox chair1;
        private System.Windows.Forms.PictureBox chair2;
        private System.Windows.Forms.PictureBox chair3;
        private System.Windows.Forms.PictureBox chair4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button maxClientButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox maxClientTextBox;
    }
}

