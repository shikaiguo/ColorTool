namespace ColorTool
{
    partial class Form_Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox_RG = new System.Windows.Forms.PictureBox();
            this.pictureBox_B = new System.Windows.Forms.PictureBox();
            this.pictureBox_RGB = new System.Windows.Forms.PictureBox();
            this.label_R = new System.Windows.Forms.Label();
            this.label_G = new System.Windows.Forms.Label();
            this.label_B = new System.Windows.Forms.Label();
            this.label_H = new System.Windows.Forms.Label();
            this.textBox_R = new System.Windows.Forms.TextBox();
            this.textBox_G = new System.Windows.Forms.TextBox();
            this.textBox_B = new System.Windows.Forms.TextBox();
            this.textBox_H = new System.Windows.Forms.TextBox();
            this.button_Copy = new System.Windows.Forms.Button();
            this.button_Picker = new System.Windows.Forms.Button();
            this.contextMenuStrip_Copy = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyRGBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RGB)).BeginInit();
            this.contextMenuStrip_Copy.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_Main
            // 
            this.menuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Main.Name = "menuStrip_Main";
            this.menuStrip_Main.Size = new System.Drawing.Size(393, 25);
            this.menuStrip_Main.TabIndex = 0;
            this.menuStrip_Main.Text = "menuStrip_Main";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(53, 21);
            this.fileToolStripMenuItem.Text = "File(&F)";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit(&X)";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(71, 21);
            this.aboutToolStripMenuItem.Text = "About(&A)";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // pictureBox_RG
            // 
            this.pictureBox_RG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_RG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_RG.Location = new System.Drawing.Point(15, 40);
            this.pictureBox_RG.Name = "pictureBox_RG";
            this.pictureBox_RG.Size = new System.Drawing.Size(258, 258);
            this.pictureBox_RG.TabIndex = 1;
            this.pictureBox_RG.TabStop = false;
            this.pictureBox_RG.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_RG_Paint);
            this.pictureBox_RG.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_RG_MouseDown);
            this.pictureBox_RG.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_RG_MouseMove);
            // 
            // pictureBox_B
            // 
            this.pictureBox_B.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_B.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.pictureBox_B.Location = new System.Drawing.Point(286, 40);
            this.pictureBox_B.Name = "pictureBox_B";
            this.pictureBox_B.Size = new System.Drawing.Size(22, 258);
            this.pictureBox_B.TabIndex = 2;
            this.pictureBox_B.TabStop = false;
            this.pictureBox_B.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_B_Paint);
            this.pictureBox_B.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_B_MouseDown);
            this.pictureBox_B.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_B_MouseMove);
            // 
            // pictureBox_RGB
            // 
            this.pictureBox_RGB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_RGB.Location = new System.Drawing.Point(321, 40);
            this.pictureBox_RGB.Name = "pictureBox_RGB";
            this.pictureBox_RGB.Size = new System.Drawing.Size(58, 58);
            this.pictureBox_RGB.TabIndex = 3;
            this.pictureBox_RGB.TabStop = false;
            this.pictureBox_RGB.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_RGB_Paint);
            // 
            // label_R
            // 
            this.label_R.Location = new System.Drawing.Point(321, 114);
            this.label_R.Name = "label_R";
            this.label_R.Size = new System.Drawing.Size(17, 21);
            this.label_R.TabIndex = 4;
            this.label_R.Text = "R:";
            this.label_R.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_G
            // 
            this.label_G.Location = new System.Drawing.Point(321, 140);
            this.label_G.Name = "label_G";
            this.label_G.Size = new System.Drawing.Size(17, 21);
            this.label_G.TabIndex = 5;
            this.label_G.Text = "G:";
            this.label_G.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_B
            // 
            this.label_B.Location = new System.Drawing.Point(321, 166);
            this.label_B.Name = "label_B";
            this.label_B.Size = new System.Drawing.Size(17, 21);
            this.label_B.TabIndex = 6;
            this.label_B.Text = "B:";
            this.label_B.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_H
            // 
            this.label_H.Location = new System.Drawing.Point(321, 197);
            this.label_H.Name = "label_H";
            this.label_H.Size = new System.Drawing.Size(17, 21);
            this.label_H.TabIndex = 7;
            this.label_H.Text = "#";
            this.label_H.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_R
            // 
            this.textBox_R.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_R.Location = new System.Drawing.Point(337, 114);
            this.textBox_R.MaxLength = 3;
            this.textBox_R.Name = "textBox_R";
            this.textBox_R.Size = new System.Drawing.Size(42, 21);
            this.textBox_R.TabIndex = 8;
            this.textBox_R.Text = "0";
            this.textBox_R.WordWrap = false;
            this.textBox_R.TextChanged += new System.EventHandler(this.textBox_R_TextChanged);
            this.textBox_R.Enter += new System.EventHandler(this.textBox_R_Enter);
            // 
            // textBox_G
            // 
            this.textBox_G.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_G.Location = new System.Drawing.Point(337, 140);
            this.textBox_G.MaxLength = 3;
            this.textBox_G.Name = "textBox_G";
            this.textBox_G.Size = new System.Drawing.Size(42, 21);
            this.textBox_G.TabIndex = 9;
            this.textBox_G.Text = "0";
            this.textBox_G.WordWrap = false;
            this.textBox_G.TextChanged += new System.EventHandler(this.textBox_G_TextChanged);
            this.textBox_G.Enter += new System.EventHandler(this.textBox_G_Enter);
            // 
            // textBox_B
            // 
            this.textBox_B.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_B.Location = new System.Drawing.Point(337, 166);
            this.textBox_B.MaxLength = 3;
            this.textBox_B.Name = "textBox_B";
            this.textBox_B.Size = new System.Drawing.Size(42, 21);
            this.textBox_B.TabIndex = 10;
            this.textBox_B.Text = "0";
            this.textBox_B.WordWrap = false;
            this.textBox_B.TextChanged += new System.EventHandler(this.textBox_B_TextChanged);
            this.textBox_B.Enter += new System.EventHandler(this.textBox_B_Enter);
            // 
            // textBox_H
            // 
            this.textBox_H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_H.Location = new System.Drawing.Point(337, 197);
            this.textBox_H.MaxLength = 6;
            this.textBox_H.Name = "textBox_H";
            this.textBox_H.Size = new System.Drawing.Size(42, 21);
            this.textBox_H.TabIndex = 11;
            this.textBox_H.Text = "000000";
            this.textBox_H.WordWrap = false;
            this.textBox_H.TextChanged += new System.EventHandler(this.textBox_H_TextChanged);
            // 
            // button_Copy
            // 
            this.button_Copy.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_Copy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Copy.FlatAppearance.BorderSize = 0;
            this.button_Copy.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.button_Copy.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.button_Copy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Copy.ForeColor = System.Drawing.Color.White;
            this.button_Copy.Location = new System.Drawing.Point(321, 228);
            this.button_Copy.Name = "button_Copy";
            this.button_Copy.Size = new System.Drawing.Size(58, 30);
            this.button_Copy.TabIndex = 12;
            this.button_Copy.Text = "Copy";
            this.button_Copy.UseVisualStyleBackColor = false;
            this.button_Copy.Click += new System.EventHandler(this.button_Copy_Click);
            // 
            // button_Picker
            // 
            this.button_Picker.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_Picker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Picker.FlatAppearance.BorderSize = 0;
            this.button_Picker.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.button_Picker.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.button_Picker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Picker.ForeColor = System.Drawing.Color.White;
            this.button_Picker.Location = new System.Drawing.Point(321, 268);
            this.button_Picker.Name = "button_Picker";
            this.button_Picker.Size = new System.Drawing.Size(58, 30);
            this.button_Picker.TabIndex = 13;
            this.button_Picker.Text = "Picker";
            this.button_Picker.UseVisualStyleBackColor = false;
            this.button_Picker.Click += new System.EventHandler(this.button_Picker_Click);
            // 
            // contextMenuStrip_Copy
            // 
            this.contextMenuStrip_Copy.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyRGBToolStripMenuItem,
            this.copyToolStripMenuItem});
            this.contextMenuStrip_Copy.Name = "contextMenuStrip_Copy";
            this.contextMenuStrip_Copy.Size = new System.Drawing.Size(136, 48);
            // 
            // copyRGBToolStripMenuItem
            // 
            this.copyRGBToolStripMenuItem.Name = "copyRGBToolStripMenuItem";
            this.copyRGBToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.copyRGBToolStripMenuItem.Text = "Copy RGB";
            this.copyRGBToolStripMenuItem.Click += new System.EventHandler(this.copyRGBToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.copyToolStripMenuItem.Text = "Copy #...";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 310);
            this.Controls.Add(this.button_Picker);
            this.Controls.Add(this.button_Copy);
            this.Controls.Add(this.textBox_H);
            this.Controls.Add(this.textBox_B);
            this.Controls.Add(this.textBox_G);
            this.Controls.Add(this.textBox_R);
            this.Controls.Add(this.label_H);
            this.Controls.Add(this.label_B);
            this.Controls.Add(this.label_G);
            this.Controls.Add(this.label_R);
            this.Controls.Add(this.pictureBox_RGB);
            this.Controls.Add(this.pictureBox_B);
            this.Controls.Add(this.pictureBox_RG);
            this.Controls.Add(this.menuStrip_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip_Main;
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color Tool";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.menuStrip_Main.ResumeLayout(false);
            this.menuStrip_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RGB)).EndInit();
            this.contextMenuStrip_Copy.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox_RG;
        private System.Windows.Forms.PictureBox pictureBox_B;
        private System.Windows.Forms.PictureBox pictureBox_RGB;
        private System.Windows.Forms.Label label_R;
        private System.Windows.Forms.Label label_G;
        private System.Windows.Forms.Label label_B;
        private System.Windows.Forms.Label label_H;
        private System.Windows.Forms.TextBox textBox_R;
        private System.Windows.Forms.TextBox textBox_G;
        private System.Windows.Forms.TextBox textBox_B;
        private System.Windows.Forms.TextBox textBox_H;
        private System.Windows.Forms.Button button_Copy;
        private System.Windows.Forms.Button button_Picker;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Copy;
        private System.Windows.Forms.ToolStripMenuItem copyRGBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;

    }
}

