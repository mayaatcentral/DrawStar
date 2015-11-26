namespace WindowsFormsApplication1
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
            this.enterButton = new System.Windows.Forms.Button();
            this.sizeInput = new System.Windows.Forms.TextBox();
            this.yInput = new System.Windows.Forms.TextBox();
            this.xInput = new System.Windows.Forms.TextBox();
            this.xLabel = new System.Windows.Forms.Label();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(580, 140);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 0;
            this.enterButton.Text = "Draw Star";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // sizeInput
            // 
            this.sizeInput.Location = new System.Drawing.Point(565, 104);
            this.sizeInput.Name = "sizeInput";
            this.sizeInput.Size = new System.Drawing.Size(100, 20);
            this.sizeInput.TabIndex = 1;
            // 
            // yInput
            // 
            this.yInput.Location = new System.Drawing.Point(565, 65);
            this.yInput.Name = "yInput";
            this.yInput.Size = new System.Drawing.Size(100, 20);
            this.yInput.TabIndex = 2;
            // 
            // xInput
            // 
            this.xInput.Location = new System.Drawing.Point(565, 22);
            this.xInput.Name = "xInput";
            this.xInput.Size = new System.Drawing.Size(100, 20);
            this.xInput.TabIndex = 3;
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.xLabel.Location = new System.Drawing.Point(471, 25);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(88, 13);
            this.xLabel.TabIndex = 4;
            this.xLabel.Text = "X COORDINATE";
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sizeLabel.Location = new System.Drawing.Point(528, 111);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(31, 13);
            this.sizeLabel.TabIndex = 5;
            this.sizeLabel.Text = "SIZE";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.yLabel.Location = new System.Drawing.Point(471, 69);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(88, 13);
            this.yLabel.TabIndex = 6;
            this.yLabel.Text = "Y COORDINATE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.xInput);
            this.Controls.Add(this.yInput);
            this.Controls.Add(this.sizeInput);
            this.Controls.Add(this.enterButton);
            this.Name = "Form1";
            this.Text = "Draw Star";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.TextBox sizeInput;
        private System.Windows.Forms.TextBox yInput;
        private System.Windows.Forms.TextBox xInput;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.Label yLabel;
    }
}

