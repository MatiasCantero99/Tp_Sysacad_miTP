namespace Formularios
{
    partial class FrmPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPago));
            label1 = new Label();
            dtgvConceptoPago = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Monto = new DataGridViewTextBoxColumn();
            IngresarMonton = new DataGridViewTextBoxColumn();
            CmboxMetodoPago = new ComboBox();
            TbxNumeroTarjeta = new TextBox();
            TbxNombreTitular = new TextBox();
            TbxFechaVencimiento = new TextBox();
            TbxCvv = new TextBox();
            CmboxCuota = new ComboBox();
            btnPagar = new Button();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvConceptoPago).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(415, 25);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(248, 32);
            label1.TabIndex = 0;
            label1.Text = "Vista Realizar Pago";
            // 
            // dtgvConceptoPago
            // 
            dtgvConceptoPago.BackgroundColor = Color.MediumSlateBlue;
            dtgvConceptoPago.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvConceptoPago.Columns.AddRange(new DataGridViewColumn[] { Nombre, Monto, IngresarMonton });
            dtgvConceptoPago.Location = new Point(17, 132);
            dtgvConceptoPago.Margin = new Padding(4, 5, 4, 5);
            dtgvConceptoPago.Name = "dtgvConceptoPago";
            dtgvConceptoPago.RowHeadersWidth = 62;
            dtgvConceptoPago.RowTemplate.Height = 25;
            dtgvConceptoPago.Size = new Size(491, 250);
            dtgvConceptoPago.TabIndex = 1;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Mes";
            Nombre.MinimumWidth = 8;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 150;
            // 
            // Monto
            // 
            Monto.HeaderText = "Deuda pendiente";
            Monto.MinimumWidth = 8;
            Monto.Name = "Monto";
            Monto.ReadOnly = true;
            Monto.Width = 150;
            // 
            // IngresarMonton
            // 
            IngresarMonton.HeaderText = "Ingresar monto";
            IngresarMonton.MinimumWidth = 8;
            IngresarMonton.Name = "IngresarMonton";
            IngresarMonton.Width = 150;
            // 
            // CmboxMetodoPago
            // 
            CmboxMetodoPago.BackColor = Color.Gold;
            CmboxMetodoPago.FlatStyle = FlatStyle.Flat;
            CmboxMetodoPago.Location = new Point(91, 423);
            CmboxMetodoPago.Margin = new Padding(4, 5, 4, 5);
            CmboxMetodoPago.Name = "CmboxMetodoPago";
            CmboxMetodoPago.Size = new Size(261, 33);
            CmboxMetodoPago.TabIndex = 0;
            CmboxMetodoPago.Text = "Seleccionar método de pago";
            // 
            // TbxNumeroTarjeta
            // 
            TbxNumeroTarjeta.BackColor = Color.Khaki;
            TbxNumeroTarjeta.Location = new Point(756, 209);
            TbxNumeroTarjeta.Margin = new Padding(4, 5, 4, 5);
            TbxNumeroTarjeta.Name = "TbxNumeroTarjeta";
            TbxNumeroTarjeta.PlaceholderText = "Número de tarjeta";
            TbxNumeroTarjeta.Size = new Size(197, 31);
            TbxNumeroTarjeta.TabIndex = 2;
            // 
            // TbxNombreTitular
            // 
            TbxNombreTitular.BackColor = Color.Khaki;
            TbxNombreTitular.Location = new Point(756, 261);
            TbxNombreTitular.Margin = new Padding(4, 5, 4, 5);
            TbxNombreTitular.Name = "TbxNombreTitular";
            TbxNombreTitular.PlaceholderText = "Nombre del titular";
            TbxNombreTitular.Size = new Size(197, 31);
            TbxNombreTitular.TabIndex = 3;
            // 
            // TbxFechaVencimiento
            // 
            TbxFechaVencimiento.BackColor = Color.Khaki;
            TbxFechaVencimiento.Location = new Point(756, 320);
            TbxFechaVencimiento.Margin = new Padding(4, 5, 4, 5);
            TbxFechaVencimiento.Name = "TbxFechaVencimiento";
            TbxFechaVencimiento.PlaceholderText = "Fecha de vencimiento:";
            TbxFechaVencimiento.Size = new Size(197, 31);
            TbxFechaVencimiento.TabIndex = 4;
            // 
            // TbxCvv
            // 
            TbxCvv.BackColor = Color.Khaki;
            TbxCvv.Location = new Point(756, 394);
            TbxCvv.Margin = new Padding(4, 5, 4, 5);
            TbxCvv.Name = "TbxCvv";
            TbxCvv.PlaceholderText = "CVV";
            TbxCvv.Size = new Size(197, 31);
            TbxCvv.TabIndex = 5;
            // 
            // CmboxCuota
            // 
            CmboxCuota.BackColor = Color.Gold;
            CmboxCuota.FlatStyle = FlatStyle.Flat;
            CmboxCuota.FormattingEnabled = true;
            CmboxCuota.Location = new Point(729, 479);
            CmboxCuota.Margin = new Padding(4, 5, 4, 5);
            CmboxCuota.Name = "CmboxCuota";
            CmboxCuota.Size = new Size(247, 33);
            CmboxCuota.TabIndex = 10;
            CmboxCuota.Text = "Seleccione cantidad cuota";
            // 
            // btnPagar
            // 
            btnPagar.BackColor = Color.Gold;
            btnPagar.FlatStyle = FlatStyle.Flat;
            btnPagar.Location = new Point(805, 534);
            btnPagar.Margin = new Padding(4, 5, 4, 5);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(107, 38);
            btnPagar.TabIndex = 11;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = false;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.IndianRed;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Location = new Point(43, 505);
            btnVolver.Margin = new Padding(4, 5, 4, 5);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(181, 38);
            btnVolver.TabIndex = 13;
            btnVolver.TabStop = false;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // FrmPago
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1078, 717);
            Controls.Add(btnVolver);
            Controls.Add(btnPagar);
            Controls.Add(CmboxCuota);
            Controls.Add(TbxCvv);
            Controls.Add(TbxFechaVencimiento);
            Controls.Add(TbxNombreTitular);
            Controls.Add(TbxNumeroTarjeta);
            Controls.Add(CmboxMetodoPago);
            Controls.Add(dtgvConceptoPago);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmPago";
            Text = "FrmPago";
            ((System.ComponentModel.ISupportInitialize)dtgvConceptoPago).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dtgvConceptoPago;
        private ComboBox CmboxMetodoPago;
        private TextBox TbxNumeroTarjeta;
        private TextBox TbxNombreTitular;
        private TextBox TbxFechaVencimiento;
        private TextBox TbxCvv;
        private ComboBox CmboxCuota;
        private Button btnPagar;
        private Button btnVolver;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Monto;
        private DataGridViewTextBoxColumn IngresarMonton;
    }
}