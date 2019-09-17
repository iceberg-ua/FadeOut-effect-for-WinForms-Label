namespace FadeOutDemo
{
    partial class MainForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.opacityTrackBar = new System.Windows.Forms.TrackBar();
            this.stepTrackBar = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.delayTrackBar = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.accTrackBar = new System.Windows.Forms.TrackBar();
            this.intervalTrackBar = new System.Windows.Forms.TrackBar();
            this.button2 = new System.Windows.Forms.Button();
            this.mainLabel = new FadeOutDemo.FadeOutLabel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.opacityTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepTrackBar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delayTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intervalTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(189, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Fade out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.StartButtonClick);
            // 
            // opacityTrackBar
            // 
            this.opacityTrackBar.Location = new System.Drawing.Point(6, 19);
            this.opacityTrackBar.Maximum = 255;
            this.opacityTrackBar.Name = "opacityTrackBar";
            this.opacityTrackBar.Size = new System.Drawing.Size(289, 45);
            this.opacityTrackBar.TabIndex = 2;
            this.opacityTrackBar.Value = 255;
            this.opacityTrackBar.Scroll += new System.EventHandler(this.TrackBarScroll);
            this.opacityTrackBar.ValueChanged += new System.EventHandler(this.OpacityTrackBarValueChanged);
            // 
            // stepTrackBar
            // 
            this.stepTrackBar.LargeChange = 2;
            this.stepTrackBar.Location = new System.Drawing.Point(6, 100);
            this.stepTrackBar.Minimum = 1;
            this.stepTrackBar.Name = "stepTrackBar";
            this.stepTrackBar.Size = new System.Drawing.Size(289, 45);
            this.stepTrackBar.TabIndex = 3;
            this.stepTrackBar.Value = 1;
            this.stepTrackBar.Scroll += new System.EventHandler(this.TrackBarScroll);
            this.stepTrackBar.ValueChanged += new System.EventHandler(this.Reset);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.opacityTrackBar);
            this.groupBox1.Location = new System.Drawing.Point(12, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 69);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Label\'s current opacity (0-255)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.delayTrackBar);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.accTrackBar);
            this.groupBox2.Controls.Add(this.intervalTrackBar);
            this.groupBox2.Controls.Add(this.stepTrackBar);
            this.groupBox2.Location = new System.Drawing.Point(12, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(301, 285);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fade out animation settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Animation delay (100 - 3000 miliseconds)";
            // 
            // delayTrackBar
            // 
            this.delayTrackBar.LargeChange = 500;
            this.delayTrackBar.Location = new System.Drawing.Point(6, 34);
            this.delayTrackBar.Maximum = 3000;
            this.delayTrackBar.Minimum = 100;
            this.delayTrackBar.Name = "delayTrackBar";
            this.delayTrackBar.Size = new System.Drawing.Size(289, 45);
            this.delayTrackBar.SmallChange = 100;
            this.delayTrackBar.TabIndex = 9;
            this.delayTrackBar.Value = 100;
            this.delayTrackBar.Scroll += new System.EventHandler(this.TrackBarScroll);
            this.delayTrackBar.ValueChanged += new System.EventHandler(this.Reset);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Acceleration coefficient (1 - 2  0.1 step)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Time interval (5 - 50 miliseconds)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Opacity change step (1 - 10)";
            // 
            // accTrackBar
            // 
            this.accTrackBar.LargeChange = 2;
            this.accTrackBar.Location = new System.Drawing.Point(6, 165);
            this.accTrackBar.Maximum = 20;
            this.accTrackBar.Minimum = 10;
            this.accTrackBar.Name = "accTrackBar";
            this.accTrackBar.Size = new System.Drawing.Size(289, 45);
            this.accTrackBar.TabIndex = 5;
            this.accTrackBar.Value = 10;
            this.accTrackBar.Scroll += new System.EventHandler(this.TrackBarScroll);
            this.accTrackBar.ValueChanged += new System.EventHandler(this.Reset);
            // 
            // intervalTrackBar
            // 
            this.intervalTrackBar.Location = new System.Drawing.Point(6, 232);
            this.intervalTrackBar.Maximum = 50;
            this.intervalTrackBar.Minimum = 5;
            this.intervalTrackBar.Name = "intervalTrackBar";
            this.intervalTrackBar.Size = new System.Drawing.Size(289, 45);
            this.intervalTrackBar.TabIndex = 4;
            this.intervalTrackBar.Value = 5;
            this.intervalTrackBar.Scroll += new System.EventHandler(this.TrackBarScroll);
            this.intervalTrackBar.ValueChanged += new System.EventHandler(this.Reset);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(189, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 26);
            this.button2.TabIndex = 6;
            this.button2.Text = "Reset opacity";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ResetButtonClick);
            // 
            // mainLabel
            // 
            this.mainLabel.AnimationFrameInterval = 25;
            this.mainLabel.AutoSize = true;
            this.mainLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.mainLabel.FadeoutStep = 0;
            this.mainLabel.FadeOutTimerInterval = 1500;
            this.mainLabel.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mainLabel.Location = new System.Drawing.Point(12, 9);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Padding = new System.Windows.Forms.Padding(20, 4, 20, 4);
            this.mainLabel.Size = new System.Drawing.Size(171, 60);
            this.mainLabel.StepAcceleration = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.mainLabel.TabIndex = 1;
            this.mainLabel.Text = "TEST";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 441);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Change ForeColor";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ForeColorButtonClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(167, 441);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(147, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Change BackColor";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.BackColorButtonClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 467);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Fade Out Effect Demo";
            ((System.ComponentModel.ISupportInitialize)(this.opacityTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepTrackBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delayTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intervalTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private FadeOutLabel mainLabel;
        private System.Windows.Forms.TrackBar opacityTrackBar;
        private System.Windows.Forms.TrackBar stepTrackBar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar accTrackBar;
        private System.Windows.Forms.TrackBar intervalTrackBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TrackBar delayTrackBar;
        private System.Windows.Forms.Label label1;
    }
}

