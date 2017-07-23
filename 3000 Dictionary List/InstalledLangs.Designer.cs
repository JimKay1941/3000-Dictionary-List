namespace _3000_Dictionary_List
{
    partial class InstalledLangs
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
            this.button1 = new System.Windows.Forms.Button();
            this.listLangs = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Known = new System.Windows.Forms.TextBox();
            this.Studying = new System.Windows.Forms.TextBox();
            this.Say = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // button1
            //
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(961, 403);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(345, 66);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            //
            // listLangs
            //
            this.listLangs.BackColor = System.Drawing.Color.Yellow;
            this.listLangs.FormattingEnabled = true;
            this.listLangs.ItemHeight = 24;
            this.listLangs.Location = new System.Drawing.Point(12, 12);
            this.listLangs.Name = "listLangs";
            this.listLangs.Size = new System.Drawing.Size(940, 460);
            this.listLangs.TabIndex = 1;
            //
            // label9
            //
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1104, 12);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 24);
            this.label9.TabIndex = 23;
            this.label9.Text = "Language I know";
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1105, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "Language I\'m Studying";
            //
            // Known
            //
            this.Known.BackColor = System.Drawing.Color.Yellow;
            this.Known.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Known.Location = new System.Drawing.Point(1047, 9);
            this.Known.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Known.MaxLength = 1;
            this.Known.Name = "Known";
            this.Known.Size = new System.Drawing.Size(47, 36);
            this.Known.TabIndex = 25;
            this.Known.TabStop = false;
            //
            // Studying
            //
            this.Studying.BackColor = System.Drawing.Color.Yellow;
            this.Studying.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Studying.Location = new System.Drawing.Point(1047, 57);
            this.Studying.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Studying.MaxLength = 1;
            this.Studying.Name = "Studying";
            this.Studying.Size = new System.Drawing.Size(47, 36);
            this.Studying.TabIndex = 26;
            this.Studying.TabStop = false;
            //
            // Say
            //
            this.Say.AutoSize = true;
            this.Say.Location = new System.Drawing.Point(958, 373);
            this.Say.Name = "Say";
            this.Say.Size = new System.Drawing.Size(0, 24);
            this.Say.TabIndex = 27;
            //
            // InstalledLangs
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(1321, 484);
            this.Controls.Add(this.Say);
            this.Controls.Add(this.Studying);
            this.Controls.Add(this.Known);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listLangs);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "InstalledLangs";
            this.Text = "InstalledLangs";
            this.Load += new System.EventHandler(this.InstalledLangs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listLangs;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Known;
        private System.Windows.Forms.TextBox Studying;
        private System.Windows.Forms.Label Say;
    }
}