namespace Exemplo_2
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
            label2 = new Label();
            label3 = new Label();
            txtNum1 = new TextBox();
            txtResultado = new TextBox();
            txtNum2 = new TextBox();
            btnCalcular = new Button();
            rbSoma = new RadioButton();
            rbSub = new RadioButton();
            rbDiv = new RadioButton();
            rbMult = new RadioButton();
            txtTela = new RadioButton();
            txtRelatório = new RadioButton();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(207, 122);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Número 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(207, 159);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Número 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(207, 280);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 2;
            label3.Text = "Resultado";
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(273, 119);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(186, 23);
            txtNum1.TabIndex = 3;
            txtNum1.TextChanged += txtNum1_TextChanged;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(273, 277);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(186, 23);
            txtResultado.TabIndex = 4;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(273, 156);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(186, 23);
            txtNum2.TabIndex = 5;
            txtNum2.TextChanged += txtNum2_TextChanged;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(207, 220);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(252, 30);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // rbSoma
            // 
            rbSoma.AutoSize = true;
            rbSoma.Location = new Point(212, 195);
            rbSoma.Name = "rbSoma";
            rbSoma.Size = new Size(33, 19);
            rbSoma.TabIndex = 7;
            rbSoma.TabStop = true;
            rbSoma.Text = "+";
            rbSoma.UseVisualStyleBackColor = true;
            // 
            // rbSub
            // 
            rbSub.AutoSize = true;
            rbSub.Location = new Point(283, 195);
            rbSub.Name = "rbSub";
            rbSub.Size = new Size(30, 19);
            rbSub.TabIndex = 8;
            rbSub.TabStop = true;
            rbSub.Text = "-";
            rbSub.UseVisualStyleBackColor = true;
            // 
            // rbDiv
            // 
            rbDiv.AutoSize = true;
            rbDiv.Location = new Point(429, 195);
            rbDiv.Name = "rbDiv";
            rbDiv.Size = new Size(30, 19);
            rbDiv.TabIndex = 9;
            rbDiv.TabStop = true;
            rbDiv.Text = "/";
            rbDiv.UseVisualStyleBackColor = true;
            // 
            // rbMult
            // 
            rbMult.AutoSize = true;
            rbMult.Location = new Point(349, 195);
            rbMult.Name = "rbMult";
            rbMult.Size = new Size(30, 19);
            rbMult.TabIndex = 10;
            rbMult.TabStop = true;
            rbMult.Text = "*";
            rbMult.UseVisualStyleBackColor = true;
            // 
            // txtTela
            // 
            txtTela.AutoSize = true;
            txtTela.Location = new Point(212, 393);
            txtTela.Name = "txtTela";
            txtTela.Size = new Size(46, 19);
            txtTela.TabIndex = 11;
            txtTela.TabStop = true;
            txtTela.Text = "Tela";
            txtTela.UseVisualStyleBackColor = true;
            // 
            // txtRelatório
            // 
            txtRelatório.AutoSize = true;
            txtRelatório.Location = new Point(349, 393);
            txtRelatório.Name = "txtRelatório";
            txtRelatório.Size = new Size(72, 19);
            txtRelatório.TabIndex = 12;
            txtRelatório.TabStop = true;
            txtRelatório.Text = "Relatório";
            txtRelatório.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(212, 357);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 13;
            label4.Text = "Formato de Saída";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(txtRelatório);
            Controls.Add(txtTela);
            Controls.Add(rbMult);
            Controls.Add(rbDiv);
            Controls.Add(rbSub);
            Controls.Add(rbSoma);
            Controls.Add(btnCalcular);
            Controls.Add(txtNum2);
            Controls.Add(txtResultado);
            Controls.Add(txtNum1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNum1;
        private TextBox txtResultado;
        private TextBox txtNum2;
        private Button btnCalcular;
        private RadioButton rbSoma;
        private RadioButton rbSub;
        private RadioButton rbDiv;
        private RadioButton rbMult;
        private RadioButton txtTela;
        private RadioButton txtRelatório;
        private Label label4;
    }
}
