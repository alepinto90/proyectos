namespace WinFormsApp1
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
            btnAgregar = new Button();
            Productos = new Label();
            dgvVista = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvVista).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(413, 14);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(109, 63);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // Productos
            // 
            Productos.AutoSize = true;
            Productos.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            Productos.Location = new Point(43, 14);
            Productos.Name = "Productos";
            Productos.Size = new Size(214, 54);
            Productos.TabIndex = 1;
            Productos.Text = "Productos";
            Productos.Click += label1_Click;
            // 
            // dgvVista
            // 
            dgvVista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVista.Location = new Point(12, 87);
            dgvVista.Name = "dgvVista";
            dgvVista.RowTemplate.Height = 25;
            dgvVista.Size = new Size(776, 351);
            dgvVista.TabIndex = 2;

            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvVista);
            Controls.Add(Productos);
            Controls.Add(btnAgregar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private Label Productos;
        private DataGridView dgvVista;
    }
}
