namespace WindowsFormsApplication1
{
    partial class frmGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGame));
            this.tmrSec = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.txtCounter = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.btnMix = new System.Windows.Forms.Button();
            this.txtCounter2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tmrSec
            // 
            this.tmrSec.Interval = 1000;
            this.tmrSec.Tick += new System.EventHandler(this.tmrSec_Tick);
            // 
            // btnStart
            // 
            resources.ApplyResources(this.btnStart, "btnStart");
            this.btnStart.BackColor = System.Drawing.Color.LimeGreen;
            this.btnStart.Name = "btnStart";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtCounter
            // 
            resources.ApplyResources(this.txtCounter, "txtCounter");
            this.txtCounter.BackColor = System.Drawing.Color.White;
            this.txtCounter.Name = "txtCounter";
            this.txtCounter.ReadOnly = true;
            // 
            // txtTime
            // 
            resources.ApplyResources(this.txtTime, "txtTime");
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            // 
            // btnMix
            // 
            resources.ApplyResources(this.btnMix, "btnMix");
            this.btnMix.BackColor = System.Drawing.Color.DarkOrange;
            this.btnMix.Name = "btnMix";
            this.btnMix.UseVisualStyleBackColor = false;
            this.btnMix.Click += new System.EventHandler(this.btnMix_Click);
            // 
            // txtCounter2
            // 
            resources.ApplyResources(this.txtCounter2, "txtCounter2");
            this.txtCounter2.BackColor = System.Drawing.Color.White;
            this.txtCounter2.Name = "txtCounter2";
            this.txtCounter2.ReadOnly = true;
            // 
            // frmGame
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.btnMix);
            this.Controls.Add(this.txtCounter2);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtCounter);
            this.Controls.Add(this.btnStart);
            this.DoubleBuffered = true;
            this.Name = "frmGame";
            this.Load += new System.EventHandler(this.frmGame_Load);
            this.Resize += new System.EventHandler(this.game_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmrSec;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtCounter;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Button btnMix;
        private System.Windows.Forms.TextBox txtCounter2;
    }
}