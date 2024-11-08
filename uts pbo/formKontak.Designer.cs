namespace uts_pbo
{
    partial class formKontak
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            simpan = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(92, 93);
            label1.Name = "label1";
            label1.Size = new Size(69, 25);
            label1.TabIndex = 0;
            label1.Text = "Nama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(92, 176);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(92, 267);
            label3.Name = "label3";
            label3.Size = new Size(122, 25);
            label3.TabIndex = 2;
            label3.Text = "No.Telepon";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(227, 90);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(414, 31);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(227, 173);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(414, 31);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(227, 264);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(414, 31);
            textBox3.TabIndex = 5;
            // 
            // simpan
            // 
            simpan.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            simpan.Location = new Point(529, 353);
            simpan.Name = "simpan";
            simpan.Size = new Size(112, 34);
            simpan.TabIndex = 7;
            simpan.Text = "Simpan";
            simpan.UseVisualStyleBackColor = true;
            simpan.Click += simpan_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(400, 353);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 8;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            // 
            // formKontak
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(simpan);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "formKontak";
            Text = "formKontak";
            Load += formKontak_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button simpan;
        private Button button1;
    }
}