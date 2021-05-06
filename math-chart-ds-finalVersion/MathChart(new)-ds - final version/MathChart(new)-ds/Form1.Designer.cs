namespace MathChart_new__ds
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.FinalCalbtn = new System.Windows.Forms.Button();
            this.StepByStepCalBtn = new System.Windows.Forms.Button();
            this.textBoxUp = new System.Windows.Forms.TextBox();
            this.textBoxDown = new System.Windows.Forms.TextBox();
            this.labelX = new System.Windows.Forms.Label();
            this.textBoxequation = new System.Windows.Forms.TextBox();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.Name = "xy";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(778, 585);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // FinalCalbtn
            // 
            this.FinalCalbtn.Location = new System.Drawing.Point(1191, 605);
            this.FinalCalbtn.Name = "FinalCalbtn";
            this.FinalCalbtn.Size = new System.Drawing.Size(165, 40);
            this.FinalCalbtn.TabIndex = 1;
            this.FinalCalbtn.Text = "محاسبه نهایی";
            this.FinalCalbtn.UseVisualStyleBackColor = true;
            this.FinalCalbtn.Click += new System.EventHandler(this.FinalCalbtn_Click);
            // 
            // StepByStepCalBtn
            // 
            this.StepByStepCalBtn.Location = new System.Drawing.Point(1191, 651);
            this.StepByStepCalBtn.Name = "StepByStepCalBtn";
            this.StepByStepCalBtn.Size = new System.Drawing.Size(165, 40);
            this.StepByStepCalBtn.TabIndex = 2;
            this.StepByStepCalBtn.Text = "محاسبه گام به گام";
            this.StepByStepCalBtn.UseVisualStyleBackColor = true;
            this.StepByStepCalBtn.Click += new System.EventHandler(this.StepByStepCalBtn_Click);
            // 
            // textBoxUp
            // 
            this.textBoxUp.Location = new System.Drawing.Point(253, 672);
            this.textBoxUp.Name = "textBoxUp";
            this.textBoxUp.Size = new System.Drawing.Size(88, 22);
            this.textBoxUp.TabIndex = 3;
            // 
            // textBoxDown
            // 
            this.textBoxDown.Location = new System.Drawing.Point(100, 672);
            this.textBoxDown.Name = "textBoxDown";
            this.textBoxDown.Size = new System.Drawing.Size(95, 22);
            this.textBoxDown.TabIndex = 4;
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX.Location = new System.Drawing.Point(201, 672);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(46, 25);
            this.labelX.TabIndex = 5;
            this.labelX.Text = "<x<";
            // 
            // textBoxequation
            // 
            this.textBoxequation.Location = new System.Drawing.Point(100, 623);
            this.textBoxequation.Name = "textBoxequation";
            this.textBoxequation.Size = new System.Drawing.Size(241, 22);
            this.textBoxequation.TabIndex = 6;
            // 
            // textBoxData
            // 
            this.textBoxData.Location = new System.Drawing.Point(796, 12);
            this.textBoxData.Multiline = true;
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.ReadOnly = true;
            this.textBoxData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxData.Size = new System.Drawing.Size(560, 587);
            this.textBoxData.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(377, 620);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "تابع با x کوچک";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(384, 673);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "بازه";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 720);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxData);
            this.Controls.Add(this.textBoxequation);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.textBoxDown);
            this.Controls.Add(this.textBoxUp);
            this.Controls.Add(this.StepByStepCalBtn);
            this.Controls.Add(this.FinalCalbtn);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button FinalCalbtn;
        private System.Windows.Forms.Button StepByStepCalBtn;
        private System.Windows.Forms.TextBox textBoxUp;
        private System.Windows.Forms.TextBox textBoxDown;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.TextBox textBoxequation;
        private System.Windows.Forms.TextBox textBoxData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

