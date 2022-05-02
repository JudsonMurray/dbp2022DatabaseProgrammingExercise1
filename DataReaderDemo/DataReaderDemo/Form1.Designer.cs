namespace DataReaderDemo
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtDemo1 = new System.Windows.Forms.TextBox();
            this.txtDemo2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(35, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 146);
            this.button1.TabIndex = 0;
            this.button1.Text = "Demo 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(35, 202);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 146);
            this.button2.TabIndex = 1;
            this.button2.Text = "Demo 2 - using";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtDemo1
            // 
            this.txtDemo1.Location = new System.Drawing.Point(190, 17);
            this.txtDemo1.Multiline = true;
            this.txtDemo1.Name = "txtDemo1";
            this.txtDemo1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDemo1.Size = new System.Drawing.Size(473, 146);
            this.txtDemo1.TabIndex = 2;
            // 
            // txtDemo2
            // 
            this.txtDemo2.Location = new System.Drawing.Point(190, 202);
            this.txtDemo2.Multiline = true;
            this.txtDemo2.Name = "txtDemo2";
            this.txtDemo2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDemo2.Size = new System.Drawing.Size(473, 146);
            this.txtDemo2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 398);
            this.Controls.Add(this.txtDemo2);
            this.Controls.Add(this.txtDemo1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtDemo1;
        private System.Windows.Forms.TextBox txtDemo2;
    }
}

