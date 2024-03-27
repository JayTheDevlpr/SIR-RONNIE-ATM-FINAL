namespace SIR_RONNIE_ATM
{
    partial class Form3
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pinbox = new Guna.UI2.WinForms.Guna2TextBox();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.xing2;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.profile_user;
            pictureBox2.Location = new Point(330, 53);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(144, 127);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(197, 198, 200);
            label1.Location = new Point(381, 251);
            label1.Name = "label1";
            label1.Size = new Size(42, 23);
            label1.TabIndex = 5;
            label1.Text = "PIN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(197, 198, 200);
            label2.Location = new Point(320, 193);
            label2.Name = "label2";
            label2.Size = new Size(163, 23);
            label2.TabIndex = 7;
            label2.Text = "Account #010101";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(197, 198, 200);
            label3.Location = new Point(301, 415);
            label3.Name = "label3";
            label3.Size = new Size(213, 17);
            label3.TabIndex = 8;
            label3.Text = "We just need to varify if it's you!";
            // 
            // pinbox
            // 
            pinbox.BorderColor = Color.FromArgb(197, 198, 200);
            pinbox.CustomizableEdges = customizableEdges1;
            pinbox.DefaultText = "";
            pinbox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            pinbox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            pinbox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            pinbox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            pinbox.FillColor = Color.FromArgb(197, 198, 200);
            pinbox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            pinbox.Font = new Font("Segoe UI", 9F);
            pinbox.ForeColor = Color.FromArgb(11, 12, 16);
            pinbox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            pinbox.Location = new Point(260, 278);
            pinbox.Margin = new Padding(3, 4, 3, 4);
            pinbox.Name = "pinbox";
            pinbox.PasswordChar = '●';
            pinbox.PlaceholderText = "";
            pinbox.SelectedText = "";
            pinbox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            pinbox.Size = new Size(286, 28);
            pinbox.TabIndex = 9;
            pinbox.TextChanged += pinbox_TextChanged;
            pinbox.Click += pinbox_Click;
            pinbox.Enter += pinbox_Enter;
            pinbox.KeyDown += pinbox_KeyDown;
            pinbox.KeyPress += OnlyNumber;
            // 
            // guna2Button1
            // 
            guna2Button1.BorderColor = Color.FromArgb(197, 198, 200);
            guna2Button1.CustomizableEdges = customizableEdges3;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(197, 198, 200);
            guna2Button1.Font = new Font("Arial", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2Button1.ForeColor = Color.FromArgb(11, 12, 16);
            guna2Button1.Location = new Point(484, 279);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.PressedColor = Color.FromArgb(197, 198, 200);
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button1.Size = new Size(62, 25);
            guna2Button1.TabIndex = 11;
            guna2Button1.Text = "Show";
            guna2Button1.TextAlign = HorizontalAlignment.Right;
            guna2Button1.Click += guna2Button1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 12, 16);
            ClientSize = new Size(800, 450);
            Controls.Add(guna2Button1);
            Controls.Add(pinbox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            KeyDown += Form3_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox pinbox;
    }
}