namespace WinFormsApp2_ejercicio
{
    partial class desafio_2
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
            labelTitulo = new Label();
            labelCap_Inicial = new Label();
            textBoxMontoIn = new TextBox();
            label1 = new Label();
            textBoxIntereses = new TextBox();
            labelTiempo = new Label();
            textBoxTiempo = new TextBox();
            buttonCalcular = new Button();
            labelTotal = new Label();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(163, 18);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(471, 32);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Calculadora de cuotas de un préstamo";
            // 
            // labelCap_Inicial
            // 
            labelCap_Inicial.AutoSize = true;
            labelCap_Inicial.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCap_Inicial.Location = new Point(274, 71);
            labelCap_Inicial.Name = "labelCap_Inicial";
            labelCap_Inicial.Size = new Size(208, 26);
            labelCap_Inicial.TabIndex = 1;
            labelCap_Inicial.Text = "Ingrese monto inicial";
            // 
            // textBoxMontoIn
            // 
            textBoxMontoIn.Location = new Point(318, 100);
            textBoxMontoIn.Name = "textBoxMontoIn";
            textBoxMontoIn.Size = new Size(125, 27);
            textBoxMontoIn.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(300, 145);
            label1.Name = "label1";
            label1.Size = new Size(169, 26);
            label1.TabIndex = 3;
            label1.Text = "Ingrese el interes";
            // 
            // textBoxIntereses
            // 
            textBoxIntereses.Location = new Point(318, 174);
            textBoxIntereses.Name = "textBoxIntereses";
            textBoxIntereses.Size = new Size(125, 27);
            textBoxIntereses.TabIndex = 4;
            // 
            // labelTiempo
            // 
            labelTiempo.AutoSize = true;
            labelTiempo.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTiempo.Location = new Point(206, 223);
            labelTiempo.Name = "labelTiempo";
            labelTiempo.Size = new Size(362, 26);
            labelTiempo.TabIndex = 5;
            labelTiempo.Text = "Ingrese el tiempo del prestamo (años)";
            // 
            // textBoxTiempo
            // 
            textBoxTiempo.Location = new Point(318, 267);
            textBoxTiempo.Name = "textBoxTiempo";
            textBoxTiempo.Size = new Size(125, 27);
            textBoxTiempo.TabIndex = 6;
            // 
            // buttonCalcular
            // 
            buttonCalcular.BackColor = Color.PaleVioletRed;
            buttonCalcular.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCalcular.Location = new Point(318, 322);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(113, 44);
            buttonCalcular.TabIndex = 7;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = false;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTotal.Location = new Point(175, 393);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(83, 26);
            labelTotal.TabIndex = 8;
            labelTotal.Text = "Total = ";
            // 
            // desafio_2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(800, 450);
            Controls.Add(labelTotal);
            Controls.Add(buttonCalcular);
            Controls.Add(textBoxTiempo);
            Controls.Add(labelTiempo);
            Controls.Add(textBoxIntereses);
            Controls.Add(label1);
            Controls.Add(textBoxMontoIn);
            Controls.Add(labelCap_Inicial);
            Controls.Add(labelTitulo);
            Name = "desafio_2";
            Text = "Desafio 2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private Label labelCap_Inicial;
        private TextBox textBoxMontoIn;
        private Label label1;
        private TextBox textBoxIntereses;
        private Label labelTiempo;
        private TextBox textBoxTiempo;
        private Button buttonCalcular;
        private Label labelTotal;
    }
}
