namespace CalculatorGUI
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
            this.leftOperatorTextBox = new System.Windows.Forms.TextBox();
            this.rightOperatorTextBox = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.comboBoxOperator = new System.Windows.Forms.ComboBox();
            this.equalButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // leftOperatorTextBox
            // 
            this.leftOperatorTextBox.Location = new System.Drawing.Point(64, 26);
            this.leftOperatorTextBox.Name = "leftOperatorTextBox";
            this.leftOperatorTextBox.Size = new System.Drawing.Size(125, 27);
            this.leftOperatorTextBox.TabIndex = 0;
            // 
            // rightOperatorTextBox
            // 
            this.rightOperatorTextBox.Location = new System.Drawing.Point(280, 26);
            this.rightOperatorTextBox.Name = "rightOperatorTextBox";
            this.rightOperatorTextBox.Size = new System.Drawing.Size(125, 27);
            this.rightOperatorTextBox.TabIndex = 1;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(461, 29);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(18, 20);
            this.resultLabel.TabIndex = 2;
            this.resultLabel.Text = "...";
            // 
            // comboBoxOperator
            // 
            this.comboBoxOperator.FormattingEnabled = true;
            this.comboBoxOperator.Location = new System.Drawing.Point(195, 26);
            this.comboBoxOperator.Name = "comboBoxOperator";
            this.comboBoxOperator.Size = new System.Drawing.Size(62, 28);
            this.comboBoxOperator.TabIndex = 3;
            // 
            // equalButton
            // 
            this.equalButton.Location = new System.Drawing.Point(420, 25);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(35, 29);
            this.equalButton.TabIndex = 4;
            this.equalButton.Text = "=";
            this.equalButton.UseVisualStyleBackColor = true;
            this.equalButton.Click += new System.EventHandler(this.equalButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.equalButton);
            this.Controls.Add(this.comboBoxOperator);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.rightOperatorTextBox);
            this.Controls.Add(this.leftOperatorTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox leftOperatorTextBox;
        private TextBox rightOperatorTextBox;
        private Label resultLabel;
        private ComboBox comboBoxOperator;
        private Button equalButton;
    }
}