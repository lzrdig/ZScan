﻿namespace WinFormUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.stagePos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.initStatus = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.axCWKnob1 = new AxCWUIControlsLib.AxCWKnob();
            ((System.ComponentModel.ISupportInitialize)(this.axCWKnob1)).BeginInit();
            this.SuspendLayout();
            // 
            // stagePos
            // 
            this.stagePos.Location = new System.Drawing.Point(36, 65);
            this.stagePos.Name = "stagePos";
            this.stagePos.Size = new System.Drawing.Size(100, 20);
            this.stagePos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stage Position";
            // 
            // initStatus
            // 
            this.initStatus.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.initStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.initStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initStatus.Location = new System.Drawing.Point(606, 65);
            this.initStatus.Name = "initStatus";
            this.initStatus.Size = new System.Drawing.Size(122, 22);
            this.initStatus.TabIndex = 2;
            this.initStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(606, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 66);
            this.button1.TabIndex = 3;
            this.button1.Text = "MOVE";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // axCWKnob1
            // 
            this.axCWKnob1.Location = new System.Drawing.Point(591, 197);
            this.axCWKnob1.Name = "axCWKnob1";
            this.axCWKnob1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axCWKnob1.OcxState")));
            this.axCWKnob1.Size = new System.Drawing.Size(162, 147);
            this.axCWKnob1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 468);
            this.Controls.Add(this.axCWKnob1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.initStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stagePos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axCWKnob1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox stagePos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox initStatus;
        private System.Windows.Forms.Button button1;
        private AxCWUIControlsLib.AxCWKnob axCWKnob1;
    }
}

