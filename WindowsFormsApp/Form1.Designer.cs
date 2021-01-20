namespace WindowsFormsApp
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelBar = new System.Windows.Forms.Panel();
            this.iconButtonExit = new FontAwesome.Sharp.IconButton();
            this.button1 = new System.Windows.Forms.Button();
            this.iconButtonSettings = new FontAwesome.Sharp.IconButton();
            this.iconButtonChart = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.iconButtonExit);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.iconButtonSettings);
            this.panel2.Controls.Add(this.iconButtonChart);
            this.panel2.Controls.Add(this.panelLogo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 450);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 414);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 1);
            this.panel1.TabIndex = 4;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Transparent;
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // panelBar
            // 
            this.panelBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.panelBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBar.Location = new System.Drawing.Point(220, 0);
            this.panelBar.Name = "panelBar";
            this.panelBar.Size = new System.Drawing.Size(580, 30);
            this.panelBar.TabIndex = 3;
            this.panelBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBar_MouseDown);
            this.panelBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBar_MouseMove);
            this.panelBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelBar_MouseUp);
            // 
            // iconButtonExit
            // 
            this.iconButtonExit.BackColor = System.Drawing.Color.Transparent;
            this.iconButtonExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButtonExit.FlatAppearance.BorderSize = 0;
            this.iconButtonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.iconButtonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.iconButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonExit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonExit.ForeColor = System.Drawing.Color.Transparent;
            this.iconButtonExit.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.iconButtonExit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.iconButtonExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonExit.IconSize = 32;
            this.iconButtonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonExit.Location = new System.Drawing.Point(0, 415);
            this.iconButtonExit.Margin = new System.Windows.Forms.Padding(0);
            this.iconButtonExit.Name = "iconButtonExit";
            this.iconButtonExit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconButtonExit.Size = new System.Drawing.Size(220, 35);
            this.iconButtonExit.TabIndex = 3;
            this.iconButtonExit.Text = "Exit";
            this.iconButtonExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonExit.UseVisualStyleBackColor = false;
            this.iconButtonExit.Click += new System.EventHandler(this.iconButtonExit_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Image = global::WindowsFormsApp.Properties.Resources.icons8_cursor_25px_2;
            this.button1.Location = new System.Drawing.Point(0, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Show Notification";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // iconButtonSettings
            // 
            this.iconButtonSettings.BackColor = System.Drawing.Color.Transparent;
            this.iconButtonSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonSettings.FlatAppearance.BorderSize = 0;
            this.iconButtonSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.iconButtonSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.iconButtonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSettings.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonSettings.ForeColor = System.Drawing.Color.Transparent;
            this.iconButtonSettings.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.iconButtonSettings.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.iconButtonSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSettings.IconSize = 32;
            this.iconButtonSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSettings.Location = new System.Drawing.Point(0, 175);
            this.iconButtonSettings.Margin = new System.Windows.Forms.Padding(0);
            this.iconButtonSettings.Name = "iconButtonSettings";
            this.iconButtonSettings.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconButtonSettings.Size = new System.Drawing.Size(220, 35);
            this.iconButtonSettings.TabIndex = 2;
            this.iconButtonSettings.Text = "Settings";
            this.iconButtonSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSettings.UseVisualStyleBackColor = false;
            this.iconButtonSettings.MouseEnter += new System.EventHandler(this.iconButtonSettings_MouseEnter);
            this.iconButtonSettings.MouseLeave += new System.EventHandler(this.iconButtonSettings_MouseLeave);
            // 
            // iconButtonChart
            // 
            this.iconButtonChart.BackColor = System.Drawing.Color.Transparent;
            this.iconButtonChart.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonChart.FlatAppearance.BorderSize = 0;
            this.iconButtonChart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.iconButtonChart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.iconButtonChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonChart.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonChart.ForeColor = System.Drawing.Color.Transparent;
            this.iconButtonChart.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.iconButtonChart.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.iconButtonChart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonChart.IconSize = 32;
            this.iconButtonChart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonChart.Location = new System.Drawing.Point(0, 140);
            this.iconButtonChart.Margin = new System.Windows.Forms.Padding(0);
            this.iconButtonChart.Name = "iconButtonChart";
            this.iconButtonChart.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconButtonChart.Size = new System.Drawing.Size(220, 35);
            this.iconButtonChart.TabIndex = 1;
            this.iconButtonChart.Text = "Chart";
            this.iconButtonChart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonChart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonChart.UseVisualStyleBackColor = false;
            this.iconButtonChart.Click += new System.EventHandler(this.iconButtonChart_Click);
            this.iconButtonChart.MouseEnter += new System.EventHandler(this.iconButtonChart_MouseEnter);
            this.iconButtonChart.MouseLeave += new System.EventHandler(this.iconButtonChart_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApp.Properties.Resources.icons8_coffee_to_go_96px;
            this.pictureBox1.Location = new System.Drawing.Point(50, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelBar);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
            this.panel2.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconButtonChart;
        private FontAwesome.Sharp.IconButton iconButtonSettings;
        private FontAwesome.Sharp.IconButton iconButtonExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelBar;
    }
}

