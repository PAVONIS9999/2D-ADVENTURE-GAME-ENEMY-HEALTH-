namespace _2D_ADVENTURE_GAME
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
            labelDisplay = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // labelDisplay
            // 
            labelDisplay.AutoSize = true;
            labelDisplay.Location = new Point(367, 86);
            labelDisplay.Name = "labelDisplay";
            labelDisplay.Size = new Size(75, 20);
            labelDisplay.TabIndex = 0;
            labelDisplay.Text = "label1";
            // 
            // button1
            // 
            button1.AccessibleName = "Up";
            button1.Location = new Point(55, 291);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 1;
            button1.Text = "Up";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(218, 343);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 2;
            button2.Text = "Right";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(117, 404);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 3;
            button3.Text = "down";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(-1, 388);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 4;
            button4.Text = "Left";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(labelDisplay);
            Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDisplay;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
