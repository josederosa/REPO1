namespace WinFormsApp1
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
            listBox1 = new ListBox();
            btnPopulate = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(190, 126);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(409, 289);
            listBox1.TabIndex = 0;
            // 
            // btnPopulate
            // 
            btnPopulate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnPopulate.Location = new Point(315, 40);
            btnPopulate.Name = "btnPopulate";
            btnPopulate.Size = new Size(156, 44);
            btnPopulate.TabIndex = 1;
            btnPopulate.Text = "Populate";
            btnPopulate.UseVisualStyleBackColor = true;
            btnPopulate.Click += btnPopulate_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(677, 386);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(96, 34);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(btnPopulate);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button btnPopulate;
        private Button btnClose;
    }
}
