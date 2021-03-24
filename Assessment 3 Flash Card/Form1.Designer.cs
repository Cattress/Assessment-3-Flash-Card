
namespace Assessment_3_Flash_Card
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
            this.browseButton = new System.Windows.Forms.Button();
            this.flipCardButton = new System.Windows.Forms.Button();
            this.cardLabel = new System.Windows.Forms.Label();
            this.shuffleButton = new System.Windows.Forms.Button();
            this.importButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.FilenameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(13, 12);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(65, 36);
            this.browseButton.TabIndex = 0;
            this.browseButton.Text = "browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // flipCardButton
            // 
            this.flipCardButton.Location = new System.Drawing.Point(410, 365);
            this.flipCardButton.Name = "flipCardButton";
            this.flipCardButton.Size = new System.Drawing.Size(108, 36);
            this.flipCardButton.TabIndex = 1;
            this.flipCardButton.Text = "Flip";
            this.flipCardButton.UseVisualStyleBackColor = true;
            this.flipCardButton.Click += new System.EventHandler(this.flipCardButton_Click);
            // 
            // cardLabel
            // 
            this.cardLabel.AutoSize = true;
            this.cardLabel.Location = new System.Drawing.Point(294, 189);
            this.cardLabel.Name = "cardLabel";
            this.cardLabel.Size = new System.Drawing.Size(35, 13);
            this.cardLabel.TabIndex = 2;
            this.cardLabel.Text = "label1";
            this.cardLabel.Click += new System.EventHandler(this.cardLabel_Click);
            // 
            // shuffleButton
            // 
            this.shuffleButton.Location = new System.Drawing.Point(297, 365);
            this.shuffleButton.Name = "shuffleButton";
            this.shuffleButton.Size = new System.Drawing.Size(107, 36);
            this.shuffleButton.TabIndex = 3;
            this.shuffleButton.Text = "shuffle";
            this.shuffleButton.UseVisualStyleBackColor = true;
            // 
            // importButton
            // 
            this.importButton.Location = new System.Drawing.Point(84, 12);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(58, 36);
            this.importButton.TabIndex = 4;
            this.importButton.Text = "Import";
            this.importButton.UseVisualStyleBackColor = true;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(524, 365);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(100, 36);
            this.nextButton.TabIndex = 5;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(633, 365);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(86, 36);
            this.previousButton.TabIndex = 6;
            this.previousButton.Text = "Previous";
            this.previousButton.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FilenameLabel
            // 
            this.FilenameLabel.AutoSize = true;
            this.FilenameLabel.Location = new System.Drawing.Point(148, 35);
            this.FilenameLabel.Name = "FilenameLabel";
            this.FilenameLabel.Size = new System.Drawing.Size(35, 13);
            this.FilenameLabel.TabIndex = 7;
            this.FilenameLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 497);
            this.Controls.Add(this.FilenameLabel);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.shuffleButton);
            this.Controls.Add(this.cardLabel);
            this.Controls.Add(this.flipCardButton);
            this.Controls.Add(this.browseButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button flipCardButton;
        private System.Windows.Forms.Label cardLabel;
        private System.Windows.Forms.Button shuffleButton;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label FilenameLabel;
    }
}

