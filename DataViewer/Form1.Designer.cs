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
            ((System.ComponentModel.ISupportInitialize)(this.Graphic1)).BeginInit();
            this.SuspendLayout();
            // 
            // Graphic1
            // 
            this.Graphic1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Graphic1.Location = new System.Drawing.Point(170, 12);
            this.Graphic1.Name = "Graphic1";
            this.Graphic1.Size = new System.Drawing.Size(464, 328);
            this.Graphic1.TabIndex = 0;
            this.Graphic1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 352);
            this.Controls.Add(this.Graphic1);
            this.Name = "MainForm";
            this.Text = "DataViewer";
            ((System.ComponentModel.ISupportInitialize)(this.Graphic1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Graphic1;
    }
}

