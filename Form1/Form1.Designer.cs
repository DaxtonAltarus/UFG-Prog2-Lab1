
namespace Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtfrase = new System.Windows.Forms.TextBox();
            this.txtcaracteres = new System.Windows.Forms.TextBox();
            this.txtvocales = new System.Windows.Forms.TextBox();
            this.txtconsonantes = new System.Windows.Forms.TextBox();
            this.txtpalabras = new System.Windows.Forms.TextBox();
            this.cmdtamaño = new System.Windows.Forms.Button();
            this.cmdnumvocales = new System.Windows.Forms.Button();
            this.cmdnumconso = new System.Windows.Forms.Button();
            this.cmdnumpalabras = new System.Windows.Forms.Button();
            this.cmdlimpiar = new System.Windows.Forms.Button();
            this.cmdsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "FRASE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "TOTAL DE CARÁCTERES";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "VOCALES";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "CONSONANTES";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "PALABRAS";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtfrase
            // 
            this.txtfrase.Location = new System.Drawing.Point(76, 29);
            this.txtfrase.Name = "txtfrase";
            this.txtfrase.Size = new System.Drawing.Size(355, 23);
            this.txtfrase.TabIndex = 5;
            // 
            // txtcaracteres
            // 
            this.txtcaracteres.Location = new System.Drawing.Point(173, 91);
            this.txtcaracteres.Name = "txtcaracteres";
            this.txtcaracteres.Size = new System.Drawing.Size(118, 23);
            this.txtcaracteres.TabIndex = 6;
            // 
            // txtvocales
            // 
            this.txtvocales.Location = new System.Drawing.Point(173, 123);
            this.txtvocales.Name = "txtvocales";
            this.txtvocales.Size = new System.Drawing.Size(118, 23);
            this.txtvocales.TabIndex = 7;
            // 
            // txtconsonantes
            // 
            this.txtconsonantes.Location = new System.Drawing.Point(173, 155);
            this.txtconsonantes.Name = "txtconsonantes";
            this.txtconsonantes.Size = new System.Drawing.Size(118, 23);
            this.txtconsonantes.TabIndex = 8;
            // 
            // txtpalabras
            // 
            this.txtpalabras.Location = new System.Drawing.Point(173, 191);
            this.txtpalabras.Name = "txtpalabras";
            this.txtpalabras.Size = new System.Drawing.Size(118, 23);
            this.txtpalabras.TabIndex = 9;
            // 
            // cmdtamaño
            // 
            this.cmdtamaño.Location = new System.Drawing.Point(302, 91);
            this.cmdtamaño.Name = "cmdtamaño";
            this.cmdtamaño.Size = new System.Drawing.Size(58, 22);
            this.cmdtamaño.TabIndex = 10;
            this.cmdtamaño.Text = "<--";
            this.cmdtamaño.UseVisualStyleBackColor = true;
            this.cmdtamaño.Click += new System.EventHandler(this.cmdtamaño_Click);
            // 
            // cmdnumvocales
            // 
            this.cmdnumvocales.Location = new System.Drawing.Point(302, 124);
            this.cmdnumvocales.Name = "cmdnumvocales";
            this.cmdnumvocales.Size = new System.Drawing.Size(58, 22);
            this.cmdnumvocales.TabIndex = 11;
            this.cmdnumvocales.Text = "<--";
            this.cmdnumvocales.UseVisualStyleBackColor = true;
            this.cmdnumvocales.Click += new System.EventHandler(this.cmdnumvocales_Click);
            // 
            // cmdnumconso
            // 
            this.cmdnumconso.Location = new System.Drawing.Point(302, 156);
            this.cmdnumconso.Name = "cmdnumconso";
            this.cmdnumconso.Size = new System.Drawing.Size(58, 22);
            this.cmdnumconso.TabIndex = 12;
            this.cmdnumconso.Text = "<--";
            this.cmdnumconso.UseVisualStyleBackColor = true;
            this.cmdnumconso.Click += new System.EventHandler(this.cmdnumconso_Click);
            // 
            // cmdnumpalabras
            // 
            this.cmdnumpalabras.Location = new System.Drawing.Point(302, 190);
            this.cmdnumpalabras.Name = "cmdnumpalabras";
            this.cmdnumpalabras.Size = new System.Drawing.Size(58, 22);
            this.cmdnumpalabras.TabIndex = 13;
            this.cmdnumpalabras.Text = "<--";
            this.cmdnumpalabras.UseVisualStyleBackColor = true;
            this.cmdnumpalabras.Click += new System.EventHandler(this.cmdnumpalabras_Click);
            // 
            // cmdlimpiar
            // 
            this.cmdlimpiar.Location = new System.Drawing.Point(57, 255);
            this.cmdlimpiar.Name = "cmdlimpiar";
            this.cmdlimpiar.Size = new System.Drawing.Size(125, 30);
            this.cmdlimpiar.TabIndex = 14;
            this.cmdlimpiar.Text = "REINICIAR";
            this.cmdlimpiar.UseVisualStyleBackColor = true;
            this.cmdlimpiar.Click += new System.EventHandler(this.cmdlimpiar_Click);
            // 
            // cmdsalir
            // 
            this.cmdsalir.Location = new System.Drawing.Point(259, 255);
            this.cmdsalir.Name = "cmdsalir";
            this.cmdsalir.Size = new System.Drawing.Size(125, 30);
            this.cmdsalir.TabIndex = 15;
            this.cmdsalir.Text = "SALIR";
            this.cmdsalir.UseVisualStyleBackColor = true;
            this.cmdsalir.Click += new System.EventHandler(this.cmdsalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 314);
            this.Controls.Add(this.cmdsalir);
            this.Controls.Add(this.cmdlimpiar);
            this.Controls.Add(this.cmdnumpalabras);
            this.Controls.Add(this.cmdnumconso);
            this.Controls.Add(this.cmdnumvocales);
            this.Controls.Add(this.cmdtamaño);
            this.Controls.Add(this.txtpalabras);
            this.Controls.Add(this.txtconsonantes);
            this.Controls.Add(this.txtvocales);
            this.Controls.Add(this.txtcaracteres);
            this.Controls.Add(this.txtfrase);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtfrase;
        private System.Windows.Forms.TextBox txtcaracteres;
        private System.Windows.Forms.TextBox txtvocales;
        private System.Windows.Forms.TextBox txtconsonantes;
        private System.Windows.Forms.TextBox txtpalabras;
        private System.Windows.Forms.Button cmdtamaño;
        private System.Windows.Forms.Button cmdnumvocales;
        private System.Windows.Forms.Button cmdnumconso;
        private System.Windows.Forms.Button cmdnumpalabras;
        private System.Windows.Forms.Button cmdlimpiar;
        private System.Windows.Forms.Button cmdsalir;
    }
}

