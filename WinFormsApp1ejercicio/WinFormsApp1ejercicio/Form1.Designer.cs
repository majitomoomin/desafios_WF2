namespace WinFormsApp1ejercicio
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
            labelTitulo = new Label();
            montoInicial = new Label();
            textBox_monto = new TextBox();
            TasaInteres = new Label();
            textBoxTasaInt = new TextBox();
            labelPeriodo = new Label();
            textBox1 = new TextBox();
            labelTotal = new Label();
            buttonCalcular = new Button();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(93, 9);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(588, 31);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Calcular el capital final de un ahorro a plazo fijo";
            // 
            // montoInicial
            // 
            montoInicial.AutoSize = true;
            montoInicial.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            montoInicial.Location = new Point(266, 67);
            montoInicial.Name = "montoInicial";
            montoInicial.Size = new Size(236, 27);
            montoInicial.TabIndex = 1;
            montoInicial.Text = "Ingrese el monto inicial";
            // 
            // textBox_monto
            // 
            textBox_monto.Location = new Point(298, 96);
            textBox_monto.Name = "textBox_monto";
            textBox_monto.Size = new Size(174, 27);
            textBox_monto.TabIndex = 2;
            // 
            // TasaInteres
            // 
            TasaInteres.AutoSize = true;
            TasaInteres.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TasaInteres.Location = new Point(241, 145);
            TasaInteres.Name = "TasaInteres";
            TasaInteres.Size = new Size(294, 26);
            TasaInteres.TabIndex = 3;
            TasaInteres.Text = "Ingrese la tasa de interes anual";
            // 
            // textBoxTasaInt
            // 
            textBoxTasaInt.Location = new Point(298, 185);
            textBoxTasaInt.Name = "textBoxTasaInt";
            textBoxTasaInt.Size = new Size(174, 27);
            textBoxTasaInt.TabIndex = 4;
            // 
            // labelPeriodo
            // 
            labelPeriodo.AutoSize = true;
            labelPeriodo.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPeriodo.Location = new Point(198, 232);
            labelPeriodo.Name = "labelPeriodo";
            labelPeriodo.Size = new Size(374, 26);
            labelPeriodo.TabIndex = 5;
            labelPeriodo.Text = "Ingresar el periodo de inversión (años)";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(298, 275);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(174, 27);
            textBox1.TabIndex = 6;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTotal.Location = new Point(317, 408);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(94, 33);
            labelTotal.TabIndex = 7;
            labelTotal.Text = "Total =";
            // 
            // buttonCalcular
            // 
            buttonCalcular.BackColor = Color.YellowGreen;
            buttonCalcular.Cursor = Cursors.Hand;
            buttonCalcular.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCalcular.Location = new Point(307, 327);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(145, 47);
            buttonCalcular.TabIndex = 8;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = false;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCalcular);
            Controls.Add(labelTotal);
            Controls.Add(textBox1);
            Controls.Add(labelPeriodo);
            Controls.Add(textBoxTasaInt);
            Controls.Add(TasaInteres);
            Controls.Add(textBox_monto);
            Controls.Add(montoInicial);
            Controls.Add(labelTitulo);
            Name = "Form1";
            Text = "Desafio 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private Label montoInicial;
        private TextBox textBox_monto;
        private Label TasaInteres;
        private TextBox textBoxTasaInt;
        private Label labelPeriodo;
        private TextBox textBox1;
        private Label labelTotal;
        private Button buttonCalcular;
    }
}
