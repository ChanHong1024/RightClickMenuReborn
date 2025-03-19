namespace RightClickMenuReborn
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            groupBox1 = new GroupBox();
            btnEnable = new CheckBox();
            listBoxLog = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEnable);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(384, 47);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Win10 Right Click Menu";
            // 
            // btnEnable
            // 
            btnEnable.AutoSize = true;
            btnEnable.Location = new Point(6, 22);
            btnEnable.Name = "btnEnable";
            btnEnable.Size = new Size(65, 19);
            btnEnable.TabIndex = 1;
            btnEnable.Text = "Enable";
            btnEnable.UseVisualStyleBackColor = true;
            btnEnable.CheckedChanged += btnEnable_CheckedChanged;
            // 
            // listBoxLog
            // 
            listBoxLog.FormattingEnabled = true;
            listBoxLog.HorizontalScrollbar = true;
            listBoxLog.ItemHeight = 15;
            listBoxLog.Location = new Point(12, 65);
            listBoxLog.Name = "listBoxLog";
            listBoxLog.Size = new Size(384, 124);
            listBoxLog.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 201);
            Controls.Add(listBoxLog);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Right Click Menu Reborn";
            Load += MainForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private CheckBox btnEnable;
        private ListBox listBoxLog;
    }
}
