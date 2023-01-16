namespace AbstractClass
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
            this.btnTestAbstractClass = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnTestAbstractClass
            // 
            this.btnTestAbstractClass.Location = new System.Drawing.Point(41, 72);
            this.btnTestAbstractClass.Name = "btnTestAbstractClass";
            this.btnTestAbstractClass.Size = new System.Drawing.Size(219, 47);
            this.btnTestAbstractClass.TabIndex = 0;
            this.btnTestAbstractClass.Text = "Test Abstract Class";
            this.btnTestAbstractClass.UseVisualStyleBackColor = true;
            this.btnTestAbstractClass.Click += new System.EventHandler(this.btnTestAbstractClass_Click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(291, 63);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(414, 319);
            this.txtDisplay.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.btnTestAbstractClass);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnTestAbstractClass;
        private TextBox txtDisplay;
    }
}