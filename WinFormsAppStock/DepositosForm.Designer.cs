namespace WinFormsAppStock
{
    partial class DepositosForm
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
            gvDepositos = new DataGridView();
            txtDepositoId = new TextBox();
            label1 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)gvDepositos).BeginInit();
            SuspendLayout();
            // 
            // gvDepositos
            // 
            gvDepositos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvDepositos.Location = new Point(40, 121);
            gvDepositos.Name = "gvDepositos";
            gvDepositos.Size = new Size(720, 116);
            gvDepositos.TabIndex = 17;
            // 
            // txtDepositoId
            // 
            txtDepositoId.Location = new Point(129, 14);
            txtDepositoId.Name = "txtDepositoId";
            txtDepositoId.Size = new Size(159, 23);
            txtDepositoId.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 22);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 15;
            label1.Text = "IdDeposito";
            // 
            // button3
            // 
            button3.Location = new Point(601, 12);
            button3.Name = "button3";
            button3.Size = new Size(159, 67);
            button3.TabIndex = 14;
            button3.Text = "Agregar Deposito";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(330, 54);
            button2.Name = "button2";
            button2.Size = new Size(159, 25);
            button2.TabIndex = 13;
            button2.Text = "Modificar Deposito";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(330, 12);
            button1.Name = "button1";
            button1.Size = new Size(159, 25);
            button1.TabIndex = 12;
            button1.Text = "Eliminar Deposito";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DepositosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 307);
            Controls.Add(gvDepositos);
            Controls.Add(txtDepositoId);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "DepositosForm";
            Text = "DepositosForm";
            Load += DepositosForm_Load;
            ((System.ComponentModel.ISupportInitialize)gvDepositos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gvDepositos;
        private TextBox txtDepositoId;
        private Label label1;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}