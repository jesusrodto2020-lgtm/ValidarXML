namespace GuardarTextoenXmlPractPropia
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
            btnGuardarTexto = new Button();
            btnMostrarTextoGuardado = new Button();
            txtTextoEscrito = new TextBox();
            lblTextoGuardado = new Label();
            SuspendLayout();
            // 
            // btnGuardarTexto
            // 
            btnGuardarTexto.Location = new Point(640, 75);
            btnGuardarTexto.Name = "btnGuardarTexto";
            btnGuardarTexto.Size = new Size(114, 23);
            btnGuardarTexto.TabIndex = 0;
            btnGuardarTexto.Text = "GuardarTexto";
            btnGuardarTexto.UseVisualStyleBackColor = true;
            btnGuardarTexto.Click += btnGuardarTexto_Click;
            // 
            // btnMostrarTextoGuardado
            // 
            btnMostrarTextoGuardado.Location = new Point(659, 264);
            btnMostrarTextoGuardado.Name = "btnMostrarTextoGuardado";
            btnMostrarTextoGuardado.Size = new Size(112, 23);
            btnMostrarTextoGuardado.TabIndex = 1;
            btnMostrarTextoGuardado.Text = "Texto Guardado";
            btnMostrarTextoGuardado.UseVisualStyleBackColor = true;
            btnMostrarTextoGuardado.Click += btnMostrarTextoGuardado_Click;
            // 
            // txtTextoEscrito
            // 
            txtTextoEscrito.Location = new Point(171, 12);
            txtTextoEscrito.Multiline = true;
            txtTextoEscrito.Name = "txtTextoEscrito";
            txtTextoEscrito.Size = new Size(415, 203);
            txtTextoEscrito.TabIndex = 2;
            // 
            // lblTextoGuardado
            // 
            lblTextoGuardado.Location = new Point(171, 218);
            lblTextoGuardado.Name = "lblTextoGuardado";
            lblTextoGuardado.Size = new Size(415, 280);
            lblTextoGuardado.TabIndex = 3;
            lblTextoGuardado.Text = "\"Aqui se reflejara el texto\"";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(851, 518);
            Controls.Add(lblTextoGuardado);
            Controls.Add(txtTextoEscrito);
            Controls.Add(btnMostrarTextoGuardado);
            Controls.Add(btnGuardarTexto);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardarTexto;
        private Button btnMostrarTextoGuardado;
        private TextBox txtTextoEscrito;
        private Label lblTextoGuardado;
    }
}
