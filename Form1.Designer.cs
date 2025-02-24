namespace bai13_TInhcanchii
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstNam = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kết Quả:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Năm:";
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(209, 145);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(159, 26);
            this.txtNam.TabIndex = 1;
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(209, 218);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(159, 26);
            this.txtKQ.TabIndex = 1;
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(401, 138);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(75, 34);
            this.btnTinh.TabIndex = 2;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(401, 210);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 34);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstNam
            // 
            this.lstNam.FormattingEnabled = true;
            this.lstNam.ItemHeight = 20;
            this.lstNam.Location = new System.Drawing.Point(537, 105);
            this.lstNam.Name = "lstNam";
            this.lstNam.Size = new System.Drawing.Size(229, 284);
            this.lstNam.TabIndex = 3;
            this.lstNam.SelectedIndexChanged += new System.EventHandler(this.lstNam_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.lstNam);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstNam;
    }
}

