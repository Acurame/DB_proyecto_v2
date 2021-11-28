namespace UI.productos
{
    partial class crearTipo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.btn_canselar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 5);
            this.panel1.TabIndex = 1;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(54, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.panel2.Location = new System.Drawing.Point(154, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 5);
            this.panel2.TabIndex = 18;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(154, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 22);
            this.textBox1.TabIndex = 17;
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ingresar.ForeColor = System.Drawing.Color.White;
            this.btn_ingresar.Image = global::UI.Properties.Resources.caja_del_paquete;
            this.btn_ingresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ingresar.Location = new System.Drawing.Point(20, 123);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btn_ingresar.Size = new System.Drawing.Size(176, 50);
            this.btn_ingresar.TabIndex = 20;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ingresar.UseVisualStyleBackColor = true;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // btn_canselar
            // 
            this.btn_canselar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_canselar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_canselar.ForeColor = System.Drawing.Color.White;
            this.btn_canselar.Image = global::UI.Properties.Resources.close;
            this.btn_canselar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_canselar.Location = new System.Drawing.Point(226, 123);
            this.btn_canselar.Name = "btn_canselar";
            this.btn_canselar.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btn_canselar.Size = new System.Drawing.Size(176, 50);
            this.btn_canselar.TabIndex = 21;
            this.btn_canselar.Text = "Canselar";
            this.btn_canselar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_canselar.UseVisualStyleBackColor = true;
            this.btn_canselar.Click += new System.EventHandler(this.btn_canselar_Click);
            // 
            // crearTipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(425, 207);
            this.Controls.Add(this.btn_canselar);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "crearTipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "crearTipo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_ingresar;
        private System.Windows.Forms.Button btn_canselar;
    }
}