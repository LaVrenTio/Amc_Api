namespace Amc_Api
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
            components = new System.ComponentModel.Container();
            Get_ink_btn = new Button();
            InkValue_text = new TextBox();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // Get_ink_btn
            // 
            Get_ink_btn.Location = new Point(358, 199);
            Get_ink_btn.Name = "Get_ink_btn";
            Get_ink_btn.Size = new Size(94, 29);
            Get_ink_btn.TabIndex = 0;
            Get_ink_btn.Text = "Get Ink Level";
            Get_ink_btn.UseVisualStyleBackColor = true;
            Get_ink_btn.Click += Get_ink_btn_Click;
            Get_ink_btn.MouseMove += Get_ink_btn_MouseMove;
            // 
            // InkValue_text
            // 
            InkValue_text.Location = new Point(32, 87);
            InkValue_text.Name = "InkValue_text";
            InkValue_text.PlaceholderText = "Ink Levevl";
            InkValue_text.Size = new Size(125, 27);
            InkValue_text.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(InkValue_text);
            Controls.Add(Get_ink_btn);
            Name = "Form1";
            Text = "Amc_Api test";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Get_ink_btn;
        private TextBox InkValue_text;
        private ToolTip toolTip1;
    }
}
