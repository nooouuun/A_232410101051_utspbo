namespace uts_pbo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            regisbutton = new Button();
            loginbutton = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(227, 49);
            label1.Name = "label1";
            label1.Size = new Size(365, 92);
            label1.TabIndex = 0;
            label1.Text = "SELAMAT DATANG \r\nDI CONTACT APP!\r\n";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // regisbutton
            // 
            regisbutton.Location = new Point(98, 46);
            regisbutton.Name = "regisbutton";
            regisbutton.Size = new Size(151, 40);
            regisbutton.TabIndex = 3;
            regisbutton.Text = "Register";
            regisbutton.UseVisualStyleBackColor = true;
            regisbutton.Click += button2_Click;
            // 
            // loginbutton
            // 
            loginbutton.Location = new Point(98, 102);
            loginbutton.Name = "loginbutton";
            loginbutton.Size = new Size(151, 40);
            loginbutton.TabIndex = 4;
            loginbutton.Text = "Login";
            loginbutton.UseVisualStyleBackColor = true;
            loginbutton.Click += button3_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(loginbutton);
            groupBox1.Controls.Add(regisbutton);
            groupBox1.Location = new Point(239, 208);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(336, 163);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pilih Tindakan yang ingin dilakukan";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button regisbutton;
        private Button loginbutton;
        private GroupBox groupBox1;
    }
}
