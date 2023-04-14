namespace WinFormsAppStock
{
    partial class DepositosABM
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
            label4 = new Label();
            button1 = new Button();
            txtId = new TextBox();
            txtNombre = new TextBox();
            txtCapacidad = new TextBox();
            txtDireccion = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 52);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 90);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 134);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 2;
            label3.Text = "Capacidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 175);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 3;
            label4.Text = "Direccion";
            // 
            // button1
            // 
            button1.Location = new Point(62, 215);
            button1.Name = "button1";
            button1.Size = new Size(193, 47);
            button1.TabIndex = 4;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(128, 49);
            txtId.Name = "txtId";
            txtId.Size = new Size(127, 23);
            txtId.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(128, 87);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(127, 23);
            txtNombre.TabIndex = 6;
            // 
            // txtCapacidad
            // 
            txtCapacidad.Location = new Point(128, 126);
            txtCapacidad.Name = "txtCapacidad";
            txtCapacidad.Size = new Size(127, 23);
            txtCapacidad.TabIndex = 7;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(128, 167);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(127, 23);
            txtDireccion.TabIndex = 8;
            // 
            // DepositosABM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 313);
            Controls.Add(txtDireccion);
            Controls.Add(txtCapacidad);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DepositosABM";
            Text = "DepositosABM";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private TextBox txtId;
        private TextBox txtNombre;
        private TextBox txtCapacidad;
        private TextBox txtDireccion;
    }
}