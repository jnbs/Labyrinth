namespace Labyrinth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sprite1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.importButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sprite1)).BeginInit();
            this.SuspendLayout();
            // 
            // sprite1
            // 
            this.sprite1.Image = ((System.Drawing.Image)(resources.GetObject("sprite1.Image")));
            this.sprite1.Location = new System.Drawing.Point(542, 85);
            this.sprite1.Name = "sprite1";
            this.sprite1.Size = new System.Drawing.Size(61, 50);
            this.sprite1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.sprite1.TabIndex = 0;
            this.sprite1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(491, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 65);
            this.button1.TabIndex = 1;
            this.button1.Text = "->";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // importButton
            // 
            this.importButton.Location = new System.Drawing.Point(27, 133);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(136, 56);
            this.importButton.TabIndex = 2;
            this.importButton.Text = "Import Code";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(410, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 65);
            this.button2.TabIndex = 3;
            this.button2.Text = "<-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 561);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sprite1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.sprite1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox sprite1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.Button button2;
    }
}

