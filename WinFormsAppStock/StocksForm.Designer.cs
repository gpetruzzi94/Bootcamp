namespace WinFormsAppStock
{
    partial class StocksForm
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
            components = new System.ComponentModel.Container();
            gvStocks = new DataGridView();
            stockBindingSource = new BindingSource(components);
            txtStockId = new TextBox();
            label1 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)gvStocks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)stockBindingSource).BeginInit();
            SuspendLayout();
            // 
            // gvStocks
            // 
            gvStocks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvStocks.Location = new Point(42, 121);
            gvStocks.Name = "gvStocks";
            gvStocks.Size = new Size(720, 116);
            gvStocks.TabIndex = 11;
            gvStocks.CellContentClick += gvStocks_CellContentClick;
            // 
            // stockBindingSource
            // 
            stockBindingSource.DataSource = typeof(CodigoComun.Entities.Stock);
            // 
            // txtStockId
            // 
            txtStockId.Location = new Point(131, 14);
            txtStockId.Name = "txtStockId";
            txtStockId.Size = new Size(159, 23);
            txtStockId.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 22);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 9;
            label1.Text = "IdStock";
            // 
            // button3
            // 
            button3.Location = new Point(603, 12);
            button3.Name = "button3";
            button3.Size = new Size(159, 67);
            button3.TabIndex = 8;
            button3.Text = "Agregar Stock";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(332, 54);
            button2.Name = "button2";
            button2.Size = new Size(159, 25);
            button2.TabIndex = 7;
            button2.Text = "Modificar Stock";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(332, 12);
            button1.Name = "button1";
            button1.Size = new Size(159, 25);
            button1.TabIndex = 6;
            button1.Text = "Eliminar Stock";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // StocksForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gvStocks);
            Controls.Add(txtStockId);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "StocksForm";
            Text = "StocksForm";
            ((System.ComponentModel.ISupportInitialize)gvStocks).EndInit();
            ((System.ComponentModel.ISupportInitialize)stockBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gvStocks;
        private TextBox txtStockId;
        private Label label1;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridViewTextBoxColumn articuloGuardadoDataGridViewTextBoxColumn;
        private BindingSource stockBindingSource;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}