namespace TablaDeMultiplication
{
    partial class Form1
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
            this.txtingreseelnumero = new System.Windows.Forms.Label();
            this.txtingresenum = new System.Windows.Forms.TextBox();
            this.imprimirbut = new System.Windows.Forms.Button();
            this.lbTabla = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Multiplication Table";
            // 
            // txtingreseelnumero
            // 
            this.txtingreseelnumero.AutoSize = true;
            this.txtingreseelnumero.Location = new System.Drawing.Point(97, 45);
            this.txtingreseelnumero.Name = "txtingreseelnumero";
            this.txtingreseelnumero.Size = new System.Drawing.Size(80, 13);
            this.txtingreseelnumero.TabIndex = 1;
            this.txtingreseelnumero.Text = "Insert a number";
            // 
            // txtingresenum
            // 
            this.txtingresenum.Location = new System.Drawing.Point(91, 61);
            this.txtingresenum.Name = "txtingresenum";
            this.txtingresenum.Size = new System.Drawing.Size(100, 20);
            this.txtingresenum.TabIndex = 2;
            // 
            // imprimirbut
            // 
            this.imprimirbut.Location = new System.Drawing.Point(100, 129);
            this.imprimirbut.Name = "imprimirbut";
            this.imprimirbut.Size = new System.Drawing.Size(75, 23);
            this.imprimirbut.TabIndex = 3;
            this.imprimirbut.Text = "Show!";
            this.imprimirbut.UseVisualStyleBackColor = true;
            this.imprimirbut.Click += new System.EventHandler(this.imprimirbut_Click);
            // 
            // lbTabla
            // 
            this.lbTabla.FormattingEnabled = true;
            this.lbTabla.Location = new System.Drawing.Point(42, 154);
            this.lbTabla.Name = "lbTabla";
            this.lbTabla.Size = new System.Drawing.Size(196, 95);
            this.lbTabla.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbTabla);
            this.Controls.Add(this.imprimirbut);
            this.Controls.Add(this.txtingresenum);
            this.Controls.Add(this.txtingreseelnumero);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Multiplication Table";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtingreseelnumero;
        private System.Windows.Forms.TextBox txtingresenum;
        private System.Windows.Forms.Button imprimirbut;
        private System.Windows.Forms.ListBox lbTabla;
    }
}

