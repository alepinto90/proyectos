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
            label1 = new Label();
            lstRazasDePerros = new ListBox();
            label2 = new Label();
            lstCuidadesPais = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 0;
            label1.Text = "Hola Coder Mundo";
            label1.Click += label1_Click;
            // 
            // lstRazasDePerros
            // 
            lstRazasDePerros.FormattingEnabled = true;
            lstRazasDePerros.ItemHeight = 15;
            lstRazasDePerros.Location = new Point(47, 65);
            lstRazasDePerros.Name = "lstRazasDePerros";
            lstRazasDePerros.Size = new Size(120, 109);
            lstRazasDePerros.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 47);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 2;
            label2.Text = "Razas de Perro";
            // 
            // lstCuidadesPais
            // 
            lstCuidadesPais.FormattingEnabled = true;
            lstCuidadesPais.ItemHeight = 15;
            lstCuidadesPais.Location = new Point(196, 69);
            lstCuidadesPais.Name = "lstCuidadesPais";
            lstCuidadesPais.Size = new Size(318, 109);
            lstCuidadesPais.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(196, 43);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(277, 43);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(358, 43);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 6;
            button3.Text = "Modificar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(439, 43);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 7;
            button4.Text = "Limpiar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lstCuidadesPais);
            Controls.Add(label2);
            Controls.Add(lstRazasDePerros);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstRazasDePerros;
        private Label label2;
        private ListBox lstCuidadesPais;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
