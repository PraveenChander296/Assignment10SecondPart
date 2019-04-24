namespace Assignment10_3
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.requiredHoursLabel = new System.Windows.Forms.TextBox();
            this.getHoursButton = new System.Windows.Forms.Button();
            this.infoSystemsRadioButton = new System.Windows.Forms.RadioButton();
            this.softwareEngineeringRadioButton = new System.Windows.Forms.RadioButton();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID Number: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 182);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Academic Track: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 247);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Required Hours: ";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(333, 77);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(132, 22);
            this.nameTextBox.TabIndex = 5;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(333, 119);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(132, 22);
            this.idTextBox.TabIndex = 6;
            // 
            // requiredHoursLabel
            // 
            this.requiredHoursLabel.Location = new System.Drawing.Point(333, 244);
            this.requiredHoursLabel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.requiredHoursLabel.Name = "requiredHoursLabel";
            this.requiredHoursLabel.Size = new System.Drawing.Size(132, 22);
            this.requiredHoursLabel.TabIndex = 7;
            // 
            // getHoursButton
            // 
            this.getHoursButton.Location = new System.Drawing.Point(202, 306);
            this.getHoursButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.getHoursButton.Name = "getHoursButton";
            this.getHoursButton.Size = new System.Drawing.Size(137, 63);
            this.getHoursButton.TabIndex = 8;
            this.getHoursButton.Text = "Get Required Hours";
            this.getHoursButton.UseVisualStyleBackColor = true;
            this.getHoursButton.Click += new System.EventHandler(this.getHoursButton_Click);
            // 
            // infoSystemsRadioButton
            // 
            this.infoSystemsRadioButton.AutoSize = true;
            this.infoSystemsRadioButton.Location = new System.Drawing.Point(324, 164);
            this.infoSystemsRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.infoSystemsRadioButton.Name = "infoSystemsRadioButton";
            this.infoSystemsRadioButton.Size = new System.Drawing.Size(156, 21);
            this.infoSystemsRadioButton.TabIndex = 9;
            this.infoSystemsRadioButton.TabStop = true;
            this.infoSystemsRadioButton.Text = "Information Systems";
            this.infoSystemsRadioButton.UseVisualStyleBackColor = true;
            // 
            // softwareEngineeringRadioButton
            // 
            this.softwareEngineeringRadioButton.AutoSize = true;
            this.softwareEngineeringRadioButton.Location = new System.Drawing.Point(324, 193);
            this.softwareEngineeringRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.softwareEngineeringRadioButton.Name = "softwareEngineeringRadioButton";
            this.softwareEngineeringRadioButton.Size = new System.Drawing.Size(164, 21);
            this.softwareEngineeringRadioButton.TabIndex = 10;
            this.softwareEngineeringRadioButton.TabStop = true;
            this.softwareEngineeringRadioButton.Text = "Software Engineering";
            this.softwareEngineeringRadioButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(365, 306);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 63);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 486);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.softwareEngineeringRadioButton);
            this.Controls.Add(this.infoSystemsRadioButton);
            this.Controls.Add(this.getHoursButton);
            this.Controls.Add(this.requiredHoursLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Computer Science Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox requiredHoursLabel;
        private System.Windows.Forms.Button getHoursButton;
        private System.Windows.Forms.RadioButton infoSystemsRadioButton;
        private System.Windows.Forms.RadioButton softwareEngineeringRadioButton;
        private System.Windows.Forms.Button exitButton;
    }
}

