﻿namespace MCPixelArtConverter
{
    partial class MCPACMainForm
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
            this.LoadBlockInfoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoadBlockInfoButton
            // 
            this.LoadBlockInfoButton.Location = new System.Drawing.Point(13, 13);
            this.LoadBlockInfoButton.Name = "LoadBlockInfoButton";
            this.LoadBlockInfoButton.Size = new System.Drawing.Size(93, 23);
            this.LoadBlockInfoButton.TabIndex = 0;
            this.LoadBlockInfoButton.Text = "Load block info";
            this.LoadBlockInfoButton.UseVisualStyleBackColor = true;
            this.LoadBlockInfoButton.Click += new System.EventHandler(this.LoadBlockInfoButton_Click);
            // 
            // MCPACMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 510);
            this.Controls.Add(this.LoadBlockInfoButton);
            this.Name = "MCPACMainForm";
            this.Text = "MC Pixel Art Converter";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LoadBlockInfoButton;
    }
}

