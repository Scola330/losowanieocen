namespace losowanieocen
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
            randomiseButton = new Button();
            groupBox1 = new GroupBox();
            groupBox4 = new GroupBox();
            groupBox6 = new GroupBox();
            groupBox7 = new GroupBox();
            groupBox8 = new GroupBox();
            numbern3Label = new Label();
            groupBox3 = new GroupBox();
            numbern2Label = new Label();
            groupBox2 = new GroupBox();
            numbern1Label = new Label();
            groupBox5 = new GroupBox();
            WynikrRichTextBox = new RichTextBox();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // randomiseButton
            // 
            randomiseButton.Location = new Point(39, 151);
            randomiseButton.Name = "randomiseButton";
            randomiseButton.Size = new Size(229, 33);
            randomiseButton.TabIndex = 0;
            randomiseButton.Text = "Losuj";
            randomiseButton.UseVisualStyleBackColor = true;
            randomiseButton.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(39, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(229, 100);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ocena : ";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(groupBox6);
            groupBox4.Controls.Add(groupBox7);
            groupBox4.Controls.Add(groupBox8);
            groupBox4.Location = new Point(154, 22);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(68, 72);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            // 
            // groupBox6
            // 
            groupBox6.Location = new Point(148, 0);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(68, 72);
            groupBox6.TabIndex = 7;
            groupBox6.TabStop = false;
            // 
            // groupBox7
            // 
            groupBox7.Location = new Point(74, 0);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(68, 72);
            groupBox7.TabIndex = 6;
            groupBox7.TabStop = false;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(numbern3Label);
            groupBox8.Location = new Point(0, 0);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(68, 72);
            groupBox8.TabIndex = 5;
            groupBox8.TabStop = false;
            // 
            // numbern3Label
            // 
            numbern3Label.AutoSize = true;
            numbern3Label.Location = new Point(25, 34);
            numbern3Label.Name = "numbern3Label";
            numbern3Label.Size = new Size(16, 15);
            numbern3Label.TabIndex = 2;
            numbern3Label.Text = "...";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(numbern2Label);
            groupBox3.Location = new Point(80, 22);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(68, 72);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            // 
            // numbern2Label
            // 
            numbern2Label.AutoSize = true;
            numbern2Label.Location = new Point(25, 34);
            numbern2Label.Name = "numbern2Label";
            numbern2Label.Size = new Size(16, 15);
            numbern2Label.TabIndex = 1;
            numbern2Label.Text = "...";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(numbern1Label);
            groupBox2.Location = new Point(6, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(68, 72);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // numbern1Label
            // 
            numbern1Label.AutoSize = true;
            numbern1Label.Location = new Point(24, 34);
            numbern1Label.Name = "numbern1Label";
            numbern1Label.Size = new Size(16, 15);
            numbern1Label.TabIndex = 0;
            numbern1Label.Text = "...";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(WynikrRichTextBox);
            groupBox5.Location = new Point(289, 12);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(378, 206);
            groupBox5.TabIndex = 2;
            groupBox5.TabStop = false;
            groupBox5.Text = "ostatnio wylosowane :";
            // 
            // WynikrRichTextBox
            // 
            WynikrRichTextBox.BackColor = SystemColors.ActiveCaptionText;
            WynikrRichTextBox.Location = new Point(5, 22);
            WynikrRichTextBox.Name = "WynikrRichTextBox";
            WynikrRichTextBox.ReadOnly = true;
            WynikrRichTextBox.Size = new Size(367, 178);
            WynikrRichTextBox.TabIndex = 0;
            WynikrRichTextBox.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 230);
            Controls.Add(groupBox5);
            Controls.Add(groupBox1);
            Controls.Add(randomiseButton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button randomiseButton;
        private GroupBox groupBox1;
        private GroupBox groupBox4;
        private GroupBox groupBox6;
        private GroupBox groupBox7;
        private GroupBox groupBox8;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private GroupBox groupBox5;
        private RichTextBox WynikrRichTextBox;
        private Label numbern3Label;
        private Label numbern2Label;
        private Label numbern1Label;
    }
}
