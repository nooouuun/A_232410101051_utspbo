namespace uts_pbo
{
    partial class reg
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
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft JhengHei", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(518, 313);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 11;
            button1.Text = "Daftar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += this.button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft PhagsPa", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(171, 250);
            label3.Name = "label3";
            label3.Size = new Size(112, 31);
            label3.TabIndex = 10;
            label3.Text = "Password";
            label3.Click += this.label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft PhagsPa", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(171, 186);
            label2.Name = "label2";
            label2.Size = new Size(121, 31);
            label2.TabIndex = 9;
            label2.Text = "Username";
            label2.Click += this.label2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(317, 252);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(313, 31);
            textBox2.TabIndex = 8;
            textBox2.TextChanged += this.textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(317, 186);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(313, 31);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += this.textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft PhagsPa", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(317, 68);
            label1.Name = "label1";
            label1.Size = new Size(184, 47);
            label1.TabIndex = 6;
            label1.Text = "REGISTER";
            label1.Click += label1_Click;
            // 
            // reg
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "reg";
            Text = "reg";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
    }
}