﻿
namespace Food_Facts
{
    partial class NutritionForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.foodLabel = new System.Windows.Forms.Label();
            this.caloriesLabel = new System.Windows.Forms.Label();
            this.fatLabel = new System.Windows.Forms.Label();
            this.carbLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(39, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Food";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(26, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Calories";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(15, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fat Grams";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(8, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Carb Grams";
            // 
            // foodLabel
            // 
            this.foodLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.foodLabel.Location = new System.Drawing.Point(72, 25);
            this.foodLabel.Name = "foodLabel";
            this.foodLabel.Size = new System.Drawing.Size(136, 26);
            this.foodLabel.TabIndex = 4;
            this.foodLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // caloriesLabel
            // 
            this.caloriesLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.caloriesLabel.Location = new System.Drawing.Point(72, 57);
            this.caloriesLabel.Name = "caloriesLabel";
            this.caloriesLabel.Size = new System.Drawing.Size(136, 26);
            this.caloriesLabel.TabIndex = 5;
            this.caloriesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fatLabel
            // 
            this.fatLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fatLabel.Location = new System.Drawing.Point(72, 91);
            this.fatLabel.Name = "fatLabel";
            this.fatLabel.Size = new System.Drawing.Size(136, 26);
            this.fatLabel.TabIndex = 6;
            this.fatLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // carbLabel
            // 
            this.carbLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.carbLabel.Location = new System.Drawing.Point(72, 125);
            this.carbLabel.Name = "carbLabel";
            this.carbLabel.Size = new System.Drawing.Size(136, 26);
            this.carbLabel.TabIndex = 7;
            this.carbLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(93, 169);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(88, 38);
            this.closeButton.TabIndex = 8;
            this.closeButton.Text = "&Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // NutritionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 216);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.carbLabel);
            this.Controls.Add(this.fatLabel);
            this.Controls.Add(this.caloriesLabel);
            this.Controls.Add(this.foodLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NutritionForm";
            this.Text = "NutritionForm";
            this.Load += new System.EventHandler(this.NutritionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label foodLabel;
        public System.Windows.Forms.Label caloriesLabel;
        public System.Windows.Forms.Label fatLabel;
        public System.Windows.Forms.Label carbLabel;
        private System.Windows.Forms.Button closeButton;
    }
}