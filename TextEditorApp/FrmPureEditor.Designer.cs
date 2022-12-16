namespace TextEditorApp
{
    partial class FrmPureEditor
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
            this.richTextBoxEditor = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBoxEditor
            // 
            this.richTextBoxEditor.Location = new System.Drawing.Point(2, -1);
            this.richTextBoxEditor.Name = "richTextBoxEditor";
            this.richTextBoxEditor.Size = new System.Drawing.Size(100, 96);
            this.richTextBoxEditor.TabIndex = 0;
            this.richTextBoxEditor.Text = "";
            // 
            // FrmPureEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 682);
            this.Controls.Add(this.richTextBoxEditor);
            this.Name = "FrmPureEditor";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxEditor;
    }
}

