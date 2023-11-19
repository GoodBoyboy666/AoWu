namespace 嗷呜语言翻译器
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.translate_btn = new System.Windows.Forms.Button();
            this.source_textbox = new System.Windows.Forms.RichTextBox();
            this.translated_textbox = new System.Windows.Forms.RichTextBox();
            this.restore_btn = new System.Windows.Forms.Button();
            this.copy_btn = new System.Windows.Forms.Button();
            this.clean_btn = new System.Windows.Forms.Button();
            this.sor_clean_btn = new System.Windows.Forms.Button();
            this.sor_copy_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.然鹅并没有什么菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.没有菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.有菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.菜单ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.介绍ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // translate_btn
            // 
            this.translate_btn.Location = new System.Drawing.Point(586, 131);
            this.translate_btn.Name = "translate_btn";
            this.translate_btn.Size = new System.Drawing.Size(112, 34);
            this.translate_btn.TabIndex = 0;
            this.translate_btn.Text = ">>>";
            this.translate_btn.UseVisualStyleBackColor = true;
            this.translate_btn.Click += new System.EventHandler(this.translate_btn_Click);
            // 
            // source_textbox
            // 
            this.source_textbox.Location = new System.Drawing.Point(76, 71);
            this.source_textbox.Name = "source_textbox";
            this.source_textbox.Size = new System.Drawing.Size(405, 439);
            this.source_textbox.TabIndex = 1;
            this.source_textbox.Text = "";
            // 
            // translated_textbox
            // 
            this.translated_textbox.Location = new System.Drawing.Point(804, 71);
            this.translated_textbox.Name = "translated_textbox";
            this.translated_textbox.Size = new System.Drawing.Size(405, 439);
            this.translated_textbox.TabIndex = 2;
            this.translated_textbox.Text = "";
            // 
            // restore_btn
            // 
            this.restore_btn.Location = new System.Drawing.Point(586, 386);
            this.restore_btn.Name = "restore_btn";
            this.restore_btn.Size = new System.Drawing.Size(112, 34);
            this.restore_btn.TabIndex = 3;
            this.restore_btn.Text = "<<<";
            this.restore_btn.UseVisualStyleBackColor = true;
            this.restore_btn.Click += new System.EventHandler(this.restore_btn_Click);
            // 
            // copy_btn
            // 
            this.copy_btn.Location = new System.Drawing.Point(1030, 554);
            this.copy_btn.Name = "copy_btn";
            this.copy_btn.Size = new System.Drawing.Size(179, 34);
            this.copy_btn.TabIndex = 4;
            this.copy_btn.Text = "复制";
            this.copy_btn.UseVisualStyleBackColor = true;
            this.copy_btn.Click += new System.EventHandler(this.copy_btn_Click);
            // 
            // clean_btn
            // 
            this.clean_btn.Location = new System.Drawing.Point(804, 554);
            this.clean_btn.Name = "clean_btn";
            this.clean_btn.Size = new System.Drawing.Size(185, 34);
            this.clean_btn.TabIndex = 5;
            this.clean_btn.Text = "清除";
            this.clean_btn.UseVisualStyleBackColor = true;
            this.clean_btn.Click += new System.EventHandler(this.clean_btn_Click);
            // 
            // sor_clean_btn
            // 
            this.sor_clean_btn.Location = new System.Drawing.Point(76, 554);
            this.sor_clean_btn.Name = "sor_clean_btn";
            this.sor_clean_btn.Size = new System.Drawing.Size(178, 34);
            this.sor_clean_btn.TabIndex = 6;
            this.sor_clean_btn.Text = "清除";
            this.sor_clean_btn.UseVisualStyleBackColor = true;
            this.sor_clean_btn.Click += new System.EventHandler(this.sor_clean_btn_Click);
            // 
            // sor_copy_btn
            // 
            this.sor_copy_btn.Location = new System.Drawing.Point(302, 554);
            this.sor_copy_btn.Name = "sor_copy_btn";
            this.sor_copy_btn.Size = new System.Drawing.Size(179, 34);
            this.sor_copy_btn.TabIndex = 7;
            this.sor_copy_btn.Text = "复制";
            this.sor_copy_btn.UseVisualStyleBackColor = true;
            this.sor_copy_btn.Click += new System.EventHandler(this.sor_copy_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "原文：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(723, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "嗷呜语：";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.菜单ToolStripMenuItem,
            this.关于ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.介绍ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1310, 32);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 菜单ToolStripMenuItem
            // 
            this.菜单ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.然鹅并没有什么菜单ToolStripMenuItem,
            this.没有菜单ToolStripMenuItem,
            this.有菜单ToolStripMenuItem,
            this.菜单ToolStripMenuItem1,
            this.单ToolStripMenuItem,
            this.toolStripMenuItem2});
            this.菜单ToolStripMenuItem.Name = "菜单ToolStripMenuItem";
            this.菜单ToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.菜单ToolStripMenuItem.Text = "菜单";
            // 
            // 然鹅并没有什么菜单ToolStripMenuItem
            // 
            this.然鹅并没有什么菜单ToolStripMenuItem.Name = "然鹅并没有什么菜单ToolStripMenuItem";
            this.然鹅并没有什么菜单ToolStripMenuItem.Size = new System.Drawing.Size(272, 34);
            this.然鹅并没有什么菜单ToolStripMenuItem.Text = "然鹅并没有什么菜单";
            // 
            // 没有菜单ToolStripMenuItem
            // 
            this.没有菜单ToolStripMenuItem.Name = "没有菜单ToolStripMenuItem";
            this.没有菜单ToolStripMenuItem.Size = new System.Drawing.Size(272, 34);
            this.没有菜单ToolStripMenuItem.Text = "没有菜单";
            // 
            // 有菜单ToolStripMenuItem
            // 
            this.有菜单ToolStripMenuItem.Name = "有菜单ToolStripMenuItem";
            this.有菜单ToolStripMenuItem.Size = new System.Drawing.Size(272, 34);
            this.有菜单ToolStripMenuItem.Text = "有菜单";
            // 
            // 菜单ToolStripMenuItem1
            // 
            this.菜单ToolStripMenuItem1.Name = "菜单ToolStripMenuItem1";
            this.菜单ToolStripMenuItem1.Size = new System.Drawing.Size(272, 34);
            this.菜单ToolStripMenuItem1.Text = "菜单";
            // 
            // 单ToolStripMenuItem
            // 
            this.单ToolStripMenuItem.Name = "单ToolStripMenuItem";
            this.单ToolStripMenuItem.Size = new System.Drawing.Size(272, 34);
            this.单ToolStripMenuItem.Text = "单";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(272, 34);
            this.toolStripMenuItem2.Text = " ";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(16, 28);
            // 
            // 介绍ToolStripMenuItem
            // 
            this.介绍ToolStripMenuItem.Name = "介绍ToolStripMenuItem";
            this.介绍ToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.介绍ToolStripMenuItem.Text = "介绍";
            this.介绍ToolStripMenuItem.Click += new System.EventHandler(this.介绍ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 649);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sor_copy_btn);
            this.Controls.Add(this.sor_clean_btn);
            this.Controls.Add(this.clean_btn);
            this.Controls.Add(this.copy_btn);
            this.Controls.Add(this.restore_btn);
            this.Controls.Add(this.translated_textbox);
            this.Controls.Add(this.source_textbox);
            this.Controls.Add(this.translate_btn);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "嗷呜语言翻译器v1.1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button translate_btn;
        private RichTextBox source_textbox;
        private RichTextBox translated_textbox;
        private Button restore_btn;
        private Button copy_btn;
        private Button clean_btn;
        private Button sor_clean_btn;
        private Button sor_copy_btn;
        private Label label1;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 菜单ToolStripMenuItem;
        private ToolStripMenuItem 关于ToolStripMenuItem;
        private ToolStripMenuItem 然鹅并没有什么菜单ToolStripMenuItem;
        private ToolStripMenuItem 没有菜单ToolStripMenuItem;
        private ToolStripMenuItem 有菜单ToolStripMenuItem;
        private ToolStripMenuItem 菜单ToolStripMenuItem1;
        private ToolStripMenuItem 单ToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem 介绍ToolStripMenuItem;
    }
}