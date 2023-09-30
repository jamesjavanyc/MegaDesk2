namespace MegaDesk_Liu
{
    partial class AddQuote
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
            this.components = new System.ComponentModel.Container();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.deskDepthInput = new System.Windows.Forms.TextBox();
            this.deskDepthLabel = new System.Windows.Forms.Label();
            this.deskWidthInput = new System.Windows.Forms.TextBox();
            this.deskWidthLabel = new System.Windows.Forms.Label();
            this.drawerCountLabel = new System.Windows.Forms.Label();
            this.materialLabel = new System.Windows.Forms.Label();
            this.rushLabel = new System.Windows.Forms.Label();
            this.materialInput = new System.Windows.Forms.ComboBox();
            this.rushInput = new System.Windows.Forms.ComboBox();
            this.WidthRangeLabel = new System.Windows.Forms.Label();
            this.DepthRangeLabel = new System.Windows.Forms.Label();
            this.DrawerCountRangeLabel = new System.Windows.Forms.Label();
            this.NameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.WidthErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.DepthErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.DrawerCountErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.MaterialErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.RushErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.drawerCountInput = new System.Windows.Forms.ComboBox();
            this.CreateBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepthErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrawerCountErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RushErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cancelBtn.Location = new System.Drawing.Point(465, 331);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 27);
            this.cancelBtn.TabIndex = 9;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nameLabel.Location = new System.Drawing.Point(52, 40);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(55, 20);
            this.nameLabel.TabIndex = 10;
            this.nameLabel.Text = "Name:";
            // 
            // nameInput
            // 
            this.nameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nameInput.Location = new System.Drawing.Point(217, 40);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(253, 26);
            this.nameInput.TabIndex = 11;
            // 
            // deskDepthInput
            // 
            this.deskDepthInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.deskDepthInput.Location = new System.Drawing.Point(217, 133);
            this.deskDepthInput.Name = "deskDepthInput";
            this.deskDepthInput.Size = new System.Drawing.Size(145, 26);
            this.deskDepthInput.TabIndex = 13;
            this.deskDepthInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CharValidation);
            this.deskDepthInput.Validating += new System.ComponentModel.CancelEventHandler(this.ValidatingDepthInput);
            this.deskDepthInput.Validated += new System.EventHandler(this.Depth_Validated);
            // 
            // deskDepthLabel
            // 
            this.deskDepthLabel.AutoSize = true;
            this.deskDepthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.deskDepthLabel.Location = new System.Drawing.Point(52, 133);
            this.deskDepthLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.deskDepthLabel.Name = "deskDepthLabel";
            this.deskDepthLabel.Size = new System.Drawing.Size(139, 20);
            this.deskDepthLabel.TabIndex = 12;
            this.deskDepthLabel.Text = "Desk Depth(Inch):";
            // 
            // deskWidthInput
            // 
            this.deskWidthInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.deskWidthInput.Location = new System.Drawing.Point(217, 82);
            this.deskWidthInput.Name = "deskWidthInput";
            this.deskWidthInput.Size = new System.Drawing.Size(145, 26);
            this.deskWidthInput.TabIndex = 15;
            this.deskWidthInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CharValidation);
            this.deskWidthInput.Validating += new System.ComponentModel.CancelEventHandler(this.ValidatingWidthInput);
            this.deskWidthInput.Validated += new System.EventHandler(this.Width_Validated);
            // 
            // deskWidthLabel
            // 
            this.deskWidthLabel.AutoSize = true;
            this.deskWidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.deskWidthLabel.Location = new System.Drawing.Point(52, 85);
            this.deskWidthLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.deskWidthLabel.Name = "deskWidthLabel";
            this.deskWidthLabel.Size = new System.Drawing.Size(140, 20);
            this.deskWidthLabel.TabIndex = 14;
            this.deskWidthLabel.Text = "Desk Width (Inch):";
            // 
            // drawerCountLabel
            // 
            this.drawerCountLabel.AutoSize = true;
            this.drawerCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.drawerCountLabel.Location = new System.Drawing.Point(52, 179);
            this.drawerCountLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.drawerCountLabel.Name = "drawerCountLabel";
            this.drawerCountLabel.Size = new System.Drawing.Size(111, 20);
            this.drawerCountLabel.TabIndex = 16;
            this.drawerCountLabel.Text = "Drawer Count:";
            // 
            // materialLabel
            // 
            this.materialLabel.AutoSize = true;
            this.materialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.materialLabel.Location = new System.Drawing.Point(52, 226);
            this.materialLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.materialLabel.Name = "materialLabel";
            this.materialLabel.Size = new System.Drawing.Size(69, 20);
            this.materialLabel.TabIndex = 18;
            this.materialLabel.Text = "Material:";
            // 
            // rushLabel
            // 
            this.rushLabel.AutoSize = true;
            this.rushLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rushLabel.Location = new System.Drawing.Point(52, 274);
            this.rushLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.rushLabel.Name = "rushLabel";
            this.rushLabel.Size = new System.Drawing.Size(51, 20);
            this.rushLabel.TabIndex = 20;
            this.rushLabel.Text = "Rush:";
            // 
            // materialInput
            // 
            this.materialInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.materialInput.FormattingEnabled = true;
            this.materialInput.Location = new System.Drawing.Point(217, 225);
            this.materialInput.Name = "materialInput";
            this.materialInput.Size = new System.Drawing.Size(253, 28);
            this.materialInput.TabIndex = 22;            // 
            // rushInput
            // 
            this.rushInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rushInput.FormattingEnabled = true;
            this.rushInput.Items.AddRange(new object[] {
            "None",
            "3 Days",
            "5 Days",
            "7 Days"});
            this.rushInput.Location = new System.Drawing.Point(217, 273);
            this.rushInput.Name = "rushInput";
            this.rushInput.Size = new System.Drawing.Size(253, 28);
            this.rushInput.TabIndex = 23;
            // 
            // WidthRangeLabel
            // 
            this.WidthRangeLabel.AutoSize = true;
            this.WidthRangeLabel.Location = new System.Drawing.Point(387, 90);
            this.WidthRangeLabel.Name = "WidthRangeLabel";
            this.WidthRangeLabel.Size = new System.Drawing.Size(83, 13);
            this.WidthRangeLabel.TabIndex = 24;
            this.WidthRangeLabel.Text = "( 24 - 96 inches)";
            // 
            // DepthRangeLabel
            // 
            this.DepthRangeLabel.AutoSize = true;
            this.DepthRangeLabel.Location = new System.Drawing.Point(387, 138);
            this.DepthRangeLabel.Name = "DepthRangeLabel";
            this.DepthRangeLabel.Size = new System.Drawing.Size(83, 13);
            this.DepthRangeLabel.TabIndex = 25;
            this.DepthRangeLabel.Text = "( 12 - 48 inches)";
            // 
            // DrawerCountRangeLabel
            // 
            this.DrawerCountRangeLabel.AutoSize = true;
            this.DrawerCountRangeLabel.Location = new System.Drawing.Point(390, 185);
            this.DrawerCountRangeLabel.Name = "DrawerCountRangeLabel";
            this.DrawerCountRangeLabel.Size = new System.Drawing.Size(78, 13);
            this.DrawerCountRangeLabel.TabIndex = 26;
            this.DrawerCountRangeLabel.Text = " ( 0 -  7 counts)";
            // 
            // NameErrorProvider
            // 
            this.NameErrorProvider.ContainerControl = this;
            // 
            // WidthErrorProvider
            // 
            this.WidthErrorProvider.ContainerControl = this;
            // 
            // DepthErrorProvider
            // 
            this.DepthErrorProvider.ContainerControl = this;
            // 
            // DrawerCountErrorProvider
            // 
            this.DrawerCountErrorProvider.ContainerControl = this;
            // 
            // MaterialErrorProvider
            // 
            this.MaterialErrorProvider.ContainerControl = this;
            // 
            // RushErrorProvider
            // 
            this.RushErrorProvider.ContainerControl = this;
            // 
            // drawerCountInput
            // 
            this.drawerCountInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.drawerCountInput.FormattingEnabled = true;
            this.drawerCountInput.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.drawerCountInput.Location = new System.Drawing.Point(217, 177);
            this.drawerCountInput.Name = "drawerCountInput";
            this.drawerCountInput.Size = new System.Drawing.Size(145, 28);
            this.drawerCountInput.TabIndex = 27;
            this.drawerCountInput.Text = "0";
            // 
            // CreateBtn
            // 
            this.CreateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CreateBtn.Location = new System.Drawing.Point(358, 331);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(75, 27);
            this.CreateBtn.TabIndex = 28;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 391);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.drawerCountInput);
            this.Controls.Add(this.DrawerCountRangeLabel);
            this.Controls.Add(this.DepthRangeLabel);
            this.Controls.Add(this.WidthRangeLabel);
            this.Controls.Add(this.rushInput);
            this.Controls.Add(this.materialInput);
            this.Controls.Add(this.rushLabel);
            this.Controls.Add(this.materialLabel);
            this.Controls.Add(this.drawerCountLabel);
            this.Controls.Add(this.deskWidthInput);
            this.Controls.Add(this.deskWidthLabel);
            this.Controls.Add(this.deskDepthInput);
            this.Controls.Add(this.deskDepthLabel);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.cancelBtn);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepthErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrawerCountErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RushErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox deskDepthInput;
        private System.Windows.Forms.Label deskDepthLabel;
        private System.Windows.Forms.TextBox deskWidthInput;
        private System.Windows.Forms.Label deskWidthLabel;
        private System.Windows.Forms.Label drawerCountLabel;
        private System.Windows.Forms.Label materialLabel;
        private System.Windows.Forms.Label rushLabel;
        private System.Windows.Forms.ComboBox materialInput;
        private System.Windows.Forms.ComboBox rushInput;
        private System.Windows.Forms.Label WidthRangeLabel;
        private System.Windows.Forms.Label DepthRangeLabel;
        private System.Windows.Forms.Label DrawerCountRangeLabel;
        private System.Windows.Forms.ErrorProvider NameErrorProvider;
        private System.Windows.Forms.ErrorProvider WidthErrorProvider;
        private System.Windows.Forms.ErrorProvider DepthErrorProvider;
        private System.Windows.Forms.ErrorProvider DrawerCountErrorProvider;
        private System.Windows.Forms.ErrorProvider MaterialErrorProvider;
        private System.Windows.Forms.ErrorProvider RushErrorProvider;
        private System.Windows.Forms.ComboBox drawerCountInput;
        private System.Windows.Forms.Button CreateBtn;
    }
}