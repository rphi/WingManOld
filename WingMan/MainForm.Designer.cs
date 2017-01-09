﻿using System;
using WingMan.Objects;

namespace WingMan
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageLog = new System.Windows.Forms.TabPage();
            this.sourceTabPage = new System.Windows.Forms.TabPage();
            this.arduinoSettingsPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.arduinoSettingsLabel = new System.Windows.Forms.Label();
            this.arduinoSerialPortCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sourceModeCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.targetTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.targetPortTextBox = new System.Windows.Forms.TextBox();
            this.sourceLinkLabel = new System.Windows.Forms.LinkLabel();
            this.sourceTextBox = new System.Windows.Forms.TextBox();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageLog.SuspendLayout();
            this.sourceTabPage.SuspendLayout();
            this.arduinoSettingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(224, 131);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Log: (recent OSC commands)";
            // 
            // connectButton
            // 
            this.connectButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.connectButton.Location = new System.Drawing.Point(15, 153);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(94, 32);
            this.connectButton.TabIndex = 5;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = false;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 198);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(468, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageLog);
            this.tabControl1.Controls.Add(this.sourceTabPage);
            this.tabControl1.Location = new System.Drawing.Point(212, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(244, 183);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPageLog
            // 
            this.tabPageLog.Controls.Add(this.textBox1);
            this.tabPageLog.Controls.Add(this.label2);
            this.tabPageLog.Location = new System.Drawing.Point(4, 22);
            this.tabPageLog.Name = "tabPageLog";
            this.tabPageLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLog.Size = new System.Drawing.Size(236, 157);
            this.tabPageLog.TabIndex = 0;
            this.tabPageLog.Text = "OSC Log";
            this.tabPageLog.UseVisualStyleBackColor = true;
            // 
            // sourceTabPage
            // 
            this.sourceTabPage.Controls.Add(this.arduinoSettingsPanel);
            this.sourceTabPage.Controls.Add(this.label3);
            this.sourceTabPage.Controls.Add(this.sourceModeCombo);
            this.sourceTabPage.Location = new System.Drawing.Point(4, 22);
            this.sourceTabPage.Name = "sourceTabPage";
            this.sourceTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.sourceTabPage.Size = new System.Drawing.Size(236, 157);
            this.sourceTabPage.TabIndex = 1;
            this.sourceTabPage.Text = "Source";
            this.sourceTabPage.UseVisualStyleBackColor = true;
            // 
            // arduinoSettingsPanel
            // 
            this.arduinoSettingsPanel.Controls.Add(this.label4);
            this.arduinoSettingsPanel.Controls.Add(this.arduinoSettingsLabel);
            this.arduinoSettingsPanel.Controls.Add(this.arduinoSerialPortCombo);
            this.arduinoSettingsPanel.Location = new System.Drawing.Point(0, 33);
            this.arduinoSettingsPanel.Name = "arduinoSettingsPanel";
            this.arduinoSettingsPanel.Size = new System.Drawing.Size(236, 124);
            this.arduinoSettingsPanel.TabIndex = 2;
            this.arduinoSettingsPanel.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Serial Port:";
            // 
            // arduinoSettingsLabel
            // 
            this.arduinoSettingsLabel.AutoSize = true;
            this.arduinoSettingsLabel.Location = new System.Drawing.Point(3, 0);
            this.arduinoSettingsLabel.Name = "arduinoSettingsLabel";
            this.arduinoSettingsLabel.Size = new System.Drawing.Size(217, 26);
            this.arduinoSettingsLabel.TabIndex = 0;
            this.arduinoSettingsLabel.Text = "Please ensure you have the correct firmware\r\ninstalled on your Arduino.";
            // 
            // arduinoSerialPortCombo
            // 
            this.arduinoSerialPortCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.arduinoSerialPortCombo.FormattingEnabled = true;
            this.arduinoSerialPortCombo.Location = new System.Drawing.Point(97, 42);
            this.arduinoSerialPortCombo.Name = "arduinoSerialPortCombo";
            this.arduinoSerialPortCombo.Size = new System.Drawing.Size(121, 21);
            this.arduinoSerialPortCombo.TabIndex = 0;
            this.arduinoSerialPortCombo.SelectedIndexChanged += new System.EventHandler(this.sourceModeCombo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mode:";
            // 
            // sourceModeCombo
            // 
            this.sourceModeCombo.DataSource = new WingMan.Objects.SourceMode[] {
        WingMan.Objects.SourceMode.None,
        WingMan.Objects.SourceMode.Arduino};
            this.sourceModeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sourceModeCombo.FormattingEnabled = true;
            this.sourceModeCombo.Items.AddRange(new object[] {
            WingMan.Objects.SourceMode.None,
            WingMan.Objects.SourceMode.Arduino});
            this.sourceModeCombo.Location = new System.Drawing.Point(106, 6);
            this.sourceModeCombo.Name = "sourceModeCombo";
            this.sourceModeCombo.Size = new System.Drawing.Size(121, 21);
            this.sourceModeCombo.TabIndex = 0;
            this.sourceModeCombo.SelectedIndexChanged += new System.EventHandler(this.sourceModeCombo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Target:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.BackColor = System.Drawing.Color.OrangeRed;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.statusLabel.Location = new System.Drawing.Point(12, 12);
            this.statusLabel.MinimumSize = new System.Drawing.Size(185, 40);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(185, 40);
            this.statusLabel.TabIndex = 9;
            this.statusLabel.Text = "Disconnected";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // targetTextBox
            // 
            this.targetTextBox.Location = new System.Drawing.Point(83, 59);
            this.targetTextBox.Name = "targetTextBox";
            this.targetTextBox.Size = new System.Drawing.Size(114, 20);
            this.targetTextBox.TabIndex = 10;
            this.targetTextBox.Text = "127.0.01";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Target port:";
            // 
            // targetPortTextBox
            // 
            this.targetPortTextBox.Location = new System.Drawing.Point(83, 85);
            this.targetPortTextBox.Name = "targetPortTextBox";
            this.targetPortTextBox.Size = new System.Drawing.Size(47, 20);
            this.targetPortTextBox.TabIndex = 10;
            this.targetPortTextBox.Text = "3032";
            // 
            // sourceLinkLabel
            // 
            this.sourceLinkLabel.AutoSize = true;
            this.sourceLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.sourceLinkLabel.Location = new System.Drawing.Point(12, 110);
            this.sourceLinkLabel.Name = "sourceLinkLabel";
            this.sourceLinkLabel.Size = new System.Drawing.Size(49, 15);
            this.sourceLinkLabel.TabIndex = 11;
            this.sourceLinkLabel.TabStop = true;
            this.sourceLinkLabel.Text = "Source:";
            this.sourceLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.sourceLinkLabel_LinkClicked);
            // 
            // sourceTextBox
            // 
            this.sourceTextBox.Location = new System.Drawing.Point(83, 110);
            this.sourceTextBox.Name = "sourceTextBox";
            this.sourceTextBox.ReadOnly = true;
            this.sourceTextBox.Size = new System.Drawing.Size(114, 20);
            this.sourceTextBox.TabIndex = 10;
            this.sourceTextBox.Text = "Not Configured!";
            // 
            // disconnectButton
            // 
            this.disconnectButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.disconnectButton.Enabled = false;
            this.disconnectButton.Location = new System.Drawing.Point(115, 153);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(82, 32);
            this.disconnectButton.TabIndex = 5;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = false;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 220);
            this.Controls.Add(this.sourceLinkLabel);
            this.Controls.Add(this.sourceTextBox);
            this.Controls.Add(this.targetPortTextBox);
            this.Controls.Add(this.targetTextBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.disconnectButton);
            this.Controls.Add(this.connectButton);
            this.Name = "MainForm";
            this.Text = "WingMan for Eos";
            this.tabControl1.ResumeLayout(false);
            this.tabPageLog.ResumeLayout(false);
            this.tabPageLog.PerformLayout();
            this.sourceTabPage.ResumeLayout(false);
            this.sourceTabPage.PerformLayout();
            this.arduinoSettingsPanel.ResumeLayout(false);
            this.arduinoSettingsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox targetTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox targetPortTextBox;
        private System.Windows.Forms.TabPage sourceTabPage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox sourceModeCombo;
        private System.Windows.Forms.LinkLabel sourceLinkLabel;
        private System.Windows.Forms.TextBox sourceTextBox;
        private System.Windows.Forms.Panel arduinoSettingsPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label arduinoSettingsLabel;
        private System.Windows.Forms.ComboBox arduinoSerialPortCombo;
        private System.Windows.Forms.Button disconnectButton;
    }
}

