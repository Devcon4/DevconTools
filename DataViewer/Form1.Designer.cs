namespace DataViewer {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.Graphic1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Graphic1)).BeginInit();
            this.SuspendLayout();
            // 
            // Graphic1
            // 
            this.Graphic1.BackColor = System.Drawing.SystemColors.Highlight;
            this.Graphic1.Location = new System.Drawing.Point(93, 12);
            this.Graphic1.Name = "Graphic1";
            this.Graphic1.Size = new System.Drawing.Size(618, 387);
            this.Graphic1.TabIndex = 0;
            this.Graphic1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Next Frame";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 411);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Graphic1);
            this.Name = "MainForm";
            this.Text = "DataViewer";
            ((System.ComponentModel.ISupportInitialize)(this.Graphic1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Graphic1;
        private System.Windows.Forms.Button button1;
    }
}

