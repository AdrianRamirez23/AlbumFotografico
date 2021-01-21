
namespace AlbumFotografico
{
    partial class EventoBuscar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFechEvn = new System.Windows.Forms.TextBox();
            this.txtResDesEve = new System.Windows.Forms.TextBox();
            this.btnElegir = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resultado de la búsqueda";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(27, 52);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(112, 20);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "Fecha Evento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(145, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripción Evento:";
            // 
            // txtFechEvn
            // 
            this.txtFechEvn.Location = new System.Drawing.Point(31, 76);
            this.txtFechEvn.Name = "txtFechEvn";
            this.txtFechEvn.Size = new System.Drawing.Size(100, 20);
            this.txtFechEvn.TabIndex = 3;
            // 
            // txtResDesEve
            // 
            this.txtResDesEve.Location = new System.Drawing.Point(149, 75);
            this.txtResDesEve.Multiline = true;
            this.txtResDesEve.Name = "txtResDesEve";
            this.txtResDesEve.Size = new System.Drawing.Size(146, 55);
            this.txtResDesEve.TabIndex = 4;
            // 
            // btnElegir
            // 
            this.btnElegir.Location = new System.Drawing.Point(315, 76);
            this.btnElegir.Name = "btnElegir";
            this.btnElegir.Size = new System.Drawing.Size(75, 23);
            this.btnElegir.TabIndex = 5;
            this.btnElegir.Text = "Elegir";
            this.btnElegir.UseVisualStyleBackColor = true;
            this.btnElegir.Click += new System.EventHandler(this.btnElegir_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(315, 107);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 6;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // EventoBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 142);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnElegir);
            this.Controls.Add(this.txtResDesEve);
            this.Controls.Add(this.txtFechEvn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.label1);
            this.Name = "EventoBuscar";
            this.Text = "EventoBuscar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnElegir;
        private System.Windows.Forms.Button btnRegresar;
        public System.Windows.Forms.TextBox txtFechEvn;
        public System.Windows.Forms.TextBox txtResDesEve;
    }
}