﻿namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt100 = new System.Windows.Forms.Button();
            this.txPantalla = new System.Windows.Forms.TextBox();
            this.btC = new System.Windows.Forms.Button();
            this.btBorrar = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.btDividir = new System.Windows.Forms.Button();
            this.btMultiplicar = new System.Windows.Forms.Button();
            this.btMes = new System.Windows.Forms.Button();
            this.btRestar = new System.Windows.Forms.Button();
            this.btComa = new System.Windows.Forms.Button();
            this.btIgual = new System.Windows.Forms.Button();
            this.btCanviSigne = new System.Windows.Forms.Button();
            this.txHistorial = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt100
            // 
            this.bt100.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt100.Location = new System.Drawing.Point(16, 76);
            this.bt100.Margin = new System.Windows.Forms.Padding(6);
            this.bt100.Name = "bt100";
            this.bt100.Size = new System.Drawing.Size(70, 75);
            this.bt100.TabIndex = 0;
            this.bt100.TabStop = false;
            this.bt100.Text = "%";
            this.bt100.UseVisualStyleBackColor = true;
            this.bt100.Click += new System.EventHandler(this.bt100_Click);
            // 
            // txPantalla
            // 
            this.txPantalla.Location = new System.Drawing.Point(16, 26);
            this.txPantalla.Margin = new System.Windows.Forms.Padding(6);
            this.txPantalla.Name = "txPantalla";
            this.txPantalla.Size = new System.Drawing.Size(312, 37);
            this.txPantalla.TabIndex = 1;
            this.txPantalla.TabStop = false;
            // 
            // btC
            // 
            this.btC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btC.Location = new System.Drawing.Point(180, 76);
            this.btC.Margin = new System.Windows.Forms.Padding(6);
            this.btC.Name = "btC";
            this.btC.Size = new System.Drawing.Size(70, 75);
            this.btC.TabIndex = 3;
            this.btC.TabStop = false;
            this.btC.Text = "C";
            this.btC.UseVisualStyleBackColor = true;
            this.btC.Click += new System.EventHandler(this.btC_Click);
            // 
            // btBorrar
            // 
            this.btBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBorrar.Location = new System.Drawing.Point(262, 76);
            this.btBorrar.Margin = new System.Windows.Forms.Padding(6);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(70, 75);
            this.btBorrar.TabIndex = 4;
            this.btBorrar.TabStop = false;
            this.btBorrar.Text = "<<";
            this.btBorrar.UseVisualStyleBackColor = true;
            this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // bt9
            // 
            this.bt9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt9.Location = new System.Drawing.Point(180, 163);
            this.bt9.Margin = new System.Windows.Forms.Padding(6);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(70, 75);
            this.bt9.TabIndex = 7;
            this.bt9.TabStop = false;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = true;
            this.bt9.Click += new System.EventHandler(this.bt9_Click);
            // 
            // bt8
            // 
            this.bt8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt8.Location = new System.Drawing.Point(98, 163);
            this.bt8.Margin = new System.Windows.Forms.Padding(6);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(70, 75);
            this.bt8.TabIndex = 6;
            this.bt8.TabStop = false;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = true;
            this.bt8.Click += new System.EventHandler(this.bt8_Click);
            // 
            // bt7
            // 
            this.bt7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt7.Location = new System.Drawing.Point(16, 163);
            this.bt7.Margin = new System.Windows.Forms.Padding(6);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(70, 75);
            this.bt7.TabIndex = 5;
            this.bt7.TabStop = false;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = true;
            this.bt7.Click += new System.EventHandler(this.bt7_Click);
            // 
            // bt6
            // 
            this.bt6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt6.Location = new System.Drawing.Point(180, 250);
            this.bt6.Margin = new System.Windows.Forms.Padding(6);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(70, 75);
            this.bt6.TabIndex = 10;
            this.bt6.TabStop = false;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = true;
            this.bt6.Click += new System.EventHandler(this.bt6_Click);
            // 
            // bt5
            // 
            this.bt5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt5.Location = new System.Drawing.Point(98, 250);
            this.bt5.Margin = new System.Windows.Forms.Padding(6);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(70, 75);
            this.bt5.TabIndex = 9;
            this.bt5.TabStop = false;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.bt5_Click);
            // 
            // bt4
            // 
            this.bt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt4.Location = new System.Drawing.Point(16, 250);
            this.bt4.Margin = new System.Windows.Forms.Padding(6);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(70, 75);
            this.bt4.TabIndex = 8;
            this.bt4.TabStop = false;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.bt4_Click);
            // 
            // bt3
            // 
            this.bt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt3.Location = new System.Drawing.Point(180, 337);
            this.bt3.Margin = new System.Windows.Forms.Padding(6);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(70, 75);
            this.bt3.TabIndex = 13;
            this.bt3.TabStop = false;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // bt2
            // 
            this.bt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2.Location = new System.Drawing.Point(98, 337);
            this.bt2.Margin = new System.Windows.Forms.Padding(6);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(70, 75);
            this.bt2.TabIndex = 12;
            this.bt2.TabStop = false;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // bt1
            // 
            this.bt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt1.Location = new System.Drawing.Point(16, 337);
            this.bt1.Margin = new System.Windows.Forms.Padding(6);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(70, 75);
            this.bt1.TabIndex = 11;
            this.bt1.TabStop = false;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt0
            // 
            this.bt0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt0.Location = new System.Drawing.Point(98, 424);
            this.bt0.Margin = new System.Windows.Forms.Padding(6);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(70, 75);
            this.bt0.TabIndex = 14;
            this.bt0.TabStop = false;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = true;
            this.bt0.Click += new System.EventHandler(this.bt0_Click);
            // 
            // btDividir
            // 
            this.btDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDividir.Location = new System.Drawing.Point(262, 163);
            this.btDividir.Margin = new System.Windows.Forms.Padding(6);
            this.btDividir.Name = "btDividir";
            this.btDividir.Size = new System.Drawing.Size(70, 75);
            this.btDividir.TabIndex = 15;
            this.btDividir.TabStop = false;
            this.btDividir.Text = "/";
            this.btDividir.UseVisualStyleBackColor = true;
            this.btDividir.Click += new System.EventHandler(this.btDividir_Click);
            // 
            // btMultiplicar
            // 
            this.btMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMultiplicar.Location = new System.Drawing.Point(262, 250);
            this.btMultiplicar.Margin = new System.Windows.Forms.Padding(6);
            this.btMultiplicar.Name = "btMultiplicar";
            this.btMultiplicar.Size = new System.Drawing.Size(70, 75);
            this.btMultiplicar.TabIndex = 16;
            this.btMultiplicar.TabStop = false;
            this.btMultiplicar.Text = "X";
            this.btMultiplicar.UseVisualStyleBackColor = true;
            this.btMultiplicar.Click += new System.EventHandler(this.btMultiplicar_Click);
            // 
            // btMes
            // 
            this.btMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMes.Location = new System.Drawing.Point(262, 424);
            this.btMes.Margin = new System.Windows.Forms.Padding(6);
            this.btMes.Name = "btMes";
            this.btMes.Size = new System.Drawing.Size(70, 75);
            this.btMes.TabIndex = 17;
            this.btMes.TabStop = false;
            this.btMes.Text = "+";
            this.btMes.UseVisualStyleBackColor = true;
            this.btMes.Click += new System.EventHandler(this.btMes_Click);
            // 
            // btRestar
            // 
            this.btRestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRestar.Location = new System.Drawing.Point(262, 337);
            this.btRestar.Margin = new System.Windows.Forms.Padding(6);
            this.btRestar.Name = "btRestar";
            this.btRestar.Size = new System.Drawing.Size(70, 75);
            this.btRestar.TabIndex = 18;
            this.btRestar.TabStop = false;
            this.btRestar.Text = "-";
            this.btRestar.UseVisualStyleBackColor = true;
            this.btRestar.Click += new System.EventHandler(this.btRestar_Click);
            // 
            // btComa
            // 
            this.btComa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btComa.Location = new System.Drawing.Point(16, 424);
            this.btComa.Margin = new System.Windows.Forms.Padding(6);
            this.btComa.Name = "btComa";
            this.btComa.Size = new System.Drawing.Size(70, 75);
            this.btComa.TabIndex = 22;
            this.btComa.TabStop = false;
            this.btComa.Text = ",";
            this.btComa.UseVisualStyleBackColor = true;
            this.btComa.Click += new System.EventHandler(this.btComa_Click);
            // 
            // btIgual
            // 
            this.btIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIgual.Location = new System.Drawing.Point(180, 424);
            this.btIgual.Margin = new System.Windows.Forms.Padding(6);
            this.btIgual.Name = "btIgual";
            this.btIgual.Size = new System.Drawing.Size(70, 75);
            this.btIgual.TabIndex = 23;
            this.btIgual.TabStop = false;
            this.btIgual.Text = "=";
            this.btIgual.UseVisualStyleBackColor = true;
            this.btIgual.Click += new System.EventHandler(this.btIgual_Click);
            // 
            // btCanviSigne
            // 
            this.btCanviSigne.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCanviSigne.Location = new System.Drawing.Point(98, 76);
            this.btCanviSigne.Margin = new System.Windows.Forms.Padding(6);
            this.btCanviSigne.Name = "btCanviSigne";
            this.btCanviSigne.Size = new System.Drawing.Size(70, 75);
            this.btCanviSigne.TabIndex = 24;
            this.btCanviSigne.TabStop = false;
            this.btCanviSigne.Text = "+/-";
            this.btCanviSigne.UseVisualStyleBackColor = true;
            this.btCanviSigne.Click += new System.EventHandler(this.btCanviSigne_Click);
            // 
            // txHistorial
            // 
            this.txHistorial.Location = new System.Drawing.Point(344, 26);
            this.txHistorial.Margin = new System.Windows.Forms.Padding(6);
            this.txHistorial.Multiline = true;
            this.txHistorial.Name = "txHistorial";
            this.txHistorial.Size = new System.Drawing.Size(312, 473);
            this.txHistorial.TabIndex = 25;
            this.txHistorial.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 633);
            this.Controls.Add(this.txHistorial);
            this.Controls.Add(this.btCanviSigne);
            this.Controls.Add(this.btIgual);
            this.Controls.Add(this.btComa);
            this.Controls.Add(this.btRestar);
            this.Controls.Add(this.btMes);
            this.Controls.Add(this.btMultiplicar);
            this.Controls.Add(this.btDividir);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt7);
            this.Controls.Add(this.btBorrar);
            this.Controls.Add(this.btC);
            this.Controls.Add(this.txPantalla);
            this.Controls.Add(this.bt100);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "%";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt100;
        private System.Windows.Forms.TextBox txPantalla;
        private System.Windows.Forms.Button btC;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button btDividir;
        private System.Windows.Forms.Button btMultiplicar;
        private System.Windows.Forms.Button btMes;
        private System.Windows.Forms.Button btRestar;
        private System.Windows.Forms.Button btComa;
        private System.Windows.Forms.Button btIgual;
        private System.Windows.Forms.Button btCanviSigne;
        private System.Windows.Forms.TextBox txHistorial;
    }
}

