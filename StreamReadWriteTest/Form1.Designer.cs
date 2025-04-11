namespace StreamReadWriteTest
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
            StreamTxt = new TextBox();
            label1 = new Label();
            StreamInput = new TextBox();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // StreamTxt
            // 
            StreamTxt.Location = new Point(94, 205);
            StreamTxt.Multiline = true;
            StreamTxt.Name = "StreamTxt";
            StreamTxt.Size = new Size(182, 46);
            StreamTxt.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(94, 152);
            label1.Name = "label1";
            label1.Size = new Size(123, 21);
            label1.TabIndex = 1;
            label1.Text = "Write to text File";
            // 
            // StreamInput
            // 
            StreamInput.Location = new Point(402, 73);
            StreamInput.Multiline = true;
            StreamInput.Name = "StreamInput";
            StreamInput.Size = new Size(221, 155);
            StreamInput.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(402, 38);
            label2.Name = "label2";
            label2.Size = new Size(137, 21);
            label2.TabIndex = 3;
            label2.Text = "Read from textbox";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(94, 257);
            button1.Name = "button1";
            button1.Size = new Size(182, 33);
            button1.TabIndex = 4;
            button1.Text = "Write to file";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(402, 257);
            button2.Name = "button2";
            button2.Size = new Size(182, 33);
            button2.TabIndex = 5;
            button2.Text = "Read from file";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(StreamInput);
            Controls.Add(label1);
            Controls.Add(StreamTxt);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox StreamTxt;
        private Label label1;
        private TextBox StreamInput;
        private Label label2;
        private Button button1;
        private Button button2;
    }
}
