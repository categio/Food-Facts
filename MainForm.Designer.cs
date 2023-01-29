
namespace Food_Facts
{
    partial class MainForm
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
            this.bananaRadioButton = new System.Windows.Forms.RadioButton();
            this.popcormRadioButton = new System.Windows.Forms.RadioButton();
            this.muffinRadioButton = new System.Windows.Forms.RadioButton();
            this.foodGroupBox = new System.Windows.Forms.GroupBox();
            this.displayButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.foodGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // bananaRadioButton
            // 
            this.bananaRadioButton.AutoSize = true;
            this.bananaRadioButton.Location = new System.Drawing.Point(23, 24);
            this.bananaRadioButton.Name = "bananaRadioButton";
            this.bananaRadioButton.Size = new System.Drawing.Size(70, 17);
            this.bananaRadioButton.TabIndex = 0;
            this.bananaRadioButton.TabStop = true;
            this.bananaRadioButton.Text = "1 banana";
            this.bananaRadioButton.UseVisualStyleBackColor = true;
            // 
            // popcormRadioButton
            // 
            this.popcormRadioButton.AutoSize = true;
            this.popcormRadioButton.Location = new System.Drawing.Point(23, 58);
            this.popcormRadioButton.Name = "popcormRadioButton";
            this.popcormRadioButton.Size = new System.Drawing.Size(159, 17);
            this.popcormRadioButton.TabIndex = 1;
            this.popcormRadioButton.TabStop = true;
            this.popcormRadioButton.Text = "1 cup of air-popped popcorn";
            this.popcormRadioButton.UseVisualStyleBackColor = true;
            // 
            // muffinRadioButton
            // 
            this.muffinRadioButton.AutoSize = true;
            this.muffinRadioButton.Location = new System.Drawing.Point(23, 93);
            this.muffinRadioButton.Name = "muffinRadioButton";
            this.muffinRadioButton.Size = new System.Drawing.Size(134, 17);
            this.muffinRadioButton.TabIndex = 2;
            this.muffinRadioButton.TabStop = true;
            this.muffinRadioButton.Text = "1 large blueberry muffin";
            this.muffinRadioButton.UseVisualStyleBackColor = true;
            // 
            // foodGroupBox
            // 
            this.foodGroupBox.Controls.Add(this.muffinRadioButton);
            this.foodGroupBox.Controls.Add(this.popcormRadioButton);
            this.foodGroupBox.Controls.Add(this.bananaRadioButton);
            this.foodGroupBox.Location = new System.Drawing.Point(40, 32);
            this.foodGroupBox.Name = "foodGroupBox";
            this.foodGroupBox.Size = new System.Drawing.Size(224, 126);
            this.foodGroupBox.TabIndex = 3;
            this.foodGroupBox.TabStop = false;
            this.foodGroupBox.Text = "Select a Food";
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(24, 188);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(111, 56);
            this.displayButton.TabIndex = 4;
            this.displayButton.Text = "Display Food Facts";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(169, 188);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(111, 56);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 264);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.foodGroupBox);
            this.Name = "MainForm";
            this.Text = "Food Facts";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.foodGroupBox.ResumeLayout(false);
            this.foodGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton bananaRadioButton;
        private System.Windows.Forms.RadioButton popcormRadioButton;
        private System.Windows.Forms.RadioButton muffinRadioButton;
        private System.Windows.Forms.GroupBox foodGroupBox;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Button exitButton;
    }
}

