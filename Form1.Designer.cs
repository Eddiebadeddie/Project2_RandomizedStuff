namespace Project1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SeedTextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MAIN_TITLE = new System.Windows.Forms.Label();
            this.IterationBox = new System.Windows.Forms.TextBox();
            this.Die_1_Display = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Die_2_Display = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Die_Sum_Display = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Error_Message_Label = new System.Windows.Forms.Label();
            this.Roll_Button = new System.Windows.Forms.Button();
            this.Roll_Counter_Label = new System.Windows.Forms.Label();
            this.Die_Product_Display = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label6 = new System.Windows.Forms.Label();
            this.Coin_Toss_Display = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Die_1_Display)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Die_2_Display)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Die_Sum_Display)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Die_Product_Display)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin_Toss_Display)).BeginInit();
            this.SuspendLayout();
            // 
            // SeedTextBox
            // 
            this.SeedTextBox.Location = new System.Drawing.Point(564, 704);
            this.SeedTextBox.Name = "SeedTextBox";
            this.SeedTextBox.Size = new System.Drawing.Size(100, 20);
            this.SeedTextBox.TabIndex = 0;
            this.SeedTextBox.Text = "0";
            this.SeedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SeedTextBox.TextChanged += new System.EventHandler(this.Change_Die_Seed);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MAIN_TITLE
            // 
            this.MAIN_TITLE.AutoSize = true;
            this.MAIN_TITLE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MAIN_TITLE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MAIN_TITLE.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MAIN_TITLE.Location = new System.Drawing.Point(388, 9);
            this.MAIN_TITLE.Name = "MAIN_TITLE";
            this.MAIN_TITLE.Size = new System.Drawing.Size(157, 34);
            this.MAIN_TITLE.TabIndex = 2;
            this.MAIN_TITLE.Text = "Roll Dice";
            // 
            // IterationBox
            // 
            this.IterationBox.Location = new System.Drawing.Point(564, 661);
            this.IterationBox.Name = "IterationBox";
            this.IterationBox.Size = new System.Drawing.Size(100, 20);
            this.IterationBox.TabIndex = 4;
            this.IterationBox.Text = "100";
            this.IterationBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.IterationBox.TextChanged += new System.EventHandler(this.Change_Iteration_Number);
            // 
            // Die_1_Display
            // 
            this.Die_1_Display.BackColor = System.Drawing.Color.Transparent;
            this.Die_1_Display.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            chartArea1.Name = "ChartArea1";
            this.Die_1_Display.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Die_1_Display.Legends.Add(legend1);
            this.Die_1_Display.Location = new System.Drawing.Point(17, 88);
            this.Die_1_Display.Name = "Die_1_Display";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Number Rolled";
            this.Die_1_Display.Series.Add(series1);
            this.Die_1_Display.Size = new System.Drawing.Size(399, 235);
            this.Die_1_Display.TabIndex = 5;
            this.Die_1_Display.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(469, 663);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Iterations : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(499, 706);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Seed: ";
            // 
            // Die_2_Display
            // 
            this.Die_2_Display.BackColor = System.Drawing.Color.Transparent;
            this.Die_2_Display.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            chartArea2.Name = "ChartArea1";
            this.Die_2_Display.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.Die_2_Display.Legends.Add(legend2);
            this.Die_2_Display.Location = new System.Drawing.Point(576, 88);
            this.Die_2_Display.Name = "Die_2_Display";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Number Rolled";
            this.Die_2_Display.Series.Add(series2);
            this.Die_2_Display.Size = new System.Drawing.Size(399, 235);
            this.Die_2_Display.TabIndex = 8;
            this.Die_2_Display.Text = "chart1";
            // 
            // Die_Sum_Display
            // 
            this.Die_Sum_Display.BackColor = System.Drawing.Color.Transparent;
            this.Die_Sum_Display.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
            chartArea3.Name = "ChartArea1";
            this.Die_Sum_Display.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.Die_Sum_Display.Legends.Add(legend3);
            this.Die_Sum_Display.Location = new System.Drawing.Point(17, 395);
            this.Die_Sum_Display.Name = "Die_Sum_Display";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Total Rolled";
            this.Die_Sum_Display.Series.Add(series3);
            this.Die_Sum_Display.Size = new System.Drawing.Size(501, 235);
            this.Die_Sum_Display.TabIndex = 9;
            this.Die_Sum_Display.Text = "chart1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Die 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(714, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Die 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(179, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Combined Total";
            // 
            // Error_Message_Label
            // 
            this.Error_Message_Label.AutoSize = true;
            this.Error_Message_Label.BackColor = System.Drawing.Color.Transparent;
            this.Error_Message_Label.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F);
            this.Error_Message_Label.ForeColor = System.Drawing.Color.Yellow;
            this.Error_Message_Label.Location = new System.Drawing.Point(176, 742);
            this.Error_Message_Label.Name = "Error_Message_Label";
            this.Error_Message_Label.Size = new System.Drawing.Size(626, 32);
            this.Error_Message_Label.TabIndex = 13;
            this.Error_Message_Label.Text = "ERROR:Iterations needs to be an integer";
            this.Error_Message_Label.Visible = false;
            // 
            // Roll_Button
            // 
            this.Roll_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Roll_Button.Location = new System.Drawing.Point(351, 661);
            this.Roll_Button.Name = "Roll_Button";
            this.Roll_Button.Size = new System.Drawing.Size(87, 23);
            this.Roll_Button.TabIndex = 3;
            this.Roll_Button.Text = "Roll";
            this.Roll_Button.UseVisualStyleBackColor = true;
            this.Roll_Button.Click += new System.EventHandler(this.Roll_Button_Click);
            // 
            // Roll_Counter_Label
            // 
            this.Roll_Counter_Label.AutoSize = true;
            this.Roll_Counter_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Roll_Counter_Label.Location = new System.Drawing.Point(347, 704);
            this.Roll_Counter_Label.Name = "Roll_Counter_Label";
            this.Roll_Counter_Label.Size = new System.Drawing.Size(106, 18);
            this.Roll_Counter_Label.TabIndex = 14;
            this.Roll_Counter_Label.Text = "Rolls:  0/10000";
            // 
            // Die_Product_Display
            // 
            this.Die_Product_Display.BackColor = System.Drawing.Color.Transparent;
            this.Die_Product_Display.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
            chartArea4.Name = "ChartArea1";
            this.Die_Product_Display.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.Die_Product_Display.Legends.Add(legend4);
            this.Die_Product_Display.Location = new System.Drawing.Point(576, 395);
            this.Die_Product_Display.Name = "Die_Product_Display";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Product Rolled";
            this.Die_Product_Display.Series.Add(series4);
            this.Die_Product_Display.Size = new System.Drawing.Size(446, 235);
            this.Die_Product_Display.TabIndex = 15;
            this.Die_Product_Display.Text = "chart1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(740, 385);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Product of Dice";
            // 
            // Coin_Toss_Display
            // 
            this.Coin_Toss_Display.BackColor = System.Drawing.Color.Transparent;
            this.Coin_Toss_Display.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            chartArea5.Name = "ChartArea1";
            this.Coin_Toss_Display.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.Coin_Toss_Display.Legends.Add(legend5);
            this.Coin_Toss_Display.Location = new System.Drawing.Point(1113, 88);
            this.Coin_Toss_Display.Name = "Coin_Toss_Display";
            series5.ChartArea = "ChartArea1";
            series5.Color = System.Drawing.Color.Goldenrod;
            series5.LabelFormat = "H T";
            series5.Legend = "Legend1";
            series5.Name = "Toss Frequency";
            this.Coin_Toss_Display.Series.Add(series5);
            this.Coin_Toss_Display.Size = new System.Drawing.Size(399, 235);
            this.Coin_Toss_Display.TabIndex = 17;
            this.Coin_Toss_Display.Text = "chart1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1284, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Coin Toss";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1837, 783);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Coin_Toss_Display);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Roll_Counter_Label);
            this.Controls.Add(this.Error_Message_Label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Die_Sum_Display);
            this.Controls.Add(this.Die_2_Display);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Die_1_Display);
            this.Controls.Add(this.IterationBox);
            this.Controls.Add(this.Roll_Button);
            this.Controls.Add(this.MAIN_TITLE);
            this.Controls.Add(this.SeedTextBox);
            this.Controls.Add(this.Die_Product_Display);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Roll Dice";
            ((System.ComponentModel.ISupportInitialize)(this.Die_1_Display)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Die_2_Display)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Die_Sum_Display)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Die_Product_Display)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin_Toss_Display)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SeedTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label MAIN_TITLE;
        private System.Windows.Forms.TextBox IterationBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart Die_1_Display;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart Die_2_Display;
        private System.Windows.Forms.DataVisualization.Charting.Chart Die_Sum_Display;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Error_Message_Label;
        private System.Windows.Forms.Button Roll_Button;
        private System.Windows.Forms.Label Roll_Counter_Label;
        private System.Windows.Forms.DataVisualization.Charting.Chart Die_Product_Display;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart Coin_Toss_Display;
        private System.Windows.Forms.Label label7;
    }
}

