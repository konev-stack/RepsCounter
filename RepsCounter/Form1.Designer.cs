
namespace RepsCounter
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.totalreps = new System.Windows.Forms.Label();
            this.minus1rep = new System.Windows.Forms.Button();
            this.minus5reps = new System.Windows.Forms.Button();
            this.minus10reps = new System.Windows.Forms.Button();
            this.plus1rep = new System.Windows.Forms.Button();
            this.plus5reps = new System.Windows.Forms.Button();
            this.plus10reps = new System.Windows.Forms.Button();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.minutesLabel = new System.Windows.Forms.Label();
            this.secondsLabel = new System.Windows.Forms.Label();
            this.timertext = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.labelTimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RepsCounter.Properties.Resources._460863;
            this.pictureBox1.Location = new System.Drawing.Point(1, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1052, 581);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(804, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Reps:";
            // 
            // totalreps
            // 
            this.totalreps.AutoSize = true;
            this.totalreps.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalreps.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.totalreps.Location = new System.Drawing.Point(884, 132);
            this.totalreps.Name = "totalreps";
            this.totalreps.Size = new System.Drawing.Size(31, 33);
            this.totalreps.TabIndex = 2;
            this.totalreps.Text = "0";
            this.totalreps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minus1rep
            // 
            this.minus1rep.BackColor = System.Drawing.Color.White;
            this.minus1rep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minus1rep.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus1rep.Location = new System.Drawing.Point(23, 528);
            this.minus1rep.Name = "minus1rep";
            this.minus1rep.Size = new System.Drawing.Size(174, 77);
            this.minus1rep.TabIndex = 3;
            this.minus1rep.Text = "-1 REP";
            this.minus1rep.UseVisualStyleBackColor = false;
            this.minus1rep.Click += new System.EventHandler(this.minus1rep_Click);
            // 
            // minus5reps
            // 
            this.minus5reps.BackColor = System.Drawing.Color.White;
            this.minus5reps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minus5reps.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus5reps.Location = new System.Drawing.Point(452, 528);
            this.minus5reps.Name = "minus5reps";
            this.minus5reps.Size = new System.Drawing.Size(174, 77);
            this.minus5reps.TabIndex = 4;
            this.minus5reps.Text = "-5 REPS";
            this.minus5reps.UseVisualStyleBackColor = false;
            this.minus5reps.Click += new System.EventHandler(this.minus5reps_Click);
            // 
            // minus10reps
            // 
            this.minus10reps.BackColor = System.Drawing.Color.White;
            this.minus10reps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minus10reps.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus10reps.Location = new System.Drawing.Point(853, 528);
            this.minus10reps.Name = "minus10reps";
            this.minus10reps.Size = new System.Drawing.Size(174, 77);
            this.minus10reps.TabIndex = 5;
            this.minus10reps.Text = "-10 REPS";
            this.minus10reps.UseVisualStyleBackColor = false;
            this.minus10reps.Click += new System.EventHandler(this.minus10reps_Click);
            // 
            // plus1rep
            // 
            this.plus1rep.BackColor = System.Drawing.Color.White;
            this.plus1rep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plus1rep.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus1rep.Location = new System.Drawing.Point(23, 403);
            this.plus1rep.Name = "plus1rep";
            this.plus1rep.Size = new System.Drawing.Size(174, 77);
            this.plus1rep.TabIndex = 6;
            this.plus1rep.Text = "+1 REP";
            this.plus1rep.UseVisualStyleBackColor = false;
            this.plus1rep.Click += new System.EventHandler(this.plus1rep_Click);
            // 
            // plus5reps
            // 
            this.plus5reps.BackColor = System.Drawing.Color.White;
            this.plus5reps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plus5reps.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus5reps.Location = new System.Drawing.Point(452, 403);
            this.plus5reps.Name = "plus5reps";
            this.plus5reps.Size = new System.Drawing.Size(174, 77);
            this.plus5reps.TabIndex = 7;
            this.plus5reps.Text = "+5 REPS";
            this.plus5reps.UseVisualStyleBackColor = false;
            this.plus5reps.Click += new System.EventHandler(this.plus5reps_Click);
            // 
            // plus10reps
            // 
            this.plus10reps.BackColor = System.Drawing.Color.White;
            this.plus10reps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plus10reps.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus10reps.Location = new System.Drawing.Point(853, 403);
            this.plus10reps.Name = "plus10reps";
            this.plus10reps.Size = new System.Drawing.Size(174, 77);
            this.plus10reps.TabIndex = 8;
            this.plus10reps.Text = "+10 REPS";
            this.plus10reps.UseVisualStyleBackColor = false;
            this.plus10reps.Click += new System.EventHandler(this.plus10reps_Click);
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.metroComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(18, 197);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox1.TabIndex = 9;
            this.metroComboBox1.UseSelectable = true;
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.metroComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 23;
            this.metroComboBox2.Location = new System.Drawing.Point(228, 197);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox2.TabIndex = 10;
            this.metroComboBox2.UseSelectable = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tomato;
            this.panel1.Location = new System.Drawing.Point(1, 341);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1052, 12);
            this.panel1.TabIndex = 11;
            // 
            // minutesLabel
            // 
            this.minutesLabel.AutoSize = true;
            this.minutesLabel.BackColor = System.Drawing.Color.Transparent;
            this.minutesLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minutesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutesLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.minutesLabel.Location = new System.Drawing.Point(28, 166);
            this.minutesLabel.Name = "minutesLabel";
            this.minutesLabel.Size = new System.Drawing.Size(103, 29);
            this.minutesLabel.TabIndex = 12;
            this.minutesLabel.Text = "Minutes:";
            // 
            // secondsLabel
            // 
            this.secondsLabel.AutoSize = true;
            this.secondsLabel.BackColor = System.Drawing.Color.Transparent;
            this.secondsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.secondsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondsLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.secondsLabel.Location = new System.Drawing.Point(232, 166);
            this.secondsLabel.Name = "secondsLabel";
            this.secondsLabel.Size = new System.Drawing.Size(114, 29);
            this.secondsLabel.TabIndex = 13;
            this.secondsLabel.Text = "Seconds:";
            // 
            // timertext
            // 
            this.timertext.AutoSize = true;
            this.timertext.BackColor = System.Drawing.Color.Transparent;
            this.timertext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timertext.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timertext.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.timertext.Location = new System.Drawing.Point(148, 83);
            this.timertext.Name = "timertext";
            this.timertext.Size = new System.Drawing.Size(77, 29);
            this.timertext.TabIndex = 14;
            this.timertext.Text = "Timer";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.White;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(11, 301);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(96, 34);
            this.startButton.TabIndex = 15;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.White;
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.Location = new System.Drawing.Point(113, 301);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(96, 34);
            this.stopButton.TabIndex = 16;
            this.stopButton.Text = "STOP";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.BackColor = System.Drawing.Color.Transparent;
            this.labelTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTimer.Location = new System.Drawing.Point(497, 187);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(145, 55);
            this.labelTimer.TabIndex = 17;
            this.labelTimer.Text = "00:00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 628);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.timertext);
            this.Controls.Add(this.secondsLabel);
            this.Controls.Add(this.minutesLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroComboBox2);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.plus10reps);
            this.Controls.Add(this.plus5reps);
            this.Controls.Add(this.plus1rep);
            this.Controls.Add(this.minus10reps);
            this.Controls.Add(this.minus5reps);
            this.Controls.Add(this.minus1rep);
            this.Controls.Add(this.totalreps);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Movable = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Rep Counter";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalreps;
        private System.Windows.Forms.Button minus1rep;
        private System.Windows.Forms.Button minus5reps;
        private System.Windows.Forms.Button minus10reps;
        private System.Windows.Forms.Button plus1rep;
        private System.Windows.Forms.Button plus5reps;
        private System.Windows.Forms.Button plus10reps;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label minutesLabel;
        private System.Windows.Forms.Label secondsLabel;
        private System.Windows.Forms.Label timertext;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelTimer;
    }
}

