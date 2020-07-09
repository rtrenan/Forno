namespace Testeconnect
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.leitura = new System.Windows.Forms.Label();
            this.leitura2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.temp1 = new System.Windows.Forms.Label();
            this.temp2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.comunicaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comunicaçãoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rampaTemperaturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endereçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtslave = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_sol = new System.Windows.Forms.Button();
            this.btn_for = new System.Windows.Forms.Button();
            this.txt_time = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btn_open = new System.Windows.Forms.Button();
            this.programaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // leitura
            // 
            this.leitura.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.leitura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leitura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leitura.Location = new System.Drawing.Point(9, 151);
            this.leitura.Name = "leitura";
            this.leitura.Size = new System.Drawing.Size(126, 23);
            this.leitura.TabIndex = 0;
            this.leitura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // leitura2
            // 
            this.leitura2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.leitura2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leitura2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leitura2.Location = new System.Drawing.Point(9, 194);
            this.leitura2.Name = "leitura2";
            this.leitura2.Size = new System.Drawing.Size(126, 24);
            this.leitura2.TabIndex = 1;
            this.leitura2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(229, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // temp1
            // 
            this.temp1.AutoSize = true;
            this.temp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temp1.Location = new System.Drawing.Point(8, 125);
            this.temp1.Name = "temp1";
            this.temp1.Size = new System.Drawing.Size(111, 20);
            this.temp1.TabIndex = 9;
            this.temp1.Text = "Temperatura";
            // 
            // temp2
            // 
            this.temp2.AutoSize = true;
            this.temp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temp2.Location = new System.Drawing.Point(8, 174);
            this.temp2.Name = "temp2";
            this.temp2.Size = new System.Drawing.Size(103, 20);
            this.temp2.TabIndex = 10;
            this.temp2.Text = "Temp - SET";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comunicaçãoToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(452, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // comunicaçãoToolStripMenuItem
            // 
            this.comunicaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comunicaçãoToolStripMenuItem1,
            this.rampaTemperaturaToolStripMenuItem,
            this.programaçãoToolStripMenuItem,
            this.fecharToolStripMenuItem});
            this.comunicaçãoToolStripMenuItem.Name = "comunicaçãoToolStripMenuItem";
            this.comunicaçãoToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.comunicaçãoToolStripMenuItem.Text = "Configuração";
            // 
            // comunicaçãoToolStripMenuItem1
            // 
            this.comunicaçãoToolStripMenuItem1.Name = "comunicaçãoToolStripMenuItem1";
            this.comunicaçãoToolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
            this.comunicaçãoToolStripMenuItem1.Text = "Comunicação";
            this.comunicaçãoToolStripMenuItem1.Click += new System.EventHandler(this.comunicaçãoToolStripMenuItem1_Click);
            // 
            // rampaTemperaturaToolStripMenuItem
            // 
            this.rampaTemperaturaToolStripMenuItem.Name = "rampaTemperaturaToolStripMenuItem";
            this.rampaTemperaturaToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.rampaTemperaturaToolStripMenuItem.Text = "Rampa - Temperatura";
            this.rampaTemperaturaToolStripMenuItem.Click += new System.EventHandler(this.rampaTemperaturaToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.endereçosToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // endereçosToolStripMenuItem
            // 
            this.endereçosToolStripMenuItem.Name = "endereçosToolStripMenuItem";
            this.endereçosToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.endereçosToolStripMenuItem.Text = "Endereços ";
            // 
            // txtslave
            // 
            this.txtslave.Location = new System.Drawing.Point(259, 96);
            this.txtslave.Name = "txtslave";
            this.txtslave.Size = new System.Drawing.Size(65, 20);
            this.txtslave.TabIndex = 13;
            this.txtslave.Text = "1";
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(349, 96);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(65, 20);
            this.txtaddress.TabIndex = 14;
            this.txtaddress.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Slave ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Start Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Solenóide";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Testeconnect.Properties.Resources._9064;
            this.pictureBox2.Location = new System.Drawing.Point(189, 125);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(225, 190);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Testeconnect.Properties.Resources.imagemT2;
            this.pictureBox1.Location = new System.Drawing.Point(12, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 63);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Forno";
            // 
            // btn_sol
            // 
            this.btn_sol.BackColor = System.Drawing.SystemColors.Control;
            this.btn_sol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_sol.Location = new System.Drawing.Point(10, 260);
            this.btn_sol.Name = "btn_sol";
            this.btn_sol.Size = new System.Drawing.Size(122, 27);
            this.btn_sol.TabIndex = 19;
            this.btn_sol.Text = "DESLIGADO";
            this.btn_sol.UseVisualStyleBackColor = false;
            this.btn_sol.Click += new System.EventHandler(this.btn_sol_Click);
            // 
            // btn_for
            // 
            this.btn_for.BackColor = System.Drawing.SystemColors.Control;
            this.btn_for.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_for.Location = new System.Drawing.Point(10, 307);
            this.btn_for.Name = "btn_for";
            this.btn_for.Size = new System.Drawing.Size(122, 27);
            this.btn_for.TabIndex = 20;
            this.btn_for.Text = "DESLIGADO";
            this.btn_for.UseVisualStyleBackColor = false;
            this.btn_for.Click += new System.EventHandler(this.btn_for_Click);
            // 
            // txt_time
            // 
            this.txt_time.Location = new System.Drawing.Point(294, 321);
            this.txt_time.Name = "txt_time";
            this.txt_time.Size = new System.Drawing.Size(86, 20);
            this.txt_time.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(195, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Tempo do Teste";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(325, 36);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(101, 23);
            this.btn_open.TabIndex = 23;
            this.btn_open.Text = "OPEN PORT";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // programaçãoToolStripMenuItem
            // 
            this.programaçãoToolStripMenuItem.Name = "programaçãoToolStripMenuItem";
            this.programaçãoToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.programaçãoToolStripMenuItem.Text = "Programação";
            this.programaçãoToolStripMenuItem.Click += new System.EventHandler(this.programaçãoToolStripMenuItem_Click);
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.fecharToolStripMenuItem.Text = "Fechar";
            this.fecharToolStripMenuItem.Click += new System.EventHandler(this.fecharToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(452, 353);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_time);
            this.Controls.Add(this.btn_for);
            this.Controls.Add(this.btn_sol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtslave);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.temp2);
            this.Controls.Add(this.temp1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.leitura2);
            this.Controls.Add(this.leitura);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Config - Estresse Térmico";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label leitura;
        private System.Windows.Forms.Label leitura2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label temp1;
        private System.Windows.Forms.Label temp2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem comunicaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comunicaçãoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endereçosToolStripMenuItem;
        private System.Windows.Forms.TextBox txtslave;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem rampaTemperaturaToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button btn_sol;
        public System.Windows.Forms.Button btn_for;
        private System.Windows.Forms.TextBox txt_time;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.ToolStripMenuItem programaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
    }
}

