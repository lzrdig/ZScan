namespace WinFormUI
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
            this.axMG17Motor1 = new AxMG17MotorLib.AxMG17Motor();
            this.axMG17System1 = new AxMG17SystemLib.AxMG17System();
            ((System.ComponentModel.ISupportInitialize)(this.axMG17Motor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMG17System1)).BeginInit();
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
            // axMG17Motor1
            // 
            this.axMG17Motor1.Enabled = true;
            this.axMG17Motor1.Location = new System.Drawing.Point(12, 134);
            this.axMG17Motor1.Name = "axMG17Motor1";
            this.axMG17Motor1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMG17Motor1.OcxState")));
            this.axMG17Motor1.Size = new System.Drawing.Size(573, 322);
            this.axMG17Motor1.TabIndex = 5;
            this.axMG17Motor1.Enter += new System.EventHandler(this.axMG17Motor1_Enter);
            // 
            // axMG17System1
            // 
            this.axMG17System1.Enabled = true;
            this.axMG17System1.Location = new System.Drawing.Point(606, 276);
            this.axMG17System1.Name = "axMG17System1";
            this.axMG17System1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMG17System1.OcxState")));
            this.axMG17System1.Size = new System.Drawing.Size(147, 61);
            this.axMG17System1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 468);
            this.Controls.Add(this.axMG17System1);
            this.Controls.Add(this.axMG17Motor1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.initStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stagePos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axMG17Motor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMG17System1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox stagePos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox initStatus;
        private System.Windows.Forms.Button button1;
        private AxMG17MotorLib.AxMG17Motor axMG17Motor1;
        private AxMG17SystemLib.AxMG17System axMG17System1;
    }
}

