namespace _4
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
            label1 = new Label();
            label2 = new Label();
            ChooseOpperation = new ListBox();
            output = new TextBox();
            in1 = new TextBox();
            in2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(209, 363);
            label1.Name = "label1";
            label1.Size = new Size(111, 30);
            label1.TabIndex = 0;
            label1.Text = "Результат:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(326, 363);
            label2.Name = "label2";
            label2.Size = new Size(0, 30);
            label2.TabIndex = 1;
            // 
            // ChooseOpperation
            // 
            ChooseOpperation.FormattingEnabled = true;
            ChooseOpperation.ItemHeight = 30;
            ChooseOpperation.Items.AddRange(new object[] { "+", "-", "*", "/" });
            ChooseOpperation.Location = new Point(267, 89);
            ChooseOpperation.Name = "ChooseOpperation";
            ChooseOpperation.Size = new Size(53, 154);
            ChooseOpperation.TabIndex = 2;
            ChooseOpperation.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // output
            // 
            output.Location = new Point(332, 363);
            output.Name = "output";
            output.Size = new Size(175, 35);
            output.TabIndex = 3;
            output.TextAlign = HorizontalAlignment.Center;
            output.ReadOnly = true;

            // 
            // in1
            // 
            in1.Location = new Point(37, 89);
            in1.Name = "in1";
            in1.Size = new Size(175, 35);
            in1.TabIndex = 4;
       
            // 
            // in2
            // 
            in2.Location = new Point(376, 89);
            in2.Name = "in2";
            in2.Size = new Size(175, 35);
            in2.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(in2);
            Controls.Add(in1);
            Controls.Add(output);
            Controls.Add(ChooseOpperation);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox ChooseOpperation;
        private TextBox output;
        private TextBox in1;
        private TextBox in2;
   

    }
}
