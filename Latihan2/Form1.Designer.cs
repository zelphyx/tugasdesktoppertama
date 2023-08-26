
namespace Latihan2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.txtalamat = new System.Windows.Forms.TextBox();
            this.txthobby = new System.Windows.Forms.TextBox();
            this.txtabsen = new System.Windows.Forms.TextBox();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label9 = new System.Windows.Forms.Label();
            this.cbagama = new System.Windows.Forms.ComboBox();
            this.cbkelas = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.label1.Location = new System.Drawing.Point(192, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama        :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.label2.Location = new System.Drawing.Point(194, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kelas         :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.label3.Location = new System.Drawing.Point(156, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nomor Absen       :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.label4.Location = new System.Drawing.Point(156, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Jenis Kelamin      :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.label5.Location = new System.Drawing.Point(187, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Agama         :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.label6.Location = new System.Drawing.Point(189, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Hobby          :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.label7.Location = new System.Drawing.Point(128, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Alamat Rumah/Kos       :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(256, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(275, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Form Pengisian Data Diri";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(281, 212);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(69, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Laki-Laki";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(378, 212);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "Perempuan";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // txtalamat
            // 
            this.txtalamat.Location = new System.Drawing.Point(278, 299);
            this.txtalamat.Multiline = true;
            this.txtalamat.Name = "txtalamat";
            this.txtalamat.Size = new System.Drawing.Size(181, 97);
            this.txtalamat.TabIndex = 11;
            this.txtalamat.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txthobby
            // 
            this.txthobby.Location = new System.Drawing.Point(281, 268);
            this.txthobby.Name = "txthobby";
            this.txthobby.Size = new System.Drawing.Size(178, 20);
            this.txthobby.TabIndex = 13;
            // 
            // txtabsen
            // 
            this.txtabsen.Location = new System.Drawing.Point(278, 182);
            this.txtabsen.Name = "txtabsen";
            this.txtabsen.Size = new System.Drawing.Size(181, 20);
            this.txtabsen.TabIndex = 14;
            this.txtabsen.TextChanged += new System.EventHandler(this.txtabsen_TextChanged);
            // 
            // txtnama
            // 
            this.txtnama.Location = new System.Drawing.Point(281, 119);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(178, 20);
            this.txtnama.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(532, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 38);
            this.button1.TabIndex = 17;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(655, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 38);
            this.button2.TabIndex = 18;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 425);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "By Ilhami Rizqy";
            // 
            // cbagama
            // 
            this.cbagama.FormattingEnabled = true;
            this.cbagama.Items.AddRange(new object[] {
            "",
            "Islam ",
            "Kristen",
            "Katolik",
            "Hindu",
            "Budha",
            "Konghucu",
            "Kepercayaan"});
            this.cbagama.Location = new System.Drawing.Point(280, 241);
            this.cbagama.Name = "cbagama";
            this.cbagama.Size = new System.Drawing.Size(121, 21);
            this.cbagama.TabIndex = 20;
            this.cbagama.SelectedIndexChanged += new System.EventHandler(this.cbagama_SelectedIndexChanged);
            // 
            // cbkelas
            // 
            this.cbkelas.FormattingEnabled = true;
            this.cbkelas.Items.AddRange(new object[] {
            "",
            "10 PPLG 1",
            "10 PPLG 2",
            "11 PPLG 1",
            "11 PPLG 2",
            "12 PPLG 1",
            "12 PPLG 2"});
            this.cbkelas.Location = new System.Drawing.Point(280, 150);
            this.cbkelas.Name = "cbkelas";
            this.cbkelas.Size = new System.Drawing.Size(121, 21);
            this.cbkelas.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(792, 450);
            this.Controls.Add(this.cbkelas);
            this.Controls.Add(this.cbagama);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtnama);
            this.Controls.Add(this.txtabsen);
            this.Controls.Add(this.txthobby);
            this.Controls.Add(this.txtalamat);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox txtalamat;
        private System.Windows.Forms.TextBox txthobby;
        private System.Windows.Forms.TextBox txtabsen;
        private System.Windows.Forms.TextBox txtnama;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbagama;
        private System.Windows.Forms.ComboBox cbkelas;
    }
}

