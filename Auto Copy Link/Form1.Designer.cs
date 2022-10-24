namespace Auto_Copy_Link
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
            this.txtLink = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNextCopy = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnPath = new System.Windows.Forms.Button();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(67, 95);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(321, 23);
            this.txtLink.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Link";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnNextCopy
            // 
            this.btnNextCopy.Location = new System.Drawing.Point(410, 94);
            this.btnNextCopy.Name = "btnNextCopy";
            this.btnNextCopy.Size = new System.Drawing.Size(108, 23);
            this.btnNextCopy.TabIndex = 2;
            this.btnNextCopy.Text = "Next and Copy";
            this.btnNextCopy.UseVisualStyleBackColor = true;
            this.btnNextCopy.Click += new System.EventHandler(this.btnNextCopy_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Path";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(67, 44);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(321, 23);
            this.txtPath.TabIndex = 4;
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(409, 43);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(109, 23);
            this.btnPath.TabIndex = 5;
            this.btnPath.Text = "Submit";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(67, 136);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(100, 23);
            this.txtPosition.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNextCopy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLink);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtLink;
        private Label label1;
        private Button btnNextCopy;
        private Label label2;
        private TextBox txtPath;
        private Button btnPath;
        private TextBox txtPosition;
    }
}