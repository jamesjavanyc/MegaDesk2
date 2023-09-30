namespace MegaDesk_Liu
{
    partial class SearchQuotes
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
            this.quotesView = new System.Windows.Forms.DataGridView();
            this.materialInput = new System.Windows.Forms.ComboBox();
            this.materialLabel = new System.Windows.Forms.Label();
            this.ReturnBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.quotesView)).BeginInit();
            this.SuspendLayout();
            // 
            // quotesView
            // 
            this.quotesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.quotesView.Location = new System.Drawing.Point(35, 21);
            this.quotesView.Name = "quotesView";
            this.quotesView.Size = new System.Drawing.Size(680, 262);
            this.quotesView.TabIndex = 0;
            // 
            // materialInput
            // 
            this.materialInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.materialInput.FormattingEnabled = true;
            this.materialInput.Location = new System.Drawing.Point(329, 316);
            this.materialInput.Name = "materialInput";
            this.materialInput.Size = new System.Drawing.Size(253, 28);
            this.materialInput.TabIndex = 24;
            // 
            // materialLabel
            // 
            this.materialLabel.AutoSize = true;
            this.materialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.materialLabel.Location = new System.Drawing.Point(251, 319);
            this.materialLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.materialLabel.Name = "materialLabel";
            this.materialLabel.Size = new System.Drawing.Size(69, 20);
            this.materialLabel.TabIndex = 23;
            this.materialLabel.Text = "Material:";
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ReturnBtn.Location = new System.Drawing.Point(535, 393);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(180, 36);
            this.ReturnBtn.TabIndex = 25;
            this.ReturnBtn.Text = "Return";
            this.ReturnBtn.UseVisualStyleBackColor = true;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 454);
            this.Controls.Add(this.ReturnBtn);
            this.Controls.Add(this.materialInput);
            this.Controls.Add(this.materialLabel);
            this.Controls.Add(this.quotesView);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.Load += new System.EventHandler(this.SearchQuotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quotesView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView quotesView;
        private System.Windows.Forms.ComboBox materialInput;
        private System.Windows.Forms.Label materialLabel;
        private System.Windows.Forms.Button ReturnBtn;
    }
}