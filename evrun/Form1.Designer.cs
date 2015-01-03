namespace evrun
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblHasOre = new System.Windows.Forms.Label();
            this.runTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblEnemies = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMinersInSpace = new System.Windows.Forms.Label();
            this.lblMiningTarget = new System.Windows.Forms.Label();
            this.lablelminings = new System.Windows.Forms.Label();
            this.lblAttackDronesInSpace = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rtbMessages = new System.Windows.Forms.RichTextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(606, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblHasOre
            // 
            this.lblHasOre.AutoSize = true;
            this.lblHasOre.Location = new System.Drawing.Point(222, 20);
            this.lblHasOre.Name = "lblHasOre";
            this.lblHasOre.Size = new System.Drawing.Size(0, 13);
            this.lblHasOre.TabIndex = 1;
            // 
            // runTimer
            // 
            this.runTimer.Interval = 3000;
            this.runTimer.Tick += new System.EventHandler(this.runTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enemies";
            // 
            // lblEnemies
            // 
            this.lblEnemies.AutoSize = true;
            this.lblEnemies.Location = new System.Drawing.Point(96, 35);
            this.lblEnemies.Name = "lblEnemies";
            this.lblEnemies.Size = new System.Drawing.Size(0, 13);
            this.lblEnemies.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Miners In Space";
            // 
            // lblMinersInSpace
            // 
            this.lblMinersInSpace.AutoSize = true;
            this.lblMinersInSpace.Location = new System.Drawing.Point(99, 52);
            this.lblMinersInSpace.Name = "lblMinersInSpace";
            this.lblMinersInSpace.Size = new System.Drawing.Size(0, 13);
            this.lblMinersInSpace.TabIndex = 5;
            // 
            // lblMiningTarget
            // 
            this.lblMiningTarget.AutoSize = true;
            this.lblMiningTarget.Location = new System.Drawing.Point(113, 91);
            this.lblMiningTarget.Name = "lblMiningTarget";
            this.lblMiningTarget.Size = new System.Drawing.Size(35, 13);
            this.lblMiningTarget.TabIndex = 9;
            this.lblMiningTarget.Text = "label5";
            // 
            // lablelminings
            // 
            this.lablelminings.AutoSize = true;
            this.lablelminings.Location = new System.Drawing.Point(13, 91);
            this.lablelminings.Name = "lablelminings";
            this.lablelminings.Size = new System.Drawing.Size(94, 13);
            this.lablelminings.TabIndex = 8;
            this.lablelminings.Text = "Has Mining Target";
            // 
            // lblAttackDronesInSpace
            // 
            this.lblAttackDronesInSpace.AutoSize = true;
            this.lblAttackDronesInSpace.Location = new System.Drawing.Point(113, 74);
            this.lblAttackDronesInSpace.Name = "lblAttackDronesInSpace";
            this.lblAttackDronesInSpace.Size = new System.Drawing.Size(35, 13);
            this.lblAttackDronesInSpace.TabIndex = 7;
            this.lblAttackDronesInSpace.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Attack Drones Out";
            // 
            // rtbMessages
            // 
            this.rtbMessages.Location = new System.Drawing.Point(6, 121);
            this.rtbMessages.Name = "rtbMessages";
            this.rtbMessages.Size = new System.Drawing.Size(665, 329);
            this.rtbMessages.TabIndex = 10;
            this.rtbMessages.Text = "";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(510, 468);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 11;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 503);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.rtbMessages);
            this.Controls.Add(this.lblMiningTarget);
            this.Controls.Add(this.lablelminings);
            this.Controls.Add(this.lblAttackDronesInSpace);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblMinersInSpace);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblEnemies);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHasOre);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblHasOre;
        private System.Windows.Forms.Timer runTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEnemies;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMinersInSpace;
        private System.Windows.Forms.Label lblMiningTarget;
        private System.Windows.Forms.Label lablelminings;
        private System.Windows.Forms.Label lblAttackDronesInSpace;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rtbMessages;
        private System.Windows.Forms.Button btnStop;
    }
}

