namespace LinkifyApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.login_panel = new System.Windows.Forms.Panel();
            this.login_button = new System.Windows.Forms.Button();
            this.logged_in_as = new System.Windows.Forms.Label();
            this.login_label = new System.Windows.Forms.Label();
            this.songpairing_panel = new System.Windows.Forms.Panel();
            this.songpairing_output = new System.Windows.Forms.Label();
            this.submit_songpairing = new System.Windows.Forms.Button();
            this.songvalue_box = new System.Windows.Forms.TextBox();
            this.songkey_box = new System.Windows.Forms.TextBox();
            this.control_panel = new System.Windows.Forms.Panel();
            this.ouput_label = new System.Windows.Forms.Label();
            this.info_label = new System.Windows.Forms.Label();
            this.start_timer = new System.Windows.Forms.Button();
            this.todolabel = new System.Windows.Forms.Label();
            this.login_panel.SuspendLayout();
            this.songpairing_panel.SuspendLayout();
            this.control_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_panel
            // 
            this.login_panel.Controls.Add(this.login_button);
            this.login_panel.Controls.Add(this.logged_in_as);
            this.login_panel.Controls.Add(this.login_label);
            this.login_panel.Location = new System.Drawing.Point(582, 12);
            this.login_panel.Name = "login_panel";
            this.login_panel.Size = new System.Drawing.Size(206, 83);
            this.login_panel.TabIndex = 0;
            this.login_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.login_panel_Paint);
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(64, 18);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(75, 23);
            this.login_button.TabIndex = 2;
            this.login_button.Text = "Login!";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // logged_in_as
            // 
            this.logged_in_as.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logged_in_as.Location = new System.Drawing.Point(0, 68);
            this.logged_in_as.Name = "logged_in_as";
            this.logged_in_as.Size = new System.Drawing.Size(206, 15);
            this.logged_in_as.TabIndex = 1;
            this.logged_in_as.Text = "N/A";
            this.logged_in_as.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Location = new System.Drawing.Point(64, 44);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(77, 15);
            this.login_label.TabIndex = 0;
            this.login_label.Text = "Logged in as:";
            // 
            // songpairing_panel
            // 
            this.songpairing_panel.Controls.Add(this.songpairing_output);
            this.songpairing_panel.Controls.Add(this.submit_songpairing);
            this.songpairing_panel.Controls.Add(this.songvalue_box);
            this.songpairing_panel.Controls.Add(this.songkey_box);
            this.songpairing_panel.Enabled = false;
            this.songpairing_panel.Location = new System.Drawing.Point(460, 113);
            this.songpairing_panel.Name = "songpairing_panel";
            this.songpairing_panel.Size = new System.Drawing.Size(328, 325);
            this.songpairing_panel.TabIndex = 1;
            this.songpairing_panel.Visible = false;
            // 
            // songpairing_output
            // 
            this.songpairing_output.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.songpairing_output.Location = new System.Drawing.Point(0, 264);
            this.songpairing_output.Name = "songpairing_output";
            this.songpairing_output.Size = new System.Drawing.Size(328, 61);
            this.songpairing_output.TabIndex = 2;
            this.songpairing_output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // submit_songpairing
            // 
            this.submit_songpairing.Location = new System.Drawing.Point(122, 238);
            this.submit_songpairing.Name = "submit_songpairing";
            this.submit_songpairing.Size = new System.Drawing.Size(75, 23);
            this.submit_songpairing.TabIndex = 1;
            this.submit_songpairing.Text = "Submit";
            this.submit_songpairing.UseVisualStyleBackColor = true;
            this.submit_songpairing.Click += new System.EventHandler(this.submit_songpairing_Click);
            // 
            // songvalue_box
            // 
            this.songvalue_box.Location = new System.Drawing.Point(45, 120);
            this.songvalue_box.Name = "songvalue_box";
            this.songvalue_box.Size = new System.Drawing.Size(242, 23);
            this.songvalue_box.TabIndex = 0;
            this.songvalue_box.Text = "Song value";
            // 
            // songkey_box
            // 
            this.songkey_box.Location = new System.Drawing.Point(45, 51);
            this.songkey_box.Name = "songkey_box";
            this.songkey_box.Size = new System.Drawing.Size(242, 23);
            this.songkey_box.TabIndex = 0;
            this.songkey_box.Text = "Song key";
            // 
            // control_panel
            // 
            this.control_panel.Controls.Add(this.todolabel);
            this.control_panel.Controls.Add(this.ouput_label);
            this.control_panel.Controls.Add(this.info_label);
            this.control_panel.Controls.Add(this.start_timer);
            this.control_panel.Enabled = false;
            this.control_panel.Location = new System.Drawing.Point(13, 12);
            this.control_panel.Name = "control_panel";
            this.control_panel.Size = new System.Drawing.Size(441, 426);
            this.control_panel.TabIndex = 2;
            this.control_panel.Visible = false;
            this.control_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.control_panel_Paint);
            // 
            // ouput_label
            // 
            this.ouput_label.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ouput_label.Location = new System.Drawing.Point(0, 379);
            this.ouput_label.Name = "ouput_label";
            this.ouput_label.Size = new System.Drawing.Size(441, 47);
            this.ouput_label.TabIndex = 2;
            this.ouput_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // info_label
            // 
            this.info_label.AutoSize = true;
            this.info_label.Location = new System.Drawing.Point(85, 292);
            this.info_label.Name = "info_label";
            this.info_label.Size = new System.Drawing.Size(260, 15);
            this.info_label.TabIndex = 1;
            this.info_label.Text = "Click to activate Linkify. Click again to turn it off";
            // 
            // start_timer
            // 
            this.start_timer.Location = new System.Drawing.Point(170, 310);
            this.start_timer.Name = "start_timer";
            this.start_timer.Size = new System.Drawing.Size(75, 23);
            this.start_timer.TabIndex = 0;
            this.start_timer.Text = "Start";
            this.start_timer.UseVisualStyleBackColor = true;
            this.start_timer.Click += new System.EventHandler(this.start_timer_Click);
            // 
            // todolabel
            // 
            this.todolabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.todolabel.Location = new System.Drawing.Point(0, 0);
            this.todolabel.Name = "todolabel";
            this.todolabel.Size = new System.Drawing.Size(441, 83);
            this.todolabel.TabIndex = 3;
            this.todolabel.Text = "Song pairing window will go here All song pairings are permanent until this is ad" +
    "ded teehee";
            this.todolabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.control_panel);
            this.Controls.Add(this.songpairing_panel);
            this.Controls.Add(this.login_panel);
            this.Name = "Form1";
            this.Text = "Linkify Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.login_panel.ResumeLayout(false);
            this.login_panel.PerformLayout();
            this.songpairing_panel.ResumeLayout(false);
            this.songpairing_panel.PerformLayout();
            this.control_panel.ResumeLayout(false);
            this.control_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel login_panel;
        private System.Windows.Forms.Label logged_in_as;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Panel songpairing_panel;
        private System.Windows.Forms.TextBox songvalue_box;
        private System.Windows.Forms.TextBox songkey_box;
        private System.Windows.Forms.Panel control_panel;
        private System.Windows.Forms.Button submit_songpairing;
        private System.Windows.Forms.Label info_label;
        private System.Windows.Forms.Button start_timer;
        private System.Windows.Forms.Label ouput_label;
        private System.Windows.Forms.Label songpairing_output;
        private System.Windows.Forms.Label todolabel;
    }
}

