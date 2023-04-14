namespace WinFormsAppStock.Vistas
{
    partial class ArticulosForm
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
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            txtArticuloId = new TextBox();
            gvArticulos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gvArticulos).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(347, 22);
            button1.Name = "button1";
            button1.Size = new Size(159, 25);
            button1.TabIndex = 0;
            button1.Text = "Eliminar Articulo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(347, 64);
            button2.Name = "button2";
            button2.Size = new Size(159, 25);
            button2.TabIndex = 1;
            button2.Text = "Modificar Articulo";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(624, 22);
            button3.Name = "button3";
            button3.Size = new Size(159, 67);
            button3.TabIndex = 2;
            button3.Text = "Agregar Articulo";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 3;
            label1.Text = "IdArticulo";
            // 
            // txtArticuloId
            // 
            txtArticuloId.Location = new Point(108, 22);
            txtArticuloId.Name = "txtArticuloId";
            txtArticuloId.Size = new Size(159, 23);
            txtArticuloId.TabIndex = 4;
            // 
            // gvArticulos
            // 
            gvArticulos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvArticulos.Location = new Point(12, 131);
            gvArticulos.Name = "gvArticulos";
            gvArticulos.RowTemplate.Height = 25;
            gvArticulos.Size = new Size(771, 116);
            gvArticulos.TabIndex = 5;
            // 
            // ArticulosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 450);
            Controls.Add(gvArticulos);
            Controls.Add(txtArticuloId);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "ArticulosForm";
            Text = "ArticulosForm";
            ((System.ComponentModel.ISupportInitialize)gvArticulos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private TextBox txtArticuloId;
        private DataGridView gvArticulos;
    }
}