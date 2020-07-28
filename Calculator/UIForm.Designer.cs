namespace Calculator
{
    partial class Main
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
            Calculator.Subtraction subtraction1 = new Calculator.Subtraction();
            Calculator.Multiplication multiplication1 = new Calculator.Multiplication();
            Calculator.Division division1 = new Calculator.Division();
            Calculator.Addition addition1 = new Calculator.Addition();
            this.OneButton = new System.Windows.Forms.Button();
            this.NumberTextBox = new System.Windows.Forms.TextBox();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.IsEqualToButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.ClipboardTextBox = new System.Windows.Forms.TextBox();
            this.SeparatorButton = new System.Windows.Forms.Button();
            this.ZeroDecimalButton = new System.Windows.Forms.Button();
            this.OneDecimalButton = new System.Windows.Forms.Button();
            this.TwoDecimalButton = new System.Windows.Forms.Button();
            this.EquationTextBox = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.NegativeButton = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.TimesButton = new System.Windows.Forms.Button();
            this.DividedByButton = new System.Windows.Forms.Button();
            this.PlusButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OneButton
            // 
            this.OneButton.BackColor = System.Drawing.Color.Lavender;
            this.OneButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.OneButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.OneButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.OneButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.OneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OneButton.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OneButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OneButton.Location = new System.Drawing.Point(12, 543);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(100, 100);
            this.OneButton.TabIndex = 0;
            this.OneButton.TabStop = false;
            this.OneButton.Tag = "1";
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = false;
            this.OneButton.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.NumberTextBox.Font = new System.Drawing.Font("Calibri", 57F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberTextBox.Location = new System.Drawing.Point(12, 119);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.ReadOnly = true;
            this.NumberTextBox.Size = new System.Drawing.Size(524, 100);
            this.NumberTextBox.TabIndex = 20;
            this.NumberTextBox.TabStop = false;
            this.NumberTextBox.Text = "0";
            this.NumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumberTextBox.WordWrap = false;
            // 
            // ThreeButton
            // 
            this.ThreeButton.BackColor = System.Drawing.Color.Lavender;
            this.ThreeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ThreeButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ThreeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.ThreeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.ThreeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThreeButton.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThreeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ThreeButton.Location = new System.Drawing.Point(224, 543);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(100, 100);
            this.ThreeButton.TabIndex = 2;
            this.ThreeButton.TabStop = false;
            this.ThreeButton.Tag = "3";
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = false;
            this.ThreeButton.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // TwoButton
            // 
            this.TwoButton.BackColor = System.Drawing.Color.Lavender;
            this.TwoButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.TwoButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TwoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.TwoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.TwoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TwoButton.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TwoButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TwoButton.Location = new System.Drawing.Point(118, 543);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(100, 100);
            this.TwoButton.TabIndex = 3;
            this.TwoButton.TabStop = false;
            this.TwoButton.Tag = "2";
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = false;
            this.TwoButton.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // IsEqualToButton
            // 
            this.IsEqualToButton.BackColor = System.Drawing.Color.Lavender;
            this.IsEqualToButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.IsEqualToButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.IsEqualToButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.IsEqualToButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.IsEqualToButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IsEqualToButton.Font = new System.Drawing.Font("Impact", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsEqualToButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.IsEqualToButton.Location = new System.Drawing.Point(330, 649);
            this.IsEqualToButton.Name = "IsEqualToButton";
            this.IsEqualToButton.Size = new System.Drawing.Size(100, 100);
            this.IsEqualToButton.TabIndex = 1;
            this.IsEqualToButton.Text = "=";
            this.IsEqualToButton.UseVisualStyleBackColor = false;
            this.IsEqualToButton.Click += new System.EventHandler(this.IsEqualToButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.Lavender;
            this.ClearButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ClearButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClearButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.ClearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClearButton.Location = new System.Drawing.Point(436, 225);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(100, 100);
            this.ClearButton.TabIndex = 6;
            this.ClearButton.TabStop = false;
            this.ClearButton.Text = "C";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // NineButton
            // 
            this.NineButton.BackColor = System.Drawing.Color.Lavender;
            this.NineButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.NineButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NineButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.NineButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.NineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NineButton.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NineButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NineButton.Location = new System.Drawing.Point(224, 331);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(100, 100);
            this.NineButton.TabIndex = 7;
            this.NineButton.TabStop = false;
            this.NineButton.Tag = "9";
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = false;
            this.NineButton.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // ZeroButton
            // 
            this.ZeroButton.BackColor = System.Drawing.Color.Lavender;
            this.ZeroButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ZeroButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ZeroButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.ZeroButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.ZeroButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZeroButton.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZeroButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ZeroButton.Location = new System.Drawing.Point(118, 649);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(100, 100);
            this.ZeroButton.TabIndex = 8;
            this.ZeroButton.TabStop = false;
            this.ZeroButton.Tag = "0";
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = false;
            this.ZeroButton.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // SevenButton
            // 
            this.SevenButton.BackColor = System.Drawing.Color.Lavender;
            this.SevenButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SevenButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.SevenButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.SevenButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.SevenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SevenButton.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SevenButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SevenButton.Location = new System.Drawing.Point(12, 331);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(100, 100);
            this.SevenButton.TabIndex = 9;
            this.SevenButton.TabStop = false;
            this.SevenButton.Tag = "7";
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = false;
            this.SevenButton.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // SixButton
            // 
            this.SixButton.BackColor = System.Drawing.Color.Lavender;
            this.SixButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SixButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.SixButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.SixButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.SixButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SixButton.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SixButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SixButton.Location = new System.Drawing.Point(224, 437);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(100, 100);
            this.SixButton.TabIndex = 10;
            this.SixButton.TabStop = false;
            this.SixButton.Tag = "6";
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = false;
            this.SixButton.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // FiveButton
            // 
            this.FiveButton.BackColor = System.Drawing.Color.Lavender;
            this.FiveButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.FiveButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.FiveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.FiveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.FiveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FiveButton.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FiveButton.Location = new System.Drawing.Point(118, 437);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(100, 100);
            this.FiveButton.TabIndex = 11;
            this.FiveButton.TabStop = false;
            this.FiveButton.Tag = "5";
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = false;
            this.FiveButton.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // FourButton
            // 
            this.FourButton.BackColor = System.Drawing.Color.Lavender;
            this.FourButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.FourButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.FourButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.FourButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.FourButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FourButton.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FourButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FourButton.Location = new System.Drawing.Point(12, 437);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(100, 100);
            this.FourButton.TabIndex = 12;
            this.FourButton.TabStop = false;
            this.FourButton.Tag = "4";
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = false;
            this.FourButton.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // EightButton
            // 
            this.EightButton.BackColor = System.Drawing.Color.Lavender;
            this.EightButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.EightButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.EightButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.EightButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.EightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EightButton.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EightButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EightButton.Location = new System.Drawing.Point(118, 331);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(100, 100);
            this.EightButton.TabIndex = 16;
            this.EightButton.TabStop = false;
            this.EightButton.Tag = "8";
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = false;
            this.EightButton.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // ClipboardTextBox
            // 
            this.ClipboardTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClipboardTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClipboardTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClipboardTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ClipboardTextBox.Location = new System.Drawing.Point(12, 21);
            this.ClipboardTextBox.Name = "ClipboardTextBox";
            this.ClipboardTextBox.ReadOnly = true;
            this.ClipboardTextBox.Size = new System.Drawing.Size(524, 20);
            this.ClipboardTextBox.TabIndex = 17;
            this.ClipboardTextBox.TabStop = false;
            this.ClipboardTextBox.Text = "Clipboard ";
            this.ClipboardTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ClipboardTextBox.WordWrap = false;
            // 
            // SeparatorButton
            // 
            this.SeparatorButton.BackColor = System.Drawing.Color.Lavender;
            this.SeparatorButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SeparatorButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.SeparatorButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.SeparatorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.SeparatorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeparatorButton.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeparatorButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SeparatorButton.Location = new System.Drawing.Point(224, 649);
            this.SeparatorButton.Name = "SeparatorButton";
            this.SeparatorButton.Size = new System.Drawing.Size(100, 100);
            this.SeparatorButton.TabIndex = 18;
            this.SeparatorButton.TabStop = false;
            this.SeparatorButton.Tag = ".";
            this.SeparatorButton.Text = ".";
            this.SeparatorButton.UseVisualStyleBackColor = false;
            this.SeparatorButton.Click += new System.EventHandler(this.SeparatorButton_Click);
            // 
            // ZeroDecimalButton
            // 
            this.ZeroDecimalButton.BackColor = System.Drawing.Color.Lavender;
            this.ZeroDecimalButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ZeroDecimalButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ZeroDecimalButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.ZeroDecimalButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.ZeroDecimalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZeroDecimalButton.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZeroDecimalButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ZeroDecimalButton.Location = new System.Drawing.Point(436, 649);
            this.ZeroDecimalButton.Name = "ZeroDecimalButton";
            this.ZeroDecimalButton.Size = new System.Drawing.Size(100, 100);
            this.ZeroDecimalButton.TabIndex = 22;
            this.ZeroDecimalButton.TabStop = false;
            this.ZeroDecimalButton.Tag = "0";
            this.ZeroDecimalButton.Text = "≈\r\n0";
            this.ZeroDecimalButton.UseVisualStyleBackColor = false;
            this.ZeroDecimalButton.Click += new System.EventHandler(this.RoundingButton_Click);
            // 
            // OneDecimalButton
            // 
            this.OneDecimalButton.BackColor = System.Drawing.Color.Lavender;
            this.OneDecimalButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.OneDecimalButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.OneDecimalButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.OneDecimalButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.OneDecimalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OneDecimalButton.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OneDecimalButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OneDecimalButton.Location = new System.Drawing.Point(436, 543);
            this.OneDecimalButton.Name = "OneDecimalButton";
            this.OneDecimalButton.Size = new System.Drawing.Size(100, 100);
            this.OneDecimalButton.TabIndex = 23;
            this.OneDecimalButton.TabStop = false;
            this.OneDecimalButton.Tag = "1";
            this.OneDecimalButton.Text = "≈\r\n0.0";
            this.OneDecimalButton.UseVisualStyleBackColor = false;
            this.OneDecimalButton.Click += new System.EventHandler(this.RoundingButton_Click);
            // 
            // TwoDecimalButton
            // 
            this.TwoDecimalButton.BackColor = System.Drawing.Color.Lavender;
            this.TwoDecimalButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.TwoDecimalButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TwoDecimalButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.TwoDecimalButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.TwoDecimalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TwoDecimalButton.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TwoDecimalButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TwoDecimalButton.Location = new System.Drawing.Point(436, 437);
            this.TwoDecimalButton.Name = "TwoDecimalButton";
            this.TwoDecimalButton.Size = new System.Drawing.Size(100, 100);
            this.TwoDecimalButton.TabIndex = 24;
            this.TwoDecimalButton.TabStop = false;
            this.TwoDecimalButton.Tag = "2";
            this.TwoDecimalButton.Text = "≈\r\n0.00";
            this.TwoDecimalButton.UseVisualStyleBackColor = false;
            this.TwoDecimalButton.Click += new System.EventHandler(this.RoundingButton_Click);
            // 
            // EquationTextBox
            // 
            this.EquationTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.EquationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EquationTextBox.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.EquationTextBox.Location = new System.Drawing.Point(12, 52);
            this.EquationTextBox.Name = "EquationTextBox";
            this.EquationTextBox.ReadOnly = true;
            this.EquationTextBox.Size = new System.Drawing.Size(524, 59);
            this.EquationTextBox.TabIndex = 26;
            this.EquationTextBox.TabStop = false;
            this.EquationTextBox.Text = "+ - =";
            this.EquationTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EquationTextBox.WordWrap = false;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Lavender;
            this.BackButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BackButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.BackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackButton.Location = new System.Drawing.Point(330, 225);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(100, 100);
            this.BackButton.TabIndex = 27;
            this.BackButton.TabStop = false;
            this.BackButton.Text = "←";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // NegativeButton
            // 
            this.NegativeButton.BackColor = System.Drawing.Color.Lavender;
            this.NegativeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.NegativeButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NegativeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.NegativeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.NegativeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NegativeButton.Font = new System.Drawing.Font("Impact", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NegativeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NegativeButton.Location = new System.Drawing.Point(12, 649);
            this.NegativeButton.Name = "NegativeButton";
            this.NegativeButton.Size = new System.Drawing.Size(100, 100);
            this.NegativeButton.TabIndex = 28;
            this.NegativeButton.TabStop = false;
            this.NegativeButton.Tag = ".";
            this.NegativeButton.Text = "±";
            this.NegativeButton.UseVisualStyleBackColor = false;
            this.NegativeButton.Click += new System.EventHandler(this.NegativeButton_Click);
            // 
            // MinusButton
            // 
            this.MinusButton.BackColor = System.Drawing.Color.Lavender;
            this.MinusButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.MinusButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.MinusButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.MinusButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.MinusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinusButton.Font = new System.Drawing.Font("Impact", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinusButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MinusButton.Location = new System.Drawing.Point(330, 437);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(100, 100);
            this.MinusButton.TabIndex = 15;
            this.MinusButton.TabStop = false;
            this.MinusButton.Tag = subtraction1;
            this.MinusButton.Text = "−";
            this.MinusButton.UseVisualStyleBackColor = false;
            this.MinusButton.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // TimesButton
            // 
            this.TimesButton.BackColor = System.Drawing.Color.Lavender;
            this.TimesButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.TimesButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TimesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.TimesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.TimesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TimesButton.Font = new System.Drawing.Font("Impact", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TimesButton.Location = new System.Drawing.Point(330, 331);
            this.TimesButton.Name = "TimesButton";
            this.TimesButton.Size = new System.Drawing.Size(100, 100);
            this.TimesButton.TabIndex = 14;
            this.TimesButton.TabStop = false;
            this.TimesButton.Tag = multiplication1;
            this.TimesButton.Text = "×";
            this.TimesButton.UseVisualStyleBackColor = false;
            this.TimesButton.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // DividedByButton
            // 
            this.DividedByButton.BackColor = System.Drawing.Color.Lavender;
            this.DividedByButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DividedByButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DividedByButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.DividedByButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.DividedByButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DividedByButton.Font = new System.Drawing.Font("Impact", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DividedByButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DividedByButton.Location = new System.Drawing.Point(436, 331);
            this.DividedByButton.Name = "DividedByButton";
            this.DividedByButton.Size = new System.Drawing.Size(100, 100);
            this.DividedByButton.TabIndex = 13;
            this.DividedByButton.TabStop = false;
            this.DividedByButton.Tag = division1;
            this.DividedByButton.Text = "÷";
            this.DividedByButton.UseVisualStyleBackColor = false;
            this.DividedByButton.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // PlusButton
            // 
            this.PlusButton.BackColor = System.Drawing.Color.Lavender;
            this.PlusButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.PlusButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PlusButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.PlusButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.PlusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlusButton.Font = new System.Drawing.Font("Impact", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PlusButton.Location = new System.Drawing.Point(330, 543);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(100, 100);
            this.PlusButton.TabIndex = 5;
            this.PlusButton.TabStop = false;
            this.PlusButton.Tag = addition1;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = false;
            this.PlusButton.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // Main
            // 
            this.AcceptButton = this.IsEqualToButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(549, 761);
            this.Controls.Add(this.EquationTextBox);
            this.Controls.Add(this.TwoDecimalButton);
            this.Controls.Add(this.OneDecimalButton);
            this.Controls.Add(this.NegativeButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ZeroDecimalButton);
            this.Controls.Add(this.SeparatorButton);
            this.Controls.Add(this.ClipboardTextBox);
            this.Controls.Add(this.EightButton);
            this.Controls.Add(this.MinusButton);
            this.Controls.Add(this.TimesButton);
            this.Controls.Add(this.DividedByButton);
            this.Controls.Add(this.FourButton);
            this.Controls.Add(this.FiveButton);
            this.Controls.Add(this.SixButton);
            this.Controls.Add(this.SevenButton);
            this.Controls.Add(this.ZeroButton);
            this.Controls.Add(this.NineButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.PlusButton);
            this.Controls.Add(this.IsEqualToButton);
            this.Controls.Add(this.TwoButton);
            this.Controls.Add(this.ThreeButton);
            this.Controls.Add(this.NumberTextBox);
            this.Controls.Add(this.OneButton);
            this.KeyPreview = true;
            this.Name = "Main";
            this.Text = "Calculator";
            this.Activated += new System.EventHandler(this.Main_EnterFocus);
            this.Load += new System.EventHandler(this.Main_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Main_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.TextBox NumberTextBox;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button IsEqualToButton;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button DividedByButton;
        private System.Windows.Forms.Button TimesButton;
        private System.Windows.Forms.Button MinusButton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.TextBox ClipboardTextBox;
        private System.Windows.Forms.Button SeparatorButton;
        private System.Windows.Forms.Button ZeroDecimalButton;
        private System.Windows.Forms.Button OneDecimalButton;
        private System.Windows.Forms.Button TwoDecimalButton;
        private System.Windows.Forms.TextBox EquationTextBox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button NegativeButton;

        private EquationTextBoxController equationTextBoxController;
        private NumberTextBoxController numberTextBoxController;
        private ClipboardTextBoxController clipboardTextBoxController;
        
    }
}

