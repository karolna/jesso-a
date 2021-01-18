namespace Computacion_Cientifica
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
            this.encenderPixel = new System.Windows.Forms.Button();
            this.Plano = new System.Windows.Forms.PictureBox();
            this.Prueba = new System.Windows.Forms.Button();
            this.Prueba2 = new System.Windows.Forms.Button();
            this.segmento = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Plano)).BeginInit();
            this.SuspendLayout();
            // 
            // encenderPixel
            // 
            this.encenderPixel.Location = new System.Drawing.Point(12, 498);
            this.encenderPixel.Name = "encenderPixel";
            this.encenderPixel.Size = new System.Drawing.Size(96, 23);
            this.encenderPixel.TabIndex = 0;
            this.encenderPixel.Text = "Encender Pixel";
            this.encenderPixel.UseVisualStyleBackColor = true;
            this.encenderPixel.Click += new System.EventHandler(this.encenderPixel_Click);
            // 
            // Plano
            // 
            this.Plano.BackColor = System.Drawing.SystemColors.Info;
            this.Plano.Location = new System.Drawing.Point(12, 12);
            this.Plano.Name = "Plano";
            this.Plano.Size = new System.Drawing.Size(640, 480);
            this.Plano.TabIndex = 1;
            this.Plano.TabStop = false;
            this.Plano.Click += new System.EventHandler(this.Plano_Click);
            // 
            // Prueba
            // 
            this.Prueba.Location = new System.Drawing.Point(114, 498);
            this.Prueba.Name = "Prueba";
            this.Prueba.Size = new System.Drawing.Size(75, 23);
            this.Prueba.TabIndex = 2;
            this.Prueba.Text = "Franjas";
            this.Prueba.UseVisualStyleBackColor = true;
            this.Prueba.Click += new System.EventHandler(this.Prueba_Click);
            // 
            // Prueba2
            // 
            this.Prueba2.Location = new System.Drawing.Point(195, 498);
            this.Prueba2.Name = "Prueba2";
            this.Prueba2.Size = new System.Drawing.Size(75, 23);
            this.Prueba2.TabIndex = 2;
            this.Prueba2.Text = "Puntos";
            this.Prueba2.UseVisualStyleBackColor = true;
            this.Prueba2.Click += new System.EventHandler(this.Prueba2_Click);
            // 
            // segmento
            // 
            this.segmento.Location = new System.Drawing.Point(276, 498);
            this.segmento.Name = "segmento";
            this.segmento.Size = new System.Drawing.Size(75, 23);
            this.segmento.TabIndex = 2;
            this.segmento.Text = "Segmento";
            this.segmento.UseVisualStyleBackColor = true;
            this.segmento.Click += new System.EventHandler(this.Segmento);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(357, 498);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "Tarea Segmentos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.SegmentosTarea);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(664, 555);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.segmento);
            this.Controls.Add(this.Prueba2);
            this.Controls.Add(this.Prueba);
            this.Controls.Add(this.Plano);
            this.Controls.Add(this.encenderPixel);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Jesenia Oña (6980)";
            ((System.ComponentModel.ISupportInitialize)(this.Plano)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button encenderPixel;
        private System.Windows.Forms.PictureBox Plano;
        private System.Windows.Forms.Button Prueba;
        private System.Windows.Forms.Button Prueba2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button segmento;
        private System.Windows.Forms.Button button2;
    }
}

