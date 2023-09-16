namespace Temperature_Converter_2
{
    partial class tempConverterForm
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
            displayTempLabel = new Label();
            inputButton1 = new Button();
            inputButton2 = new Button();
            inputButton3 = new Button();
            inputButton6 = new Button();
            inputButton5 = new Button();
            inputButton4 = new Button();
            inputButton9 = new Button();
            inputButton8 = new Button();
            inputButton7 = new Button();
            inputButtonSign = new Button();
            inputButtonDot = new Button();
            inputButton0 = new Button();
            deleteButton = new Button();
            clearButton = new Button();
            conversionSelectorStartBox = new ComboBox();
            resultConversionLabel = new Label();
            conversionSelectionEndBox = new ComboBox();
            SuspendLayout();
            // 
            // displayTempLabel
            // 
            displayTempLabel.AutoSize = true;
            displayTempLabel.Font = new Font("Century Gothic", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            displayTempLabel.Location = new Point(121, 38);
            displayTempLabel.Name = "displayTempLabel";
            displayTempLabel.Size = new Size(0, 42);
            displayTempLabel.TabIndex = 0;
            displayTempLabel.TextChanged += autoUpdateTemperatureCalculations;
            // 
            // inputButton1
            // 
            inputButton1.BackColor = Color.Yellow;
            inputButton1.Location = new Point(121, 97);
            inputButton1.Name = "inputButton1";
            inputButton1.Size = new Size(60, 55);
            inputButton1.TabIndex = 1;
            inputButton1.Text = "1";
            inputButton1.UseVisualStyleBackColor = false;
            inputButton1.Click += buttonClickEvent;
            // 
            // inputButton2
            // 
            inputButton2.BackColor = Color.Yellow;
            inputButton2.Location = new Point(187, 97);
            inputButton2.Name = "inputButton2";
            inputButton2.Size = new Size(60, 55);
            inputButton2.TabIndex = 2;
            inputButton2.Text = "2";
            inputButton2.UseVisualStyleBackColor = false;
            inputButton2.Click += buttonClickEvent;
            // 
            // inputButton3
            // 
            inputButton3.BackColor = Color.Yellow;
            inputButton3.Location = new Point(253, 97);
            inputButton3.Name = "inputButton3";
            inputButton3.Size = new Size(60, 55);
            inputButton3.TabIndex = 3;
            inputButton3.Text = "3";
            inputButton3.UseVisualStyleBackColor = false;
            inputButton3.Click += buttonClickEvent;
            // 
            // inputButton6
            // 
            inputButton6.BackColor = Color.Yellow;
            inputButton6.Location = new Point(253, 158);
            inputButton6.Name = "inputButton6";
            inputButton6.Size = new Size(60, 55);
            inputButton6.TabIndex = 6;
            inputButton6.Text = "6";
            inputButton6.UseVisualStyleBackColor = false;
            inputButton6.Click += buttonClickEvent;
            // 
            // inputButton5
            // 
            inputButton5.BackColor = Color.Yellow;
            inputButton5.Location = new Point(187, 158);
            inputButton5.Name = "inputButton5";
            inputButton5.Size = new Size(60, 55);
            inputButton5.TabIndex = 5;
            inputButton5.Text = "5";
            inputButton5.UseVisualStyleBackColor = false;
            inputButton5.Click += buttonClickEvent;
            // 
            // inputButton4
            // 
            inputButton4.BackColor = Color.Yellow;
            inputButton4.Location = new Point(121, 158);
            inputButton4.Name = "inputButton4";
            inputButton4.Size = new Size(60, 55);
            inputButton4.TabIndex = 4;
            inputButton4.Text = "4";
            inputButton4.UseVisualStyleBackColor = false;
            inputButton4.Click += buttonClickEvent;
            // 
            // inputButton9
            // 
            inputButton9.BackColor = Color.Yellow;
            inputButton9.Location = new Point(253, 219);
            inputButton9.Name = "inputButton9";
            inputButton9.Size = new Size(60, 55);
            inputButton9.TabIndex = 9;
            inputButton9.Text = "9";
            inputButton9.UseVisualStyleBackColor = false;
            inputButton9.Click += buttonClickEvent;
            // 
            // inputButton8
            // 
            inputButton8.BackColor = Color.Yellow;
            inputButton8.Location = new Point(187, 219);
            inputButton8.Name = "inputButton8";
            inputButton8.Size = new Size(60, 55);
            inputButton8.TabIndex = 8;
            inputButton8.Text = "8";
            inputButton8.UseVisualStyleBackColor = false;
            inputButton8.Click += buttonClickEvent;
            // 
            // inputButton7
            // 
            inputButton7.BackColor = Color.Yellow;
            inputButton7.Location = new Point(121, 219);
            inputButton7.Name = "inputButton7";
            inputButton7.Size = new Size(60, 55);
            inputButton7.TabIndex = 7;
            inputButton7.Text = "7";
            inputButton7.UseVisualStyleBackColor = false;
            inputButton7.Click += buttonClickEvent;
            // 
            // inputButtonSign
            // 
            inputButtonSign.BackColor = Color.Yellow;
            inputButtonSign.Location = new Point(253, 280);
            inputButtonSign.Name = "inputButtonSign";
            inputButtonSign.Size = new Size(60, 55);
            inputButtonSign.TabIndex = 12;
            inputButtonSign.Text = "+/-";
            inputButtonSign.UseVisualStyleBackColor = false;
            inputButtonSign.Click += inputButtonSign_Click;
            // 
            // inputButtonDot
            // 
            inputButtonDot.BackColor = Color.Yellow;
            inputButtonDot.Location = new Point(187, 280);
            inputButtonDot.Name = "inputButtonDot";
            inputButtonDot.Size = new Size(60, 55);
            inputButtonDot.TabIndex = 11;
            inputButtonDot.Text = ".";
            inputButtonDot.UseVisualStyleBackColor = false;
            inputButtonDot.Click += inputButtonDot_Click;
            // 
            // inputButton0
            // 
            inputButton0.BackColor = Color.Yellow;
            inputButton0.Location = new Point(121, 280);
            inputButton0.Name = "inputButton0";
            inputButton0.Size = new Size(60, 55);
            inputButton0.TabIndex = 10;
            inputButton0.Text = "0";
            inputButton0.UseVisualStyleBackColor = false;
            inputButton0.Click += buttonClickEvent;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.DarkOrange;
            deleteButton.Location = new Point(355, 280);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(192, 55);
            deleteButton.TabIndex = 13;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.DarkOrange;
            clearButton.Location = new Point(553, 280);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(192, 55);
            clearButton.TabIndex = 14;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // conversionSelectorStartBox
            // 
            conversionSelectorStartBox.FormattingEnabled = true;
            conversionSelectorStartBox.Location = new Point(355, 51);
            conversionSelectorStartBox.Name = "conversionSelectorStartBox";
            conversionSelectorStartBox.Size = new Size(390, 30);
            conversionSelectorStartBox.TabIndex = 15;
            conversionSelectorStartBox.Tag = "Select conversion mode";
            conversionSelectorStartBox.SelectedIndexChanged += conversionSelectorStartBox_SelectedIndexChanged;
            // 
            // resultConversionLabel
            // 
            resultConversionLabel.AutoSize = true;
            resultConversionLabel.Font = new Font("Century Gothic", 72F, FontStyle.Regular, GraphicsUnit.Point);
            resultConversionLabel.Location = new Point(445, 158);
            resultConversionLabel.Name = "resultConversionLabel";
            resultConversionLabel.Size = new Size(102, 115);
            resultConversionLabel.TabIndex = 17;
            resultConversionLabel.Text = "0";
            // 
            // conversionSelectionEndBox
            // 
            conversionSelectionEndBox.FormattingEnabled = true;
            conversionSelectionEndBox.Location = new Point(355, 97);
            conversionSelectionEndBox.Name = "conversionSelectionEndBox";
            conversionSelectionEndBox.Size = new Size(390, 30);
            conversionSelectionEndBox.TabIndex = 18;
            conversionSelectionEndBox.Tag = "Select conversion mode";
            conversionSelectionEndBox.SelectedIndexChanged += conversionSelectionEndBox_SelectedIndexChanged;
            // 
            // tempConverterForm
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Orange;
            ClientSize = new Size(958, 388);
            Controls.Add(conversionSelectionEndBox);
            Controls.Add(resultConversionLabel);
            Controls.Add(conversionSelectorStartBox);
            Controls.Add(clearButton);
            Controls.Add(deleteButton);
            Controls.Add(inputButtonSign);
            Controls.Add(inputButtonDot);
            Controls.Add(inputButton0);
            Controls.Add(inputButton9);
            Controls.Add(inputButton8);
            Controls.Add(inputButton7);
            Controls.Add(inputButton6);
            Controls.Add(inputButton5);
            Controls.Add(inputButton4);
            Controls.Add(inputButton3);
            Controls.Add(inputButton2);
            Controls.Add(inputButton1);
            Controls.Add(displayTempLabel);
            Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "tempConverterForm";
            Text = "Temperature Converter by Frank Berrocal";
            Load += tempConverterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label displayTempLabel;
        private Button inputButton1;
        private Button inputButton2;
        private Button inputButton3;
        private Button inputButton6;
        private Button inputButton5;
        private Button inputButton4;
        private Button inputButton9;
        private Button inputButton8;
        private Button inputButton7;
        private Button inputButtonSign;
        private Button inputButtonDot;
        private Button inputButton0;
        private Button deleteButton;
        private Button clearButton;
        private ComboBox conversionSelectorStartBox;
        private Label resultConversionLabel;
        private ComboBox conversionSelectionEndBox;
    }
}