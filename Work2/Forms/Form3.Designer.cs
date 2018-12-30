namespace Work2.Forms
{
    partial class Simulation
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.back = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.replay = new System.Windows.Forms.Button();
            this.speedLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.radiusLabel = new System.Windows.Forms.Label();
            this.infectionLabel = new System.Windows.Forms.Label();
            this.pause = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.back.Location = new System.Drawing.Point(2322, 1228);
            this.back.Margin = new System.Windows.Forms.Padding(6);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(248, 95);
            this.back.TabIndex = 0;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(1064, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(745, 63);
            this.label1.TabIndex = 1;
            this.label1.Text = "Simulation and Graph Results";
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(632, 182);
            this.chart.Margin = new System.Windows.Forms.Padding(6);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Concentration";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(1550, 789);
            this.chart.TabIndex = 2;
            this.chart.Text = "Chart";
            title1.Name = "Title1";
            this.chart.Titles.Add(title1);
            this.chart.Click += new System.EventHandler(this.chart_Click);
            // 
            // replay
            // 
            this.replay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.replay.Location = new System.Drawing.Point(136, 182);
            this.replay.Margin = new System.Windows.Forms.Padding(6);
            this.replay.Name = "replay";
            this.replay.Size = new System.Drawing.Size(276, 97);
            this.replay.TabIndex = 3;
            this.replay.Text = "Replay";
            this.replay.UseVisualStyleBackColor = true;
            this.replay.Click += new System.EventHandler(this.replay_Click);
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.speedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.speedLabel.Location = new System.Drawing.Point(2278, 231);
            this.speedLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(0, 42);
            this.speedLabel.TabIndex = 4;
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lengthLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lengthLabel.Location = new System.Drawing.Point(2240, 482);
            this.lengthLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(0, 42);
            this.lengthLabel.TabIndex = 5;
            // 
            // radiusLabel
            // 
            this.radiusLabel.AutoSize = true;
            this.radiusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.radiusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.radiusLabel.Location = new System.Drawing.Point(2260, 355);
            this.radiusLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.radiusLabel.Name = "radiusLabel";
            this.radiusLabel.Size = new System.Drawing.Size(0, 42);
            this.radiusLabel.TabIndex = 6;
            // 
            // infectionLabel
            // 
            this.infectionLabel.AutoSize = true;
            this.infectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.infectionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.infectionLabel.Location = new System.Drawing.Point(2278, 604);
            this.infectionLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.infectionLabel.Name = "infectionLabel";
            this.infectionLabel.Size = new System.Drawing.Size(0, 42);
            this.infectionLabel.TabIndex = 7;
            // 
            // pause
            // 
            this.pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.pause.Location = new System.Drawing.Point(2344, 767);
            this.pause.Margin = new System.Windows.Forms.Padding(6);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(276, 91);
            this.pause.TabIndex = 8;
            this.pause.Text = "Pause";
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // Simulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Work2.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2784, 1387);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.infectionLabel);
            this.Controls.Add(this.radiusLabel);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.replay);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Simulation";
            this.Text = "Show Simulation";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Simulation_FormClosed);
            this.Load += new System.EventHandler(this.Simulation_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Simulation_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button replay;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label radiusLabel;
        private System.Windows.Forms.Label infectionLabel;
        private System.Windows.Forms.Button pause;
    }
}