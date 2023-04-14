namespace WinFormsAppStock
{
    partial class StocksABM
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
            cbIdArticulo = new ComboBox();
            cbIdDeposito = new ComboBox();
            txtCantidad = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 50);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(98, 98);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "IdArticulo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(98, 145);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 2;
            label3.Text = "IdDeposito";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(98, 186);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 3;
            label4.Text = "Cantidad";
            // 
            // button1
            // 
            button1.Location = new Point(98, 228);
            button1.Name = "button1";
            button1.Size = new Size(229, 57);
            button1.TabIndex = 4;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(176, 42);
            txtId.Name = "txtId";
            txtId.Size = new Size(151, 23);
            txtId.TabIndex = 5;
            // 
            // cbIdArticulo
            // 
            cbIdArticulo.FormattingEnabled = true;
            cbIdArticulo.Location = new Point(176, 90);
            cbIdArticulo.Name = "cbIdArticulo";
            cbIdArticulo.Size = new Size(151, 23);
            cbIdArticulo.TabIndex = 6;
            // 
            // cbIdDeposito
            // 
            cbIdDeposito.FormattingEnabled = true;
            cbIdDeposito.Location = new Point(176, 137);
            cbIdDeposito.Name = "cbIdDeposito";
            cbIdDeposito.Size = new Size(151, 23);
            cbIdDeposito.TabIndex = 7;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(176, 178);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(151, 23);
            txtCantidad.TabIndex = 8;
            // 
            // StocksABM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 370);
            Controls.Add(txtCantidad);
            Controls.Add(cbIdDeposito);
            Controls.Add(cbIdArticulo);
            Controls.Add(txtId);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "StocksABM";
            Text = "StocksABM";
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
        private ComboBox cbIdArticulo;
        private ComboBox cbIdDeposito;
        private TextBox txtCantidad;
    }
}