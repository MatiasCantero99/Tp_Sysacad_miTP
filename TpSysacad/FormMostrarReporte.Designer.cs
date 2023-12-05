namespace Formularios
{
    partial class FormMostrarReporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMostrarReporte));
            lblMuestraPDF = new Label();
            btnGenerarPDF = new Button();
            SuspendLayout();
            // 
            // lblMuestraPDF
            // 
            lblMuestraPDF.AutoSize = true;
            lblMuestraPDF.BackColor = Color.Transparent;
            lblMuestraPDF.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMuestraPDF.Location = new Point(203, 69);
            lblMuestraPDF.Name = "lblMuestraPDF";
            lblMuestraPDF.Size = new Size(47, 25);
            lblMuestraPDF.TabIndex = 0;
            lblMuestraPDF.Text = "hola";
            // 
            // btnGenerarPDF
            // 
            btnGenerarPDF.BackColor = Color.Khaki;
            btnGenerarPDF.FlatStyle = FlatStyle.Flat;
            btnGenerarPDF.ForeColor = SystemColors.ActiveCaptionText;
            btnGenerarPDF.Location = new Point(743, 611);
            btnGenerarPDF.Name = "btnGenerarPDF";
            btnGenerarPDF.Size = new Size(178, 34);
            btnGenerarPDF.TabIndex = 1;
            btnGenerarPDF.Text = "Generar PDF";
            btnGenerarPDF.UseVisualStyleBackColor = false;
            btnGenerarPDF.Click += btnGenerarPDF_Click;
            // 
            // FormMostrarReporte
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1078, 717);
            Controls.Add(btnGenerarPDF);
            Controls.Add(lblMuestraPDF);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormMostrarReporte";
            Text = "FormMostrarReporte";
            Load += FormMostrarReporte_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMuestraPDF;
        private Button btnGenerarPDF;
    }
}