namespace _5Laba
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pause_button = new System.Windows.Forms.Button();
            this.continue_button = new System.Windows.Forms.Button();
            this.stop_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(46, 61);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 352);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pause_button
            // 
            this.pause_button.Location = new System.Drawing.Point(46, 19);
            this.pause_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pause_button.Name = "pause_button";
            this.pause_button.Size = new System.Drawing.Size(82, 22);
            this.pause_button.TabIndex = 1;
            this.pause_button.Text = "pause";
            this.pause_button.UseVisualStyleBackColor = true;
            this.pause_button.Click += new System.EventHandler(this.pause_button_Click);
            // 
            // continue_button
            // 
            this.continue_button.Location = new System.Drawing.Point(164, 19);
            this.continue_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.continue_button.Name = "continue_button";
            this.continue_button.Size = new System.Drawing.Size(82, 22);
            this.continue_button.TabIndex = 2;
            this.continue_button.Text = "continue";
            this.continue_button.UseVisualStyleBackColor = true;
            this.continue_button.Click += new System.EventHandler(this.continue_button_Click_1);
            // 
            // stop_button
            // 
            this.stop_button.Location = new System.Drawing.Point(283, 19);
            this.stop_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(82, 22);
            this.stop_button.TabIndex = 3;
            this.stop_button.Text = "stop";
            this.stop_button.UseVisualStyleBackColor = true;
            this.stop_button.Click += new System.EventHandler(this.stop_button_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 498);
            this.Controls.Add(this.stop_button);
            this.Controls.Add(this.continue_button);
            this.Controls.Add(this.pause_button);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button pause_button;
        private Button continue_button;
        private Button stop_button;
    }
}