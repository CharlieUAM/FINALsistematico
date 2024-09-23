namespace ExamenFinal
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbnames = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tblastnames = new System.Windows.Forms.TextBox();
            this.DTPborn = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.CBcity = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnaddNm = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Calcedadresul = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro De Edades - CERL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombres:";
            // 
            // tbnames
            // 
            this.tbnames.Location = new System.Drawing.Point(85, 51);
            this.tbnames.Name = "tbnames";
            this.tbnames.Size = new System.Drawing.Size(214, 20);
            this.tbnames.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellido:";
            // 
            // tblastnames
            // 
            this.tblastnames.Location = new System.Drawing.Point(85, 83);
            this.tblastnames.Name = "tblastnames";
            this.tblastnames.Size = new System.Drawing.Size(214, 20);
            this.tblastnames.TabIndex = 4;
            // 
            // DTPborn
            // 
            this.DTPborn.Location = new System.Drawing.Point(147, 122);
            this.DTPborn.Name = "DTPborn";
            this.DTPborn.Size = new System.Drawing.Size(214, 20);
            this.DTPborn.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha de Nacimiento:";
            // 
            // CBcity
            // 
            this.CBcity.FormattingEnabled = true;
            this.CBcity.Items.AddRange(new object[] {
            "Managua",
            "Masaya",
            "Leon",
            "Granada",
            "Matagalpa"});
            this.CBcity.Location = new System.Drawing.Point(85, 160);
            this.CBcity.Name = "CBcity";
            this.CBcity.Size = new System.Drawing.Size(121, 21);
            this.CBcity.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "ciudad:";
            // 
            // BtnaddNm
            // 
            this.BtnaddNm.Location = new System.Drawing.Point(326, 51);
            this.BtnaddNm.Name = "BtnaddNm";
            this.BtnaddNm.Size = new System.Drawing.Size(75, 23);
            this.BtnaddNm.TabIndex = 9;
            this.BtnaddNm.Text = "add";
            this.BtnaddNm.UseVisualStyleBackColor = true;
            this.BtnaddNm.Click += new System.EventHandler(this.BtnaddNm_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(326, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(393, 128);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "add";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(268, 157);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "add";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(652, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "calcular edad";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Calcedadresul
            // 
            this.Calcedadresul.AutoSize = true;
            this.Calcedadresul.Location = new System.Drawing.Point(672, 86);
            this.Calcedadresul.Name = "Calcedadresul";
            this.Calcedadresul.Size = new System.Drawing.Size(35, 13);
            this.Calcedadresul.TabIndex = 14;
            this.Calcedadresul.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Calcedadresul);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnaddNm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CBcity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DTPborn);
            this.Controls.Add(this.tblastnames);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbnames);
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
        private System.Windows.Forms.TextBox tbnames;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tblastnames;
        private System.Windows.Forms.DateTimePicker DTPborn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBcity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnaddNm;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Calcedadresul;
    }
}

