
namespace Tyuiu.BakhtiyarovDR.Sprint7.Project.V15
{
    partial class FormReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTop_BDR = new System.Windows.Forms.Panel();
            this.buttonBack_BDR = new System.Windows.Forms.Button();
            this.labelSubjectArea_BDR = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.splitterOne_BDR = new System.Windows.Forms.Splitter();
            this.chartFunctions_BDR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTop_BDR.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunctions_BDR)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_BDR
            // 
            this.panelTop_BDR.Controls.Add(this.buttonBack_BDR);
            this.panelTop_BDR.Controls.Add(this.labelSubjectArea_BDR);
            this.panelTop_BDR.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_BDR.Location = new System.Drawing.Point(0, 0);
            this.panelTop_BDR.Margin = new System.Windows.Forms.Padding(2);
            this.panelTop_BDR.Name = "panelTop_BDR";
            this.panelTop_BDR.Size = new System.Drawing.Size(663, 41);
            this.panelTop_BDR.TabIndex = 1;
            // 
            // buttonBack_BDR
            // 
            this.buttonBack_BDR.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonBack_BDR.Location = new System.Drawing.Point(589, 0);
            this.buttonBack_BDR.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBack_BDR.Name = "buttonBack_BDR";
            this.buttonBack_BDR.Size = new System.Drawing.Size(74, 41);
            this.buttonBack_BDR.TabIndex = 0;
            this.buttonBack_BDR.Text = "Назад";
            this.buttonBack_BDR.UseVisualStyleBackColor = true;
            this.buttonBack_BDR.Click += new System.EventHandler(this.buttonBack_BDR_Click);
            // 
            // labelSubjectArea_BDR
            // 
            this.labelSubjectArea_BDR.AutoSize = true;
            this.labelSubjectArea_BDR.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSubjectArea_BDR.Location = new System.Drawing.Point(9, 7);
            this.labelSubjectArea_BDR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSubjectArea_BDR.Name = "labelSubjectArea_BDR";
            this.labelSubjectArea_BDR.Size = new System.Drawing.Size(288, 17);
            this.labelSubjectArea_BDR.TabIndex = 1;
            this.labelSubjectArea_BDR.Text = "Договорная деятельность организации";
            // 
            // panelLeft
            // 
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 41);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(2);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(284, 331);
            this.panelLeft.TabIndex = 2;
            this.panelLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLeft_Paint);
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.splitterOne_BDR);
            this.panelRight.Controls.Add(this.chartFunctions_BDR);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(284, 41);
            this.panelRight.Margin = new System.Windows.Forms.Padding(2);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(379, 331);
            this.panelRight.TabIndex = 3;
            // 
            // splitterOne_BDR
            // 
            this.splitterOne_BDR.Location = new System.Drawing.Point(0, 0);
            this.splitterOne_BDR.Margin = new System.Windows.Forms.Padding(2);
            this.splitterOne_BDR.Name = "splitterOne_BDR";
            this.splitterOne_BDR.Size = new System.Drawing.Size(2, 331);
            this.splitterOne_BDR.TabIndex = 1;
            this.splitterOne_BDR.TabStop = false;
            // 
            // chartFunctions_BDR
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunctions_BDR.ChartAreas.Add(chartArea1);
            this.chartFunctions_BDR.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartFunctions_BDR.Legends.Add(legend1);
            this.chartFunctions_BDR.Location = new System.Drawing.Point(0, 0);
            this.chartFunctions_BDR.Margin = new System.Windows.Forms.Padding(2);
            this.chartFunctions_BDR.Name = "chartFunctions_BDR";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 4;
            this.chartFunctions_BDR.Series.Add(series1);
            this.chartFunctions_BDR.Size = new System.Drawing.Size(379, 331);
            this.chartFunctions_BDR.TabIndex = 0;
            this.chartFunctions_BDR.Text = "chart1";
            this.chartFunctions_BDR.Click += new System.EventHandler(this.chartFunctions_BDR_Click);
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 372);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop_BDR);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(679, 411);
            this.Name = "FormReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сводный отчет";
            this.panelTop_BDR.ResumeLayout(false);
            this.panelTop_BDR.PerformLayout();
            this.panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunctions_BDR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_BDR;
        private System.Windows.Forms.Label labelSubjectArea_BDR;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunctions_BDR;
        private System.Windows.Forms.Button buttonBack_BDR;
        private System.Windows.Forms.Splitter splitterOne_BDR;
    }
}