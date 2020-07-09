namespace Greyhound
{
    partial class GreyhoundRacingForm
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
            this.SetNamesButton = new System.Windows.Forms.Button();
            this.SaveNamesButton = new System.Windows.Forms.Button();
            this.RaceButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dogMTB2 = new System.Windows.Forms.MaskedTextBox();
            this.dogMTB3 = new System.Windows.Forms.MaskedTextBox();
            this.dogMTB1 = new System.Windows.Forms.MaskedTextBox();
            this.dogMTB0 = new System.Windows.Forms.MaskedTextBox();
            this.Doglabel0 = new System.Windows.Forms.Label();
            this.Doglabel1 = new System.Windows.Forms.Label();
            this.Doglabel2 = new System.Windows.Forms.Label();
            this.Doglabel3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.motionTimer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SetNamesButton
            // 
            this.SetNamesButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SetNamesButton.Location = new System.Drawing.Point(18, 208);
            this.SetNamesButton.Name = "SetNamesButton";
            this.SetNamesButton.Size = new System.Drawing.Size(92, 25);
            this.SetNamesButton.TabIndex = 0;
            this.SetNamesButton.Text = "Set Names";
            this.SetNamesButton.UseVisualStyleBackColor = true;
            this.SetNamesButton.Click += new System.EventHandler(this.SetNamesButton_Click);
            // 
            // SaveNamesButton
            // 
            this.SaveNamesButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SaveNamesButton.Location = new System.Drawing.Point(18, 247);
            this.SaveNamesButton.Name = "SaveNamesButton";
            this.SaveNamesButton.Size = new System.Drawing.Size(92, 25);
            this.SaveNamesButton.TabIndex = 2;
            this.SaveNamesButton.Text = "Save";
            this.SaveNamesButton.UseVisualStyleBackColor = true;
            this.SaveNamesButton.Click += new System.EventHandler(this.SaveNamesButton_Click);
            // 
            // RaceButton
            // 
            this.RaceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.RaceButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RaceButton.Location = new System.Drawing.Point(338, 227);
            this.RaceButton.Name = "RaceButton";
            this.RaceButton.Size = new System.Drawing.Size(243, 25);
            this.RaceButton.TabIndex = 3;
            this.RaceButton.Text = "RACE";
            this.RaceButton.UseVisualStyleBackColor = true;
            this.RaceButton.Click += new System.EventHandler(this.RaceButton_Click);
            // 
            // dogMTB2
            // 
            this.dogMTB2.BeepOnError = true;
            this.dogMTB2.Location = new System.Drawing.Point(3, 35);
            this.dogMTB2.Mask = "AAAAAAAAA";
            this.dogMTB2.Name = "dogMTB2";
            this.dogMTB2.PromptChar = ' ';
            this.dogMTB2.Size = new System.Drawing.Size(88, 21);
            this.dogMTB2.TabIndex = 2;
            this.dogMTB2.Text = "Dog 3";
            this.dogMTB2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.dogMTB2, "Enter name-third dog");
            // 
            // dogMTB3
            // 
            this.dogMTB3.BeepOnError = true;
            this.dogMTB3.Location = new System.Drawing.Point(98, 35);
            this.dogMTB3.Mask = "AAAAAAAAA";
            this.dogMTB3.Name = "dogMTB3";
            this.dogMTB3.PromptChar = ' ';
            this.dogMTB3.Size = new System.Drawing.Size(88, 21);
            this.dogMTB3.TabIndex = 3;
            this.dogMTB3.Text = "Dog 4";
            this.dogMTB3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.dogMTB3, "Enter name-fourth dog");
            // 
            // dogMTB1
            // 
            this.dogMTB1.BeepOnError = true;
            this.dogMTB1.Location = new System.Drawing.Point(98, 3);
            this.dogMTB1.Mask = "AAAAAAAAA";
            this.dogMTB1.Name = "dogMTB1";
            this.dogMTB1.PromptChar = ' ';
            this.dogMTB1.Size = new System.Drawing.Size(88, 21);
            this.dogMTB1.TabIndex = 1;
            this.dogMTB1.Text = "Dog 2";
            this.dogMTB1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.dogMTB1, "Enter name-second dog");
            // 
            // dogMTB0
            // 
            this.dogMTB0.BeepOnError = true;
            this.dogMTB0.Location = new System.Drawing.Point(3, 3);
            this.dogMTB0.Mask = "AAAAAAAAA";
            this.dogMTB0.Name = "dogMTB0";
            this.dogMTB0.PromptChar = ' ';
            this.dogMTB0.Size = new System.Drawing.Size(88, 21);
            this.dogMTB0.TabIndex = 0;
            this.dogMTB0.Text = "Dog 1";
            this.dogMTB0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.dogMTB0, "Enter name-first dog");
            // 
            // Doglabel0
            // 
            this.Doglabel0.AutoSize = true;
            this.Doglabel0.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Doglabel0.Location = new System.Drawing.Point(113, 11);
            this.Doglabel0.Name = "Doglabel0";
            this.Doglabel0.Size = new System.Drawing.Size(40, 15);
            this.Doglabel0.TabIndex = 4;
            this.Doglabel0.Text = "Dog 1";
            // 
            // Doglabel1
            // 
            this.Doglabel1.AutoSize = true;
            this.Doglabel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Doglabel1.Location = new System.Drawing.Point(113, 65);
            this.Doglabel1.Name = "Doglabel1";
            this.Doglabel1.Size = new System.Drawing.Size(40, 15);
            this.Doglabel1.TabIndex = 5;
            this.Doglabel1.Text = "Dog 2";
            // 
            // Doglabel2
            // 
            this.Doglabel2.AutoSize = true;
            this.Doglabel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Doglabel2.Location = new System.Drawing.Point(113, 124);
            this.Doglabel2.Name = "Doglabel2";
            this.Doglabel2.Size = new System.Drawing.Size(40, 15);
            this.Doglabel2.TabIndex = 6;
            this.Doglabel2.Text = "Dog 3";
            // 
            // Doglabel3
            // 
            this.Doglabel3.AutoSize = true;
            this.Doglabel3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Doglabel3.Location = new System.Drawing.Point(113, 176);
            this.Doglabel3.Name = "Doglabel3";
            this.Doglabel3.Size = new System.Drawing.Size(40, 15);
            this.Doglabel3.TabIndex = 7;
            this.Doglabel3.Text = "Dog 4";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dogMTB3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dogMTB2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dogMTB1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dogMTB0, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(116, 208);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(191, 64);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // motionTimer
            // 
            this.motionTimer.Tick += new System.EventHandler(this.motionTimer_Tick);
            // 
            // GreyhoundRacingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Greyhound.Properties.Resources.racetrack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(600, 281);
            this.Controls.Add(this.Doglabel3);
            this.Controls.Add(this.Doglabel2);
            this.Controls.Add(this.Doglabel1);
            this.Controls.Add(this.Doglabel0);
            this.Controls.Add(this.RaceButton);
            this.Controls.Add(this.SaveNamesButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.SetNamesButton);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "GreyhoundRacingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Greyhound racing";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GreyhoundRacingForm_Paint);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SetNamesButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button SaveNamesButton;
        private System.Windows.Forms.Button RaceButton;
        private System.Windows.Forms.Label Doglabel0;
        private System.Windows.Forms.Label Doglabel1;
        private System.Windows.Forms.Label Doglabel2;
        private System.Windows.Forms.Label Doglabel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MaskedTextBox dogMTB3;
        private System.Windows.Forms.MaskedTextBox dogMTB2;
        private System.Windows.Forms.MaskedTextBox dogMTB1;
        private System.Windows.Forms.MaskedTextBox dogMTB0;
        private System.Windows.Forms.Timer motionTimer;
    }
}

