namespace FreestyleTrainer
{
    partial class FreestyleTrainer
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
            this._NewRhymeBtn = new System.Windows.Forms.Button();
            this._NewWordBtn = new System.Windows.Forms.Button();
            this._WordTbx = new System.Windows.Forms.TextBox();
            this._WordLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._RhymesListbx = new System.Windows.Forms.ListBox();
            this._RhymesAmount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this._RhymesAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // _NewRhymeBtn
            // 
            this._NewRhymeBtn.Location = new System.Drawing.Point(18, 89);
            this._NewRhymeBtn.Name = "_NewRhymeBtn";
            this._NewRhymeBtn.Size = new System.Drawing.Size(123, 23);
            this._NewRhymeBtn.TabIndex = 1;
            this._NewRhymeBtn.Text = "New Rhymes";
            this._NewRhymeBtn.UseVisualStyleBackColor = true;
            // 
            // _NewWordBtn
            // 
            this._NewWordBtn.Location = new System.Drawing.Point(18, 60);
            this._NewWordBtn.Name = "_NewWordBtn";
            this._NewWordBtn.Size = new System.Drawing.Size(215, 23);
            this._NewWordBtn.TabIndex = 3;
            this._NewWordBtn.Text = "New Word";
            this._NewWordBtn.UseVisualStyleBackColor = true;
            // 
            // _WordTbx
            // 
            this._WordTbx.Location = new System.Drawing.Point(18, 34);
            this._WordTbx.Name = "_WordTbx";
            this._WordTbx.Size = new System.Drawing.Size(215, 20);
            this._WordTbx.TabIndex = 2;
            this._WordTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _WordLbl
            // 
            this._WordLbl.AutoSize = true;
            this._WordLbl.BackColor = System.Drawing.Color.Transparent;
            this._WordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this._WordLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this._WordLbl.Location = new System.Drawing.Point(103, 11);
            this._WordLbl.Name = "_WordLbl";
            this._WordLbl.Size = new System.Drawing.Size(49, 20);
            this._WordLbl.TabIndex = 4;
            this._WordLbl.Text = "Word";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(81, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Rhymes List";
            // 
            // _RhymesListbx
            // 
            this._RhymesListbx.FormattingEnabled = true;
            this._RhymesListbx.Location = new System.Drawing.Point(18, 140);
            this._RhymesListbx.Name = "_RhymesListbx";
            this._RhymesListbx.Size = new System.Drawing.Size(215, 290);
            this._RhymesListbx.Sorted = true;
            this._RhymesListbx.TabIndex = 6;
            // 
            // _RhymesAmount
            // 
            this._RhymesAmount.Location = new System.Drawing.Point(147, 89);
            this._RhymesAmount.Name = "_RhymesAmount";
            this._RhymesAmount.Size = new System.Drawing.Size(86, 20);
            this._RhymesAmount.TabIndex = 7;
            this._RhymesAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._RhymesAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FreestyleTrainer
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FreestyleTrainer.Properties.Resources.main_image_star_forming_region_carina_nircam_final_5mb;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(518, 450);
            this.Controls.Add(this._RhymesAmount);
            this.Controls.Add(this._RhymesListbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._WordLbl);
            this.Controls.Add(this._NewWordBtn);
            this.Controls.Add(this._WordTbx);
            this.Controls.Add(this._NewRhymeBtn);
            this.Name = "FreestyleTrainer";
            this.Text = "Freestyle Trainer";
            ((System.ComponentModel.ISupportInitialize)(this._RhymesAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _NewRhymeBtn;
        private System.Windows.Forms.Button _NewWordBtn;
        private System.Windows.Forms.TextBox _WordTbx;
        private System.Windows.Forms.Label _WordLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox _RhymesListbx;
        private System.Windows.Forms.NumericUpDown _RhymesAmount;
    }
}

