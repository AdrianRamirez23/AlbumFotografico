
namespace AlbumFotografico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Directorio = new System.Windows.Forms.TabControl();
            this.tabDirectorio = new System.Windows.Forms.TabPage();
            this.btnRetro = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtImagen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picDir = new System.Windows.Forms.PictureBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabGestion = new System.Windows.Forms.TabPage();
            this.Directorio.SuspendLayout();
            this.tabDirectorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDir)).BeginInit();
            this.SuspendLayout();
            // 
            // Directorio
            // 
            this.Directorio.Controls.Add(this.tabDirectorio);
            this.Directorio.Controls.Add(this.tabGestion);
            this.Directorio.Location = new System.Drawing.Point(0, 1);
            this.Directorio.Name = "Directorio";
            this.Directorio.SelectedIndex = 0;
            this.Directorio.Size = new System.Drawing.Size(798, 448);
            this.Directorio.TabIndex = 0;
            // 
            // tabDirectorio
            // 
            this.tabDirectorio.Controls.Add(this.btnRetro);
            this.tabDirectorio.Controls.Add(this.button2);
            this.tabDirectorio.Controls.Add(this.label6);
            this.tabDirectorio.Controls.Add(this.label5);
            this.tabDirectorio.Controls.Add(this.txtImagen);
            this.tabDirectorio.Controls.Add(this.label4);
            this.tabDirectorio.Controls.Add(this.textBox4);
            this.tabDirectorio.Controls.Add(this.label3);
            this.tabDirectorio.Controls.Add(this.textBox3);
            this.tabDirectorio.Controls.Add(this.textBox2);
            this.tabDirectorio.Controls.Add(this.label2);
            this.tabDirectorio.Controls.Add(this.label1);
            this.tabDirectorio.Controls.Add(this.picDir);
            this.tabDirectorio.Controls.Add(this.btnBuscar);
            this.tabDirectorio.Controls.Add(this.textBox1);
            this.tabDirectorio.Location = new System.Drawing.Point(4, 22);
            this.tabDirectorio.Name = "tabDirectorio";
            this.tabDirectorio.Padding = new System.Windows.Forms.Padding(3);
            this.tabDirectorio.Size = new System.Drawing.Size(790, 422);
            this.tabDirectorio.TabIndex = 0;
            this.tabDirectorio.Text = "Directorio";
            this.tabDirectorio.UseVisualStyleBackColor = true;
            // 
            // btnRetro
            // 
            this.btnRetro.Image = ((System.Drawing.Image)(resources.GetObject("btnRetro.Image")));
            this.btnRetro.Location = new System.Drawing.Point(344, 328);
            this.btnRetro.Name = "btnRetro";
            this.btnRetro.Size = new System.Drawing.Size(75, 34);
            this.btnRetro.TabIndex = 14;
            this.btnRetro.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(271, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 34);
            this.button2.TabIndex = 13;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(425, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Retroceder";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Avanzar";
            // 
            // txtImagen
            // 
            this.txtImagen.Location = new System.Drawing.Point(509, 270);
            this.txtImagen.Multiline = true;
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.Size = new System.Drawing.Size(208, 59);
            this.txtImagen.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(506, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Descripción de la Imágen";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(175, 183);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(176, 106);
            this.textBox4.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Descripción del Lugar";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(175, 129);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(176, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(175, 78);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(176, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lugar del Evento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha del Evento";
            // 
            // picDir
            // 
            this.picDir.Location = new System.Drawing.Point(509, 50);
            this.picDir.Name = "picDir";
            this.picDir.Size = new System.Drawing.Size(237, 192);
            this.picDir.TabIndex = 2;
            this.picDir.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(671, 21);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(374, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(275, 20);
            this.textBox1.TabIndex = 0;
            // 
            // tabGestion
            // 
            this.tabGestion.Location = new System.Drawing.Point(4, 22);
            this.tabGestion.Name = "tabGestion";
            this.tabGestion.Padding = new System.Windows.Forms.Padding(3);
            this.tabGestion.Size = new System.Drawing.Size(790, 422);
            this.tabGestion.TabIndex = 1;
            this.tabGestion.Text = "Gestion";
            this.tabGestion.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 411);
            this.Controls.Add(this.Directorio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Directorio.ResumeLayout(false);
            this.tabDirectorio.ResumeLayout(false);
            this.tabDirectorio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Directorio;
        private System.Windows.Forms.TabPage tabDirectorio;
        private System.Windows.Forms.TabPage tabGestion;
        private System.Windows.Forms.PictureBox picDir;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnRetro;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtImagen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

