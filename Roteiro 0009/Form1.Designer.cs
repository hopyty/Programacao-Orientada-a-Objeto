namespace Roteiro_0009
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
            txtNome = new TextBox();
            btnSalvar = new Button();
            btnListar = new Button();
            listUsuarios = new ListBox();
            txtSobrenome = new TextBox();
            btnExcluir = new Button();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 122);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(205, 23);
            txtNome.TabIndex = 0;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(142, 208);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 1;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(436, 122);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(75, 23);
            btnListar.TabIndex = 2;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // listUsuarios
            // 
            listUsuarios.FormattingEnabled = true;
            listUsuarios.ItemHeight = 15;
            listUsuarios.Location = new Point(436, 151);
            listUsuarios.Name = "listUsuarios";
            listUsuarios.Size = new Size(323, 244);
            listUsuarios.TabIndex = 3;
            // 
            // txtSobrenome
            // 
            txtSobrenome.Location = new Point(12, 167);
            txtSobrenome.Name = "txtSobrenome";
            txtSobrenome.Size = new Size(205, 23);
            txtSobrenome.TabIndex = 4;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(517, 121);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 5;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExcluir);
            Controls.Add(txtSobrenome);
            Controls.Add(listUsuarios);
            Controls.Add(btnListar);
            Controls.Add(btnSalvar);
            Controls.Add(txtNome);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private Button btnSalvar;
        private Button btnListar;
        private ListBox listUsuarios;
        private TextBox txtSobrenome;
        private Button btnExcluir;
    }
}
