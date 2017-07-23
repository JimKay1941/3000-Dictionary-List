using System.Windows.Forms;

namespace _3000_Dictionary_List
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
            this.Status = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.WorkZhuyin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.WorkTraditional = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.WorkNumPinyin = new System.Windows.Forms.TextBox();
            this.WriteEnglish = new System.Windows.Forms.TextBox();
            this.WriteIt = new System.Windows.Forms.Button();
            this.listZhuyin = new System.Windows.Forms.ListBox();
            this.listNumPinyin = new System.Windows.Forms.ListBox();
            this.WriteNumPinyin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.WriteTraditional = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.WriteZhuyin = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ShowLanguages = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textCangjie = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textDefinition = new System.Windows.Forms.TextBox();
            this.btnSetUserCred = new System.Windows.Forms.Button();
            this.WriteCritPinyin = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.WriteSimplified = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBopo = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.WriteCji = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lblFEFrequency = new System.Windows.Forms.Label();
            this.txtFEFrequency = new System.Windows.Forms.TextBox();
            this.chkBypass = new System.Windows.Forms.CheckBox();
            this.txtĀǍĒĚĪǏŌǑŪǓǗǙǛMMŃŇ = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Status
            // 
            this.Status.BackColor = System.Drawing.Color.Yellow;
            this.Status.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Status.Location = new System.Drawing.Point(20, 550);
            this.Status.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(993, 36);
            this.Status.TabIndex = 9;
            this.Status.TabStop = false;
            this.Status.Enter += new System.EventHandler(this.Status_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 520);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Status Msg";
            // 
            // WorkZhuyin
            // 
            this.WorkZhuyin.BackColor = System.Drawing.Color.Yellow;
            this.WorkZhuyin.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkZhuyin.ImeMode = System.Windows.Forms.ImeMode.On;
            this.WorkZhuyin.Location = new System.Drawing.Point(20, 336);
            this.WorkZhuyin.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.WorkZhuyin.Name = "WorkZhuyin";
            this.WorkZhuyin.Size = new System.Drawing.Size(343, 36);
            this.WorkZhuyin.TabIndex = 24;
            this.WorkZhuyin.TabStop = false;
            this.WorkZhuyin.Click += new System.EventHandler(this.WorkBoPoMoFo_Enter);
            this.WorkZhuyin.Enter += new System.EventHandler(this.WorkBoPoMoFo_Enter);
            this.WorkZhuyin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WorkBoPoMoFo_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(388, 312);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 24);
            this.label8.TabIndex = 19;
            this.label8.Text = "Working Traditional";
            // 
            // WorkTraditional
            // 
            this.WorkTraditional.BackColor = System.Drawing.Color.Yellow;
            this.WorkTraditional.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkTraditional.ImeMode = System.Windows.Forms.ImeMode.On;
            this.WorkTraditional.Location = new System.Drawing.Point(392, 335);
            this.WorkTraditional.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.WorkTraditional.MaxLength = 1;
            this.WorkTraditional.Name = "WorkTraditional";
            this.WorkTraditional.Size = new System.Drawing.Size(185, 36);
            this.WorkTraditional.TabIndex = 1;
            this.WorkTraditional.Click += new System.EventHandler(this.WorkChinese_Enter);
            this.WorkTraditional.TextChanged += new System.EventHandler(this.WorkChinese_TextChanged);
            this.WorkTraditional.Enter += new System.EventHandler(this.WorkChinese_Enter);
            this.WorkTraditional.KeyUp += new System.Windows.Forms.KeyEventHandler(this.WorkChinese_KeyUp);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 99);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 24);
            this.label9.TabIndex = 22;
            this.label9.Text = "Final English";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(605, 312);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(177, 24);
            this.label11.TabIndex = 25;
            this.label11.Text = "Working NumPinyin";
            // 
            // WorkNumPinyin
            // 
            this.WorkNumPinyin.BackColor = System.Drawing.Color.Yellow;
            this.WorkNumPinyin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkNumPinyin.ImeMode = System.Windows.Forms.ImeMode.On;
            this.WorkNumPinyin.Location = new System.Drawing.Point(609, 336);
            this.WorkNumPinyin.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.WorkNumPinyin.Name = "WorkNumPinyin";
            this.WorkNumPinyin.Size = new System.Drawing.Size(405, 35);
            this.WorkNumPinyin.TabIndex = 25;
            this.WorkNumPinyin.TabStop = false;
            this.WorkNumPinyin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Pinyin_MouseClick);
            this.WorkNumPinyin.Enter += new System.EventHandler(this.English_Enter);
            this.WorkNumPinyin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WorkPinyin_KeyPress);
            // 
            // WriteEnglish
            // 
            this.WriteEnglish.BackColor = System.Drawing.Color.Yellow;
            this.WriteEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WriteEnglish.ImeMode = System.Windows.Forms.ImeMode.On;
            this.WriteEnglish.Location = new System.Drawing.Point(20, 129);
            this.WriteEnglish.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.WriteEnglish.Name = "WriteEnglish";
            this.WriteEnglish.Size = new System.Drawing.Size(993, 35);
            this.WriteEnglish.TabIndex = 2;
            this.WriteEnglish.Enter += new System.EventHandler(this.English_Enter);
            this.WriteEnglish.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WriteEnglish_KeyPress);
            // 
            // WriteIt
            // 
            this.WriteIt.BackColor = System.Drawing.Color.Black;
            this.WriteIt.ForeColor = System.Drawing.Color.LawnGreen;
            this.WriteIt.Location = new System.Drawing.Point(230, 1);
            this.WriteIt.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.WriteIt.Name = "WriteIt";
            this.WriteIt.Size = new System.Drawing.Size(188, 37);
            this.WriteIt.TabIndex = 3;
            this.WriteIt.Text = "Write It";
            this.WriteIt.UseVisualStyleBackColor = false;
            this.WriteIt.Click += new System.EventHandler(this.WriteIt_Click);
            this.WriteIt.Enter += new System.EventHandler(this.WriteIt_Click);
            // 
            // listZhuyin
            // 
            this.listZhuyin.BackColor = System.Drawing.Color.Yellow;
            this.listZhuyin.CausesValidation = false;
            this.listZhuyin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listZhuyin.FormattingEnabled = true;
            this.listZhuyin.ImeMode = System.Windows.Forms.ImeMode.On;
            this.listZhuyin.ItemHeight = 29;
            this.listZhuyin.Location = new System.Drawing.Point(20, 389);
            this.listZhuyin.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.listZhuyin.Name = "listZhuyin";
            this.listZhuyin.Size = new System.Drawing.Size(187, 207);
            this.listZhuyin.TabIndex = 28;
            this.listZhuyin.TabStop = false;
            this.listZhuyin.Visible = false;
            this.listZhuyin.SelectedIndexChanged += new System.EventHandler(this.listBoPoMoFo_SelectedIndexChanged);
            // 
            // listNumPinyin
            // 
            this.listNumPinyin.BackColor = System.Drawing.Color.Yellow;
            this.listNumPinyin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listNumPinyin.FormattingEnabled = true;
            this.listNumPinyin.ImeMode = System.Windows.Forms.ImeMode.On;
            this.listNumPinyin.ItemHeight = 29;
            this.listNumPinyin.Location = new System.Drawing.Point(444, 389);
            this.listNumPinyin.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.listNumPinyin.Name = "listNumPinyin";
            this.listNumPinyin.Size = new System.Drawing.Size(569, 207);
            this.listNumPinyin.TabIndex = 30;
            this.listNumPinyin.TabStop = false;
            this.listNumPinyin.Visible = false;
            this.listNumPinyin.SelectedIndexChanged += new System.EventHandler(this.listPinyin_SelectedIndexChanged);
            // 
            // WriteNumPinyin
            // 
            this.WriteNumPinyin.BackColor = System.Drawing.Color.Yellow;
            this.WriteNumPinyin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WriteNumPinyin.ImeMode = System.Windows.Forms.ImeMode.On;
            this.WriteNumPinyin.Location = new System.Drawing.Point(609, 200);
            this.WriteNumPinyin.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.WriteNumPinyin.Name = "WriteNumPinyin";
            this.WriteNumPinyin.Size = new System.Drawing.Size(404, 35);
            this.WriteNumPinyin.TabIndex = 23;
            this.WriteNumPinyin.TabStop = false;
            this.WriteNumPinyin.Enter += new System.EventHandler(this.English_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(605, 170);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 24);
            this.label1.TabIndex = 35;
            this.label1.Text = "Final NumPinyin";
            // 
            // WriteTraditional
            // 
            this.WriteTraditional.BackColor = System.Drawing.Color.Yellow;
            this.WriteTraditional.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WriteTraditional.ImeMode = System.Windows.Forms.ImeMode.On;
            this.WriteTraditional.Location = new System.Drawing.Point(392, 199);
            this.WriteTraditional.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.WriteTraditional.Name = "WriteTraditional";
            this.WriteTraditional.Size = new System.Drawing.Size(185, 36);
            this.WriteTraditional.TabIndex = 22;
            this.WriteTraditional.TabStop = false;
            this.WriteTraditional.Click += new System.EventHandler(this.WriteChinese_Enter);
            this.WriteTraditional.Enter += new System.EventHandler(this.WriteChinese_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 169);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 24);
            this.label4.TabIndex = 34;
            this.label4.Text = "Final Traditional";
            // 
            // WriteZhuyin
            // 
            this.WriteZhuyin.BackColor = System.Drawing.Color.Yellow;
            this.WriteZhuyin.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WriteZhuyin.ImeMode = System.Windows.Forms.ImeMode.On;
            this.WriteZhuyin.Location = new System.Drawing.Point(20, 200);
            this.WriteZhuyin.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.WriteZhuyin.Name = "WriteZhuyin";
            this.WriteZhuyin.Size = new System.Drawing.Size(343, 36);
            this.WriteZhuyin.TabIndex = 21;
            this.WriteZhuyin.TabStop = false;
            this.WriteZhuyin.Click += new System.EventHandler(this.WriteBoPoMoFo_Enter);
            this.WriteZhuyin.Enter += new System.EventHandler(this.WriteBoPoMoFo_Enter);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.Black;
            this.Clear.ForeColor = System.Drawing.Color.Gold;
            this.Clear.Location = new System.Drawing.Point(217, 389);
            this.Clear.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(188, 37);
            this.Clear.TabIndex = 37;
            this.Clear.TabStop = false;
            this.Clear.Text = "Clear Current";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(20, 39);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 36);
            this.button1.TabIndex = 38;
            this.button1.TabStop = false;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 312);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Working Zhuyin";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 169);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 24);
            this.label10.TabIndex = 33;
            this.label10.Text = "Final Zhuyin";
            // 
            // ShowLanguages
            // 
            this.ShowLanguages.BackColor = System.Drawing.Color.Black;
            this.ShowLanguages.ForeColor = System.Drawing.Color.Red;
            this.ShowLanguages.Location = new System.Drawing.Point(230, 39);
            this.ShowLanguages.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ShowLanguages.Name = "ShowLanguages";
            this.ShowLanguages.Size = new System.Drawing.Size(188, 36);
            this.ShowLanguages.TabIndex = 39;
            this.ShowLanguages.TabStop = false;
            this.ShowLanguages.Text = "Show Languages";
            this.ShowLanguages.UseVisualStyleBackColor = false;
            this.ShowLanguages.Click += new System.EventHandler(this.ShowLanguages_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(438, 56);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 24);
            this.label5.TabIndex = 40;
            this.label5.Text = "CangJie";
            // 
            // textCangjie
            // 
            this.textCangjie.BackColor = System.Drawing.Color.Yellow;
            this.textCangjie.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCangjie.ImeMode = System.Windows.Forms.ImeMode.On;
            this.textCangjie.Location = new System.Drawing.Point(527, 47);
            this.textCangjie.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textCangjie.Name = "textCangjie";
            this.textCangjie.Size = new System.Drawing.Size(180, 35);
            this.textCangjie.TabIndex = 41;
            this.textCangjie.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(182, 95);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 24);
            this.label7.TabIndex = 42;
            this.label7.Text = "Definition";
            // 
            // textDefinition
            // 
            this.textDefinition.BackColor = System.Drawing.Color.Yellow;
            this.textDefinition.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDefinition.ImeMode = System.Windows.Forms.ImeMode.On;
            this.textDefinition.Location = new System.Drawing.Point(279, 88);
            this.textDefinition.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textDefinition.Name = "textDefinition";
            this.textDefinition.Size = new System.Drawing.Size(734, 35);
            this.textDefinition.TabIndex = 43;
            this.textDefinition.TabStop = false;
            // 
            // btnSetUserCred
            // 
            this.btnSetUserCred.BackColor = System.Drawing.Color.Black;
            this.btnSetUserCred.ForeColor = System.Drawing.Color.LawnGreen;
            this.btnSetUserCred.Location = new System.Drawing.Point(20, 1);
            this.btnSetUserCred.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSetUserCred.Name = "btnSetUserCred";
            this.btnSetUserCred.Size = new System.Drawing.Size(188, 36);
            this.btnSetUserCred.TabIndex = 46;
            this.btnSetUserCred.TabStop = false;
            this.btnSetUserCred.Text = "Set User Credentials";
            this.btnSetUserCred.UseVisualStyleBackColor = false;
            this.btnSetUserCred.Click += new System.EventHandler(this.SetUserCredentials_Click);
            // 
            // WriteCritPinyin
            // 
            this.WriteCritPinyin.BackColor = System.Drawing.Color.Yellow;
            this.WriteCritPinyin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WriteCritPinyin.ImeMode = System.Windows.Forms.ImeMode.On;
            this.WriteCritPinyin.Location = new System.Drawing.Point(609, 269);
            this.WriteCritPinyin.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.WriteCritPinyin.Name = "WriteCritPinyin";
            this.WriteCritPinyin.Size = new System.Drawing.Size(404, 35);
            this.WriteCritPinyin.TabIndex = 50;
            this.WriteCritPinyin.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(605, 245);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 24);
            this.label12.TabIndex = 54;
            this.label12.Text = "Final CritPinyin";
            // 
            // WriteSimplified
            // 
            this.WriteSimplified.BackColor = System.Drawing.Color.Yellow;
            this.WriteSimplified.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WriteSimplified.ImeMode = System.Windows.Forms.ImeMode.On;
            this.WriteSimplified.Location = new System.Drawing.Point(392, 268);
            this.WriteSimplified.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.WriteSimplified.Name = "WriteSimplified";
            this.WriteSimplified.Size = new System.Drawing.Size(185, 36);
            this.WriteSimplified.TabIndex = 49;
            this.WriteSimplified.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(388, 245);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(137, 24);
            this.label13.TabIndex = 53;
            this.label13.Text = "Final Simplified";
            // 
            // textBopo
            // 
            this.textBopo.BackColor = System.Drawing.Color.Yellow;
            this.textBopo.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBopo.ImeMode = System.Windows.Forms.ImeMode.On;
            this.textBopo.Location = new System.Drawing.Point(527, 4);
            this.textBopo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBopo.Name = "textBopo";
            this.textBopo.Size = new System.Drawing.Size(180, 36);
            this.textBopo.TabIndex = 56;
            this.textBopo.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(439, 11);
            this.label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 24);
            this.label16.TabIndex = 55;
            this.label16.Text = "Zhuyin";
            // 
            // WriteCji
            // 
            this.WriteCji.BackColor = System.Drawing.Color.Yellow;
            this.WriteCji.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WriteCji.ImeMode = System.Windows.Forms.ImeMode.On;
            this.WriteCji.Location = new System.Drawing.Point(20, 268);
            this.WriteCji.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.WriteCji.Name = "WriteCji";
            this.WriteCji.Size = new System.Drawing.Size(343, 35);
            this.WriteCji.TabIndex = 57;
            this.WriteCji.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 245);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 24);
            this.label14.TabIndex = 58;
            this.label14.Text = "Final Cji";
            // 
            // lblFEFrequency
            // 
            this.lblFEFrequency.AutoSize = true;
            this.lblFEFrequency.Location = new System.Drawing.Point(428, 393);
            this.lblFEFrequency.Name = "lblFEFrequency";
            this.lblFEFrequency.Size = new System.Drawing.Size(132, 24);
            this.lblFEFrequency.TabIndex = 61;
            this.lblFEFrequency.Text = "FE Frequency";
            // 
            // txtFEFrequency
            // 
            this.txtFEFrequency.Location = new System.Drawing.Point(569, 390);
            this.txtFEFrequency.Name = "txtFEFrequency";
            this.txtFEFrequency.Size = new System.Drawing.Size(88, 29);
            this.txtFEFrequency.TabIndex = 62;
            this.txtFEFrequency.TabStop = false;
            this.txtFEFrequency.Click += new System.EventHandler(this.txtFEFrequency_Click);
            this.txtFEFrequency.Enter += new System.EventHandler(this.English_Enter);
            // 
            // chkBypass
            // 
            this.chkBypass.AutoSize = true;
            this.chkBypass.Location = new System.Drawing.Point(678, 390);
            this.chkBypass.Name = "chkBypass";
            this.chkBypass.Size = new System.Drawing.Size(89, 28);
            this.chkBypass.TabIndex = 63;
            this.chkBypass.TabStop = false;
            this.chkBypass.Text = "Bypass";
            this.chkBypass.UseVisualStyleBackColor = true;
            // 
            // txtĀǍĒĚĪǏŌǑŪǓǗǙǛMMŃŇ
            // 
            this.txtĀǍĒĚĪǏŌǑŪǓǗǙǛMMŃŇ.BackColor = System.Drawing.Color.Yellow;
            this.txtĀǍĒĚĪǏŌǑŪǓǗǙǛMMŃŇ.Location = new System.Drawing.Point(217, 502);
            this.txtĀǍĒĚĪǏŌǑŪǓǗǙǛMMŃŇ.Name = "txtĀǍĒĚĪǏŌǑŪǓǗǙǛMMŃŇ";
            this.txtĀǍĒĚĪǏŌǑŪǓǗǙǛMMŃŇ.ReadOnly = true;
            this.txtĀǍĒĚĪǏŌǑŪǓǗǙǛMMŃŇ.Size = new System.Drawing.Size(421, 29);
            this.txtĀǍĒĚĪǏŌǑŪǓǗǙǛMMŃŇ.TabIndex = 64;
            this.txtĀǍĒĚĪǏŌǑŪǓǗǙǛMMŃŇ.TabStop = false;
            this.txtĀǍĒĚĪǏŌǑŪǓǗǙǛMMŃŇ.Text = "ā  ǎ  ē  ě  ī  ǐ  ō  ǒ  ū  ǔ  ǘ  ǚ  ǜ  ü  m̄  ḿ  m̀  ń  ň  ǹ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(1027, 604);
            this.Controls.Add(this.listNumPinyin);
            this.Controls.Add(this.txtĀǍĒĚĪǏŌǑŪǓǗǙǛMMŃŇ);
            this.Controls.Add(this.chkBypass);
            this.Controls.Add(this.listZhuyin);
            this.Controls.Add(this.txtFEFrequency);
            this.Controls.Add(this.lblFEFrequency);
            this.Controls.Add(this.WriteCji);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBopo);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.WriteCritPinyin);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.WriteSimplified);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnSetUserCred);
            this.Controls.Add(this.textDefinition);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textCangjie);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ShowLanguages);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.WriteNumPinyin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WriteTraditional);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.WriteZhuyin);
            this.Controls.Add(this.WriteIt);
            this.Controls.Add(this.WriteEnglish);
            this.Controls.Add(this.WorkNumPinyin);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.WorkTraditional);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.WorkZhuyin);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "Customized Chinese Language List for Far East 3000 Word List   (By: James S. Kay," +
    " Consulting - Version: 1.0.00)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Status;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox WorkZhuyin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox WorkTraditional;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox WorkNumPinyin;
        private System.Windows.Forms.TextBox WriteEnglish;
        private System.Windows.Forms.Button WriteIt;
        private System.Windows.Forms.ListBox listZhuyin;
        private System.Windows.Forms.ListBox listNumPinyin;
        private System.Windows.Forms.TextBox WriteNumPinyin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox WriteTraditional;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox WriteZhuyin;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button ShowLanguages;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textCangjie;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textDefinition;
        private System.Windows.Forms.Button btnSetUserCred;
        private char[] _delim2 = new char[1];
        private InputLanguage[] _myLanguages = new InputLanguage[10];
        private char[] _delim1 = new char[1];
        private TextBox WriteCritPinyin;
        private Label label12;
        private TextBox WriteSimplified;
        private Label label13;
        private TextBox textBopo;
        private Label label16;
        private TextBox WriteCji;
        private Label label14;
        private Label lblFEFrequency;
        private TextBox txtFEFrequency;
        private CheckBox chkBypass;
        private TextBox txtĀǍĒĚĪǏŌǑŪǓǗǙǛMMŃŇ;
    }
}

