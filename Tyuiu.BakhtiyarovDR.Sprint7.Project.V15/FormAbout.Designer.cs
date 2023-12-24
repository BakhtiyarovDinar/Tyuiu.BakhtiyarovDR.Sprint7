
namespace Tyuiu.BakhtiyarovDR.Sprint7.Project.V15
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.labelInfo_BDR = new System.Windows.Forms.Label();
            this.buttonOK_BDR = new System.Windows.Forms.Button();
            this.pictureBoxOne_BDR = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOne_BDR)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInfo_BDR
            // 
            this.labelInfo_BDR.AutoSize = true;
            this.labelInfo_BDR.Location = new System.Drawing.Point(72, 8);
            this.labelInfo_BDR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInfo_BDR.Name = "labelInfo_BDR";
            this.labelInfo_BDR.Size = new System.Drawing.Size(0, 13);
            this.labelInfo_BDR.TabIndex = 6;
            this.labelInfo_BDR.Click += new System.EventHandler(this.labelInfo_BDR_Click);
            // 
            // buttonOK_BDR
            // 
            this.buttonOK_BDR.Location = new System.Drawing.Point(269, 147);
            this.buttonOK_BDR.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOK_BDR.Name = "buttonOK_BDR";
            this.buttonOK_BDR.Size = new System.Drawing.Size(66, 25);
            this.buttonOK_BDR.TabIndex = 5;
            this.buttonOK_BDR.Text = "Ок";
            this.buttonOK_BDR.UseVisualStyleBackColor = true;
            this.buttonOK_BDR.Click += new System.EventHandler(this.buttonOK_BDR_Click);
            // 
            // pictureBoxOne_BDR
            // 
            this.pictureBoxOne_BDR.Image = global::Tyuiu.NosovaVD.Sprint7.Project.V15.Properties.Resources.user_female;
            this.pictureBoxOne_BDR.Location = new System.Drawing.Point(11, 8);
            this.pictureBoxOne_BDR.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxOne_BDR.Name = "pictureBoxOne_BDR";
            this.pictureBoxOne_BDR.Size = new System.Drawing.Size(57, 64);
            this.pictureBoxOne_BDR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOne_BDR.TabIndex = 4;
            this.pictureBoxOne_BDR.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 8);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 134);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 181);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelInfo_BDR);
            this.Controls.Add(this.buttonOK_BDR);
            this.Controls.Add(this.pictureBoxOne_BDR);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            this.Load += new System.EventHandler(this.FormAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOne_BDR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label labelInfo_BDR;
        private System.Windows.Forms.Button buttonOK_BDR;
        private System.Windows.Forms.PictureBox pictureBoxOne_BDR;
        private System.Windows.Forms.TextBox textBox1;
    }
}