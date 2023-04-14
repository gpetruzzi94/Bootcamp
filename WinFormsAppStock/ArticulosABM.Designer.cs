namespace WinFormsAppStock
{
    partial class ArticulosABM
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtId = new TextBox();
            txtNombre = new TextBox();
            txtMarca = new TextBox();
            txtMinimoStock = new TextBox();
            txtProveedor = new TextBox();
            txtPrecio = new TextBox();
            txtCodigo = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(171, 267);
            button1.Name = "button1";
            button1.Size = new Size(179, 36);
            button1.TabIndex = 0;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 28);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 1;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 62);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 100);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 3;
            label3.Text = "Marca";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 137);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 4;
            label4.Text = "Minimo Stock";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(62, 172);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 5;
            label5.Text = "Proveedor";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(62, 207);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 6;
            label6.Text = "Precio";
            // 
            // txtId
            // 
            txtId.Location = new Point(171, 25);
            txtId.Name = "txtId";
            txtId.Size = new Size(80, 23);
            txtId.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(171, 54);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(179, 23);
            txtNombre.TabIndex = 8;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(171, 92);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(179, 23);
            txtMarca.TabIndex = 9;
            // 
            // txtMinimoStock
            // 
            txtMinimoStock.Location = new Point(171, 129);
            txtMinimoStock.Name = "txtMinimoStock";
            txtMinimoStock.Size = new Size(179, 23);
            txtMinimoStock.TabIndex = 10;
            // 
            // txtProveedor
            // 
            txtProveedor.Location = new Point(171, 164);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(179, 23);
            txtProveedor.TabIndex = 11;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(171, 199);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(179, 23);
            txtPrecio.TabIndex = 12;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(171, 228);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(179, 23);
            txtCodigo.TabIndex = 14;
            txtCodigo.TextChanged += textBox1_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(62, 236);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 13;
            label7.Text = "Codigo";
            label7.Click += label7_Click;
            // 
            // ArticulosABM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 357);
            Controls.Add(txtCodigo);
            Controls.Add(label7);
            Controls.Add(txtPrecio);
            Controls.Add(txtProveedor);
            Controls.Add(txtMinimoStock);
            Controls.Add(txtMarca);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "ArticulosABM";
            Text = "ArticulosABM";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtId;
        private TextBox txtNombre;
        private TextBox txtMarca;
        private TextBox txtMinimoStock;
        private TextBox txtProveedor;
        private TextBox txtPrecio;
        private TextBox txtCodigo;
        private Label label7;
    }
}