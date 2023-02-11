namespace IParcial
{
    partial class Ejercicio
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
            this.PromedioAsincronaButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NotaIPTextBox = new System.Windows.Forms.TextBox();
            this.NotaIIPTextBox = new System.Windows.Forms.TextBox();
            this.NotaIIIPTextBox = new System.Windows.Forms.TextBox();
            this.NotaIVPTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PromedioAsincronaButton
            // 
            this.PromedioAsincronaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PromedioAsincronaButton.Location = new System.Drawing.Point(458, 108);
            this.PromedioAsincronaButton.Name = "PromedioAsincronaButton";
            this.PromedioAsincronaButton.Size = new System.Drawing.Size(140, 60);
            this.PromedioAsincronaButton.TabIndex = 0;
            this.PromedioAsincronaButton.Text = "Calcular Promedio";
            this.PromedioAsincronaButton.UseVisualStyleBackColor = true;
            this.PromedioAsincronaButton.Click += new System.EventHandler(this.PromedioAsincronaButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nota I Parcial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nota II Parcial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nota III Parcial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nota IV Parcial";
            // 
            // NotaIPTextBox
            // 
            this.NotaIPTextBox.Location = new System.Drawing.Point(205, 44);
            this.NotaIPTextBox.Name = "NotaIPTextBox";
            this.NotaIPTextBox.Size = new System.Drawing.Size(113, 20);
            this.NotaIPTextBox.TabIndex = 2;
            // 
            // NotaIIPTextBox
            // 
            this.NotaIIPTextBox.Location = new System.Drawing.Point(205, 83);
            this.NotaIIPTextBox.Name = "NotaIIPTextBox";
            this.NotaIIPTextBox.Size = new System.Drawing.Size(113, 20);
            this.NotaIIPTextBox.TabIndex = 2;
            // 
            // NotaIIIPTextBox
            // 
            this.NotaIIIPTextBox.Location = new System.Drawing.Point(205, 124);
            this.NotaIIIPTextBox.Name = "NotaIIIPTextBox";
            this.NotaIIIPTextBox.Size = new System.Drawing.Size(113, 20);
            this.NotaIIIPTextBox.TabIndex = 2;
            // 
            // NotaIVPTextBox
            // 
            this.NotaIVPTextBox.Location = new System.Drawing.Point(205, 170);
            this.NotaIVPTextBox.Name = "NotaIVPTextBox";
            this.NotaIVPTextBox.Size = new System.Drawing.Size(113, 20);
            this.NotaIVPTextBox.TabIndex = 2;
            // 
            // Ejercicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 423);
            this.Controls.Add(this.NotaIIIPTextBox);
            this.Controls.Add(this.NotaIVPTextBox);
            this.Controls.Add(this.NotaIIPTextBox);
            this.Controls.Add(this.NotaIPTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PromedioAsincronaButton);
            this.Name = "Ejercicio";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PromedioAsincronaButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NotaIPTextBox;
        private System.Windows.Forms.TextBox NotaIIPTextBox;
        private System.Windows.Forms.TextBox NotaIIIPTextBox;
        private System.Windows.Forms.TextBox NotaIVPTextBox;
    }
}

