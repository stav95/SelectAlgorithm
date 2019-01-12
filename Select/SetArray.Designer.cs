namespace Select
{
    partial class SetArray
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
            this.tbArray = new System.Windows.Forms.TextBox();
            this.btnGenerateArray = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudMinValue = new System.Windows.Forms.NumericUpDown();
            this.nudMaxValue = new System.Windows.Forms.NumericUpDown();
            this.nudLength = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStartAlgorithm = new System.Windows.Forms.Button();
            this.tbSortedArray = new System.Windows.Forms.TextBox();
            this.btnSortArray = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.nudSelect = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // tbArray
            // 
            this.tbArray.Location = new System.Drawing.Point(15, 54);
            this.tbArray.Multiline = true;
            this.tbArray.Name = "tbArray";
            this.tbArray.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbArray.Size = new System.Drawing.Size(283, 365);
            this.tbArray.TabIndex = 0;
            // 
            // btnGenerateArray
            // 
            this.btnGenerateArray.Location = new System.Drawing.Point(458, 18);
            this.btnGenerateArray.Name = "btnGenerateArray";
            this.btnGenerateArray.Size = new System.Drawing.Size(131, 27);
            this.btnGenerateArray.TabIndex = 1;
            this.btnGenerateArray.Text = "Generate Array";
            this.btnGenerateArray.UseVisualStyleBackColor = true;
            this.btnGenerateArray.Click += new System.EventHandler(this.btnGenerateArray_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Min value:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Max value:";
            // 
            // nudMinValue
            // 
            this.nudMinValue.Location = new System.Drawing.Point(77, 23);
            this.nudMinValue.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudMinValue.Name = "nudMinValue";
            this.nudMinValue.Size = new System.Drawing.Size(65, 20);
            this.nudMinValue.TabIndex = 4;
            this.nudMinValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudMaxValue
            // 
            this.nudMaxValue.Location = new System.Drawing.Point(233, 23);
            this.nudMaxValue.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudMaxValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMaxValue.Name = "nudMaxValue";
            this.nudMaxValue.Size = new System.Drawing.Size(65, 20);
            this.nudMaxValue.TabIndex = 5;
            this.nudMaxValue.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // nudLength
            // 
            this.nudLength.Location = new System.Drawing.Point(373, 23);
            this.nudLength.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLength.Name = "nudLength";
            this.nudLength.Size = new System.Drawing.Size(65, 20);
            this.nudLength.TabIndex = 7;
            this.nudLength.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Length:";
            // 
            // btnStartAlgorithm
            // 
            this.btnStartAlgorithm.Location = new System.Drawing.Point(148, 425);
            this.btnStartAlgorithm.Name = "btnStartAlgorithm";
            this.btnStartAlgorithm.Size = new System.Drawing.Size(150, 27);
            this.btnStartAlgorithm.TabIndex = 8;
            this.btnStartAlgorithm.Text = "Start Algorithm";
            this.btnStartAlgorithm.UseVisualStyleBackColor = true;
            this.btnStartAlgorithm.Click += new System.EventHandler(this.btnStartAlgorithm_Click);
            // 
            // tbSortedArray
            // 
            this.tbSortedArray.Location = new System.Drawing.Point(306, 54);
            this.tbSortedArray.Multiline = true;
            this.tbSortedArray.Name = "tbSortedArray";
            this.tbSortedArray.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbSortedArray.Size = new System.Drawing.Size(283, 365);
            this.tbSortedArray.TabIndex = 9;
            // 
            // btnSortArray
            // 
            this.btnSortArray.Location = new System.Drawing.Point(306, 425);
            this.btnSortArray.Name = "btnSortArray";
            this.btnSortArray.Size = new System.Drawing.Size(283, 27);
            this.btnSortArray.TabIndex = 10;
            this.btnSortArray.Text = "Sort Array";
            this.btnSortArray.UseVisualStyleBackColor = true;
            this.btnSortArray.Click += new System.EventHandler(this.btnSortArray_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 432);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Select:";
            // 
            // nudSelect
            // 
            this.nudSelect.Location = new System.Drawing.Point(58, 430);
            this.nudSelect.Name = "nudSelect";
            this.nudSelect.Size = new System.Drawing.Size(84, 20);
            this.nudSelect.TabIndex = 12;
            this.nudSelect.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // SetArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 461);
            this.Controls.Add(this.nudSelect);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSortArray);
            this.Controls.Add(this.tbSortedArray);
            this.Controls.Add(this.btnStartAlgorithm);
            this.Controls.Add(this.nudLength);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudMaxValue);
            this.Controls.Add(this.nudMinValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerateArray);
            this.Controls.Add(this.tbArray);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SetArray";
            this.Text = "Set Array";
            ((System.ComponentModel.ISupportInitialize)(this.nudMinValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbArray;
        private System.Windows.Forms.Button btnGenerateArray;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudMinValue;
        private System.Windows.Forms.NumericUpDown nudMaxValue;
        private System.Windows.Forms.NumericUpDown nudLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStartAlgorithm;
        private System.Windows.Forms.TextBox tbSortedArray;
        private System.Windows.Forms.Button btnSortArray;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudSelect;
    }
}