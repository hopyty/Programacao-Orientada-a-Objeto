namespace Roteiro_08_POO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            button5 = new Button();
            button4 = new Button();
            label1 = new Label();
            button1 = new Button();
            panel2 = new Panel();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 192, 192);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 60);
            panel1.TabIndex = 0;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.FlatAppearance.BorderColor = Color.White;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(707, 12);
            button5.Name = "button5";
            button5.Size = new Size(23, 22);
            button5.TabIndex = 3;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.FlatAppearance.BorderColor = Color.White;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(736, 12);
            button4.Name = "button4";
            button4.Size = new Size(23, 22);
            button4.TabIndex = 2;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(15, 12);
            label1.Name = "label1";
            label1.Size = new Size(246, 32);
            label1.TabIndex = 1;
            label1.Text = "Controle de Estoque";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(765, 12);
            button1.Name = "button1";
            button1.Size = new Size(23, 22);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(button8);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button2);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(12, 66);
            panel2.Name = "panel2";
            panel2.Size = new Size(156, 372);
            panel2.TabIndex = 1;
            // 
            // button8
            // 
            button8.FlatAppearance.BorderColor = Color.White;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatAppearance.MouseDownBackColor = Color.White;
            button8.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(3, 230);
            button8.Name = "button8";
            button8.Size = new Size(150, 23);
            button8.TabIndex = 3;
            button8.Text = "DashBoard";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.FlatAppearance.BorderColor = Color.White;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatAppearance.MouseDownBackColor = Color.White;
            button7.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(3, 166);
            button7.Name = "button7";
            button7.Size = new Size(150, 23);
            button7.TabIndex = 2;
            button7.Text = "Estoque";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.FlatAppearance.BorderColor = Color.White;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseDownBackColor = Color.White;
            button6.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(3, 107);
            button6.Name = "button6";
            button6.Size = new Size(150, 23);
            button6.TabIndex = 1;
            button6.Text = "Fornecedor";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.White;
            button2.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(3, 41);
            button2.Name = "button2";
            button2.Size = new Size(150, 23);
            button2.TabIndex = 0;
            button2.Text = "Clientes";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Roteiro 08 - Meu Site";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private Panel panel2;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button7;
        private Button button6;
        private Button button8;
    }
}
