namespace UI.Abastecimiento
{
    partial class Crear_Abasto
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
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.btn_canselar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(655, 5);
            this.panel8.TabIndex = 27;
            this.panel8.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel8_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.panel1.Location = new System.Drawing.Point(151, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 5);
            this.panel1.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Proveedor";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.panel2.Location = new System.Drawing.Point(151, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 5);
            this.panel2.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(38, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Producto";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.panel3.Location = new System.Drawing.Point(151, 184);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(233, 5);
            this.panel3.TabIndex = 33;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(151, 160);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 22);
            this.textBox1.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(38, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Unidades";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Administrador",
            "Gerente",
            "Resepcion",
            "Bodegero",
            "Inactivo"});
            this.comboBox1.Location = new System.Drawing.Point(151, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(233, 32);
            this.comboBox1.TabIndex = 45;
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.Color.White;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Administrador",
            "Gerente",
            "Resepcion",
            "Bodegero",
            "Inactivo"});
            this.comboBox2.Location = new System.Drawing.Point(151, 93);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(233, 32);
            this.comboBox2.TabIndex = 46;
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ingresar.ForeColor = System.Drawing.Color.White;
            this.btn_ingresar.Image = global::UI.Properties.Resources.opinion_del_cliente2;
            this.btn_ingresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ingresar.Location = new System.Drawing.Point(441, 39);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btn_ingresar.Size = new System.Drawing.Size(176, 50);
            this.btn_ingresar.TabIndex = 47;
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
            this.btn_canselar.Location = new System.Drawing.Point(441, 130);
            this.btn_canselar.Name = "btn_canselar";
            this.btn_canselar.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btn_canselar.Size = new System.Drawing.Size(176, 50);
            this.btn_canselar.TabIndex = 48;
            this.btn_canselar.Text = "Canselar";
            this.btn_canselar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_canselar.UseVisualStyleBackColor = true;
            this.btn_canselar.Click += new System.EventHandler(this.btn_canselar_Click);
            // 
            // Crear_Abasto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(655, 246);
            this.Controls.Add(this.btn_canselar);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Crear_Abasto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear_Abasto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btn_ingresar;
        private System.Windows.Forms.Button btn_canselar;
    }
}