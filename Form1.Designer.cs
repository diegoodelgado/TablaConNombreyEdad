namespace TablaconNomyEdad_DADR
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
            Nombre = new Label();
            Edad = new Label();
            txtNombre = new TextBox();
            txtEdad = new TextBox();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            grilla = new DataGridView();
            panelPrincipal = new Panel();
            NameID = new Label();
            ((System.ComponentModel.ISupportInitialize)grilla).BeginInit();
            panelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.BackColor = Color.RosyBrown;
            Nombre.Location = new Point(61, 69);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(67, 20);
            Nombre.TabIndex = 0;
            Nombre.Text = "Nombre:";
            // 
            // Edad
            // 
            Edad.AutoSize = true;
            Edad.BackColor = Color.RosyBrown;
            Edad.Location = new Point(61, 116);
            Edad.Name = "Edad";
            Edad.Size = new Size(46, 20);
            Edad.TabIndex = 1;
            Edad.Text = "Edad:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(173, 69);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(329, 27);
            txtNombre.TabIndex = 2;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(173, 116);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(125, 27);
            txtEdad.TabIndex = 3;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Crimson;
            btnGuardar.ForeColor = Color.Transparent;
            btnGuardar.Location = new Point(666, 74);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Crimson;
            btnLimpiar.ForeColor = Color.Transparent;
            btnLimpiar.Location = new Point(801, 74);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // grilla
            // 
            grilla.BackgroundColor = Color.IndianRed;
            grilla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grilla.Location = new Point(106, 217);
            grilla.Name = "grilla";
            grilla.RowHeadersWidth = 51;
            grilla.Size = new Size(300, 188);
            grilla.TabIndex = 6;
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.Brown;
            panelPrincipal.Controls.Add(NameID);
            panelPrincipal.Location = new Point(-1, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(1020, 508);
            panelPrincipal.TabIndex = 7;
            // 
            // NameID
            // 
            NameID.AutoSize = true;
            NameID.Font = new Font("Franklin Gothic Medium Cond", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NameID.ForeColor = Color.Transparent;
            NameID.Location = new Point(63, 441);
            NameID.Name = "NameID";
            NameID.Size = new Size(405, 29);
            NameID.TabIndex = 0;
            NameID.Text = "Diego Abraham Delgado Rodriguez ID:300435";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 505);
            Controls.Add(grilla);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(txtEdad);
            Controls.Add(txtNombre);
            Controls.Add(Edad);
            Controls.Add(Nombre);
            Controls.Add(panelPrincipal);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)grilla).EndInit();
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Nombre;
        private Label Edad;
        private TextBox txtNombre;
        private TextBox txtEdad;
        private Button btnGuardar;
        private Button btnLimpiar;
        private DataGridView grilla;
        private Panel panelPrincipal;
        private Label NameID;
    }
}
