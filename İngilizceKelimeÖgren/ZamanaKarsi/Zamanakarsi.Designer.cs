
namespace İngilizceKelimeÖgren
{
    partial class Zamanakarsi
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ingilizce = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_türkce = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_sure = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_kelime = new System.Windows.Forms.Label();
            this.lbl_cevap = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_ipucu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "İngilizce";
            // 
            // txt_ingilizce
            // 
            this.txt_ingilizce.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ingilizce.Location = new System.Drawing.Point(83, 54);
            this.txt_ingilizce.Name = "txt_ingilizce";
            this.txt_ingilizce.Size = new System.Drawing.Size(181, 27);
            this.txt_ingilizce.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Türkçe";
            // 
            // txt_türkce
            // 
            this.txt_türkce.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_türkce.Location = new System.Drawing.Point(83, 86);
            this.txt_türkce.Name = "txt_türkce";
            this.txt_türkce.Size = new System.Drawing.Size(181, 27);
            this.txt_türkce.TabIndex = 1;
            this.txt_türkce.TextChanged += new System.EventHandler(this.txt_türkce_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(351, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Süre: ";
            // 
            // lbl_sure
            // 
            this.lbl_sure.AutoSize = true;
            this.lbl_sure.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sure.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sure.Location = new System.Drawing.Point(396, 57);
            this.lbl_sure.Name = "lbl_sure";
            this.lbl_sure.Size = new System.Drawing.Size(25, 20);
            this.lbl_sure.TabIndex = 3;
            this.lbl_sure.Text = "90";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(351, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kelime: ";
            // 
            // lbl_kelime
            // 
            this.lbl_kelime.AutoSize = true;
            this.lbl_kelime.BackColor = System.Drawing.Color.Transparent;
            this.lbl_kelime.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kelime.Location = new System.Drawing.Point(414, 94);
            this.lbl_kelime.Name = "lbl_kelime";
            this.lbl_kelime.Size = new System.Drawing.Size(17, 20);
            this.lbl_kelime.TabIndex = 5;
            this.lbl_kelime.Text = "0";
            // 
            // lbl_cevap
            // 
            this.lbl_cevap.AutoSize = true;
            this.lbl_cevap.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cevap.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_cevap.Location = new System.Drawing.Point(296, 219);
            this.lbl_cevap.Name = "lbl_cevap";
            this.lbl_cevap.Size = new System.Drawing.Size(48, 20);
            this.lbl_cevap.TabIndex = 6;
            this.lbl_cevap.Text = "Süre: ";
            this.lbl_cevap.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(355, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "Menüye Dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btn_cikis);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 40);
            this.panel1.TabIndex = 10;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btn_cikis
            // 
            this.btn_cikis.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_cikis.FlatAppearance.BorderSize = 0;
            this.btn_cikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cikis.Image = global::İngilizceKelimeÖgren.Properties.Resources.icons8_close_16__1_;
            this.btn_cikis.Location = new System.Drawing.Point(470, 0);
            this.btn_cikis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(45, 40);
            this.btn_cikis.TabIndex = 1;
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            this.btn_cikis.MouseEnter += new System.EventHandler(this.btn_cikis_MouseEnter);
            this.btn_cikis.MouseLeave += new System.EventHandler(this.btn_cikis_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(13, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = " İngilizce Kelime Öğren- Zamana Karşı";
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.label4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.label4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btn_ipucu
            // 
            this.btn_ipucu.Location = new System.Drawing.Point(416, 216);
            this.btn_ipucu.Name = "btn_ipucu";
            this.btn_ipucu.Size = new System.Drawing.Size(87, 31);
            this.btn_ipucu.TabIndex = 11;
            this.btn_ipucu.Text = "İpucu";
            this.btn_ipucu.UseVisualStyleBackColor = true;
            this.btn_ipucu.Click += new System.EventHandler(this.btn_ipucu_Click);
            // 
            // Zamanakarsi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 259);
            this.Controls.Add(this.btn_ipucu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_cevap);
            this.Controls.Add(this.lbl_kelime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_sure);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_türkce);
            this.Controls.Add(this.txt_ingilizce);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Zamanakarsi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ingilizce;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_türkce;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_sure;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_kelime;
        private System.Windows.Forms.Label lbl_cevap;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_ipucu;
    }
}

