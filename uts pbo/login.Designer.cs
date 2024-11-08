namespace uts_pbo
{
    partial class login
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
            button1.Location = new Point(518, 331);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 17;
            button1.Text = "login";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft PhagsPa", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(171, 268);
            label3.Name = "label3";
            label3.Size = new Size(112, 31);
            label3.TabIndex = 16;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft PhagsPa", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(171, 204);
            label2.Name = "label2";
            label2.Size = new Size(121, 31);
            label2.TabIndex = 15;
            label2.Text = "Username";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(317, 270);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(313, 31);
            textBox2.TabIndex = 14;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(317, 204);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(313, 31);
            textBox1.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft PhagsPa", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(351, 86);
            label1.Name = "label1";
            label1.Size = new Size(130, 47);
            label1.TabIndex = 12;
            label1.Text = "LOGIN";
            // 
            // login
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
            Name = "login";
            Text = "login";
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