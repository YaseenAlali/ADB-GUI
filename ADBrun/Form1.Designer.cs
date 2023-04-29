namespace ADBrun
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
            IpTextBox = new TextBox();
            PortTextBox = new TextBox();
            ConnectButton = new Button();
            DevicesButton = new Button();
            ResetButton = new Button();
            label1 = new Label();
            label2 = new Label();
            DisconnectTextBkx = new TextBox();
            DiscPortTextBox = new TextBox();
            DiscButton = new Button();
            DetachButton = new Button();
            AttachButton = new Button();
            label3 = new Label();
            label4 = new Label();
            HelpButton = new Button();
            CLITextBox = new TextBox();
            CLIButton = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // IpTextBox
            // 
            IpTextBox.Location = new Point(12, 23);
            IpTextBox.Name = "IpTextBox";
            IpTextBox.Size = new Size(212, 23);
            IpTextBox.TabIndex = 0;
            IpTextBox.Text = "192.168.1.2";
            IpTextBox.TextChanged += IpTextBox_TextChanged;
            // 
            // PortTextBox
            // 
            PortTextBox.Location = new Point(250, 23);
            PortTextBox.Name = "PortTextBox";
            PortTextBox.Size = new Size(61, 23);
            PortTextBox.TabIndex = 1;
            PortTextBox.Text = "5555";
            PortTextBox.TextChanged += PortTextBox_TextChanged;
            // 
            // ConnectButton
            // 
            ConnectButton.Location = new Point(332, 23);
            ConnectButton.Name = "ConnectButton";
            ConnectButton.Size = new Size(77, 23);
            ConnectButton.TabIndex = 2;
            ConnectButton.Text = "Connect";
            ConnectButton.UseVisualStyleBackColor = true;
            ConnectButton.Click += ConnectButton_Click;
            // 
            // DevicesButton
            // 
            DevicesButton.Location = new Point(110, 185);
            DevicesButton.Name = "DevicesButton";
            DevicesButton.Size = new Size(114, 23);
            DevicesButton.TabIndex = 3;
            DevicesButton.Text = "Show Devices";
            DevicesButton.UseVisualStyleBackColor = true;
            DevicesButton.Click += DevicesButton_Click;
            // 
            // ResetButton
            // 
            ResetButton.Location = new Point(12, 185);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(92, 23);
            ResetButton.TabIndex = 4;
            ResetButton.Text = "Reset To USB  mode";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += ResetButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 5);
            label1.Name = "label1";
            label1.Size = new Size(142, 15);
            label1.TabIndex = 5;
            label1.Text = "IP of phone to connect to";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(233, 5);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 6;
            label2.Text = "Optional port";
            // 
            // DisconnectTextBkx
            // 
            DisconnectTextBkx.Location = new Point(12, 69);
            DisconnectTextBkx.Name = "DisconnectTextBkx";
            DisconnectTextBkx.Size = new Size(212, 23);
            DisconnectTextBkx.TabIndex = 8;
            DisconnectTextBkx.Text = "192.168.1.2";
            // 
            // DiscPortTextBox
            // 
            DiscPortTextBox.Location = new Point(250, 69);
            DiscPortTextBox.Name = "DiscPortTextBox";
            DiscPortTextBox.Size = new Size(61, 23);
            DiscPortTextBox.TabIndex = 9;
            DiscPortTextBox.Text = "5555";
            // 
            // DiscButton
            // 
            DiscButton.Location = new Point(332, 69);
            DiscButton.Name = "DiscButton";
            DiscButton.Size = new Size(77, 23);
            DiscButton.TabIndex = 10;
            DiscButton.Text = "Disconnect";
            DiscButton.UseVisualStyleBackColor = true;
            DiscButton.Click += DiscButton_Click;
            // 
            // DetachButton
            // 
            DetachButton.Location = new Point(110, 156);
            DetachButton.Name = "DetachButton";
            DetachButton.Size = new Size(114, 23);
            DetachButton.TabIndex = 11;
            DetachButton.Text = "Detach from USB";
            DetachButton.UseVisualStyleBackColor = true;
            DetachButton.Click += DetachButton_Click;
            // 
            // AttachButton
            // 
            AttachButton.Location = new Point(12, 156);
            AttachButton.Name = "AttachButton";
            AttachButton.Size = new Size(92, 23);
            AttachButton.TabIndex = 12;
            AttachButton.Text = "Attach to USB";
            AttachButton.UseVisualStyleBackColor = true;
            AttachButton.Click += AttachButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 49);
            label3.Name = "label3";
            label3.Size = new Size(172, 15);
            label3.TabIndex = 13;
            label3.Text = "IP of phone to disconnect from";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(233, 49);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 14;
            label4.Text = "Optional port";
            // 
            // HelpButton
            // 
            HelpButton.Location = new Point(250, 156);
            HelpButton.Name = "HelpButton";
            HelpButton.Size = new Size(159, 23);
            HelpButton.TabIndex = 15;
            HelpButton.Text = "Help";
            HelpButton.UseVisualStyleBackColor = true;
            HelpButton.Click += HelpButton_Click;
            // 
            // CLITextBox
            // 
            CLITextBox.Location = new Point(14, 124);
            CLITextBox.Name = "CLITextBox";
            CLITextBox.Size = new Size(297, 23);
            CLITextBox.TabIndex = 16;
            CLITextBox.Text = "adb";
            // 
            // CLIButton
            // 
            CLIButton.Location = new Point(332, 123);
            CLIButton.Name = "CLIButton";
            CLIButton.Size = new Size(77, 23);
            CLIButton.TabIndex = 17;
            CLIButton.Text = "Enter";
            CLIButton.UseVisualStyleBackColor = true;
            CLIButton.Click += CLIButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 103);
            label5.Name = "label5";
            label5.Size = new Size(159, 15);
            label5.TabIndex = 18;
            label5.Text = "ADB command line interface";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 219);
            Controls.Add(label5);
            Controls.Add(CLIButton);
            Controls.Add(CLITextBox);
            Controls.Add(HelpButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(AttachButton);
            Controls.Add(DetachButton);
            Controls.Add(DiscButton);
            Controls.Add(DiscPortTextBox);
            Controls.Add(DisconnectTextBkx);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ResetButton);
            Controls.Add(DevicesButton);
            Controls.Add(ConnectButton);
            Controls.Add(PortTextBox);
            Controls.Add(IpTextBox);
            Name = "Form1";
            Text = "Wifi Debugging Tool";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox IpTextBox;
        private TextBox PortTextBox;
        private Button ConnectButton;
        private Button DevicesButton;
        private Button ResetButton;
        private Label label1;
        private Label label2;
        private TextBox DisconnectTextBkx;
        private TextBox DiscPortTextBox;
        private Button DiscButton;
        private Button DetachButton;
        private Button AttachButton;
        private Label label3;
        private Label label4;
        private Button HelpButton;
        private TextBox CLITextBox;
        private Button CLIButton;
        private Label label5;
    }
}