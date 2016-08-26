namespace slotmachine
{
    partial class db_rezult
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
            this.urscore_lbl = new System.Windows.Forms.Label();
            this.result_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // urscore_lbl
            // 
            this.urscore_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.urscore_lbl.AutoSize = true;
            this.urscore_lbl.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urscore_lbl.Location = new System.Drawing.Point(13, 2);
            this.urscore_lbl.Name = "urscore_lbl";
            this.urscore_lbl.Size = new System.Drawing.Size(272, 59);
            this.urscore_lbl.TabIndex = 1;
            this.urscore_lbl.Text = "tavs rezultāts: ";
            this.urscore_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // result_lbl
            // 
            this.result_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.result_lbl.AutoSize = true;
            this.result_lbl.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_lbl.Location = new System.Drawing.Point(291, 2);
            this.result_lbl.Name = "result_lbl";
            this.result_lbl.Size = new System.Drawing.Size(46, 59);
            this.result_lbl.TabIndex = 2;
            this.result_lbl.Text = "0";
            this.result_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 59);
            this.label1.TabIndex = 3;
            this.label1.Text = "ievadi vardu: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // name_txt
            // 
            this.name_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.name_txt.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_txt.Location = new System.Drawing.Point(235, 83);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(228, 65);
            this.name_txt.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(387, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "pievienot";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // db_rezult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 226);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.result_lbl);
            this.Controls.Add(this.urscore_lbl);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "db_rezult";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label urscore_lbl;
        private System.Windows.Forms.Label result_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.Button button1;
    }
}