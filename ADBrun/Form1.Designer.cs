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
            label3 = new Label();
            SuspendLayout();
            // 
            // IpTextBox
            // 
            IpTextBox.Location = new Point(23, 33);
            IpTextBox.Name = "IpTextBox";
            IpTextBox.Size = new Size(212, 23);
            IpTextBox.TabIndex = 0;
            IpTextBox.Text = "192.168.1.2";
            IpTextBox.TextChanged += IpTextBox_TextChanged;
            // 
            // PortTextBox
            // 
            PortTextBox.Location = new Point(261, 33);
            PortTextBox.Name = "PortTextBox";
            PortTextBox.Size = new Size(61, 23);
            PortTextBox.TabIndex = 1;
            PortTextBox.Text = "5555";
            PortTextBox.TextChanged += PortTextBox_TextChanged;
            // 
            // ConnectButton
            // 
            ConnectButton.Location = new Point(261, 62);
            ConnectButton.Name = "ConnectButton";
            ConnectButton.Size = new Size(61, 23);
            ConnectButton.TabIndex = 2;
            ConnectButton.Text = "Connect";
            ConnectButton.UseVisualStyleBackColor = true;
            ConnectButton.Click += ConnectButton_Click;
            // 
            // DevicesButton
            // 
            DevicesButton.Location = new Point(139, 62);
            DevicesButton.Name = "DevicesButton";
            DevicesButton.Size = new Size(96, 23);
            DevicesButton.TabIndex = 3;
            DevicesButton.Text = "Show Devices";
            DevicesButton.UseVisualStyleBackColor = true;
            DevicesButton.Click += DevicesButton_Click;
            // 
            // ResetButton
            // 
            ResetButton.Location = new Point(23, 62);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(110, 23);
            ResetButton.TabIndex = 4;
            ResetButton.Text = "Reset To USB  mode";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += ResetButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 15);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 5;
            label1.Text = "The IP of your phone";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(261, 15);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 6;
            label2.Text = "Optional";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 103);
            label3.Name = "label3";
            label3.Size = new Size(256, 30);
            label3.TabIndex = 7;
            label3.Text = "Make sure your phone is connected to the USB \nwhile using the connect command";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 148);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ResetButton);
            Controls.Add(DevicesButton);
            Controls.Add(ConnectButton);
            Controls.Add(PortTextBox);
            Controls.Add(IpTextBox);
            Name = "Form1";
            Text = "Wifi Debugging Tool";
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
        private Label label3;
    }
}