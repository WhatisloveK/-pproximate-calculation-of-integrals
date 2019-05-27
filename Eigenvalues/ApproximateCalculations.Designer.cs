namespace Eigenvalues
{
    partial class ApproximateCalculations
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownRows = new System.Windows.Forms.NumericUpDown();
            this.buttonSize = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonSqure = new System.Windows.Forms.RadioButton();
            this.radioButtonTrapeze = new System.Windows.Forms.RadioButton();
            this.numericUpDownSegments = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownLeft = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRight = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSegments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRight)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 219);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(482, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Polinomial degree";
            // 
            // numericUpDownRows
            // 
            this.numericUpDownRows.Location = new System.Drawing.Point(178, 85);
            this.numericUpDownRows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRows.Name = "numericUpDownRows";
            this.numericUpDownRows.Size = new System.Drawing.Size(37, 20);
            this.numericUpDownRows.TabIndex = 2;
            this.numericUpDownRows.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonSize
            // 
            this.buttonSize.Location = new System.Drawing.Point(264, 38);
            this.buttonSize.Name = "buttonSize";
            this.buttonSize.Size = new System.Drawing.Size(51, 23);
            this.buttonSize.TabIndex = 4;
            this.buttonSize.Text = "Apply";
            this.buttonSize.UseVisualStyleBackColor = true;
            this.buttonSize.Click += new System.EventHandler(this.buttonSize_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(355, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 67);
            this.button1.TabIndex = 5;
            this.button1.Text = "Integrate me!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 10;
            // 
            // radioButtonSqure
            // 
            this.radioButtonSqure.AutoSize = true;
            this.radioButtonSqure.Location = new System.Drawing.Point(31, 13);
            this.radioButtonSqure.Name = "radioButtonSqure";
            this.radioButtonSqure.Size = new System.Drawing.Size(184, 17);
            this.radioButtonSqure.TabIndex = 11;
            this.radioButtonSqure.TabStop = true;
            this.radioButtonSqure.Text = "Formula of the middle of the squre";
            this.radioButtonSqure.UseVisualStyleBackColor = true;
            // 
            // radioButtonTrapeze
            // 
            this.radioButtonTrapeze.AutoSize = true;
            this.radioButtonTrapeze.Location = new System.Drawing.Point(31, 44);
            this.radioButtonTrapeze.Name = "radioButtonTrapeze";
            this.radioButtonTrapeze.Size = new System.Drawing.Size(168, 17);
            this.radioButtonTrapeze.TabIndex = 12;
            this.radioButtonTrapeze.TabStop = true;
            this.radioButtonTrapeze.Text = "Formula of the trapeze method";
            this.radioButtonTrapeze.UseVisualStyleBackColor = true;
            // 
            // numericUpDownSegments
            // 
            this.numericUpDownSegments.Location = new System.Drawing.Point(178, 122);
            this.numericUpDownSegments.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSegments.Name = "numericUpDownSegments";
            this.numericUpDownSegments.Size = new System.Drawing.Size(37, 20);
            this.numericUpDownSegments.TabIndex = 13;
            this.numericUpDownSegments.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Number of segments";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(264, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Interval";
            // 
            // numericUpDownLeft
            // 
            this.numericUpDownLeft.Location = new System.Drawing.Point(321, 126);
            this.numericUpDownLeft.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownLeft.Name = "numericUpDownLeft";
            this.numericUpDownLeft.Size = new System.Drawing.Size(37, 20);
            this.numericUpDownLeft.TabIndex = 16;
            this.numericUpDownLeft.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownRight
            // 
            this.numericUpDownRight.Location = new System.Drawing.Point(364, 126);
            this.numericUpDownRight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRight.Name = "numericUpDownRight";
            this.numericUpDownRight.Size = new System.Drawing.Size(37, 20);
            this.numericUpDownRight.TabIndex = 17;
            this.numericUpDownRight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ApproximateCalculations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 381);
            this.Controls.Add(this.numericUpDownRight);
            this.Controls.Add(this.numericUpDownLeft);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownSegments);
            this.Controls.Add(this.radioButtonTrapeze);
            this.Controls.Add(this.radioButtonSqure);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSize);
            this.Controls.Add(this.numericUpDownRows);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ApproximateCalculations";
            this.Text = "Approximate integrals calculation";
            this.Load += new System.EventHandler(this.ApproximateCalculations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSegments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownRows;
        private System.Windows.Forms.Button buttonSize;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonSqure;
        private System.Windows.Forms.RadioButton radioButtonTrapeze;
        private System.Windows.Forms.NumericUpDown numericUpDownSegments;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownLeft;
        private System.Windows.Forms.NumericUpDown numericUpDownRight;
    }
}

