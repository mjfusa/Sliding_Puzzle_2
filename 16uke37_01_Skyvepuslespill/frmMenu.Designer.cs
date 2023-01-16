namespace WindowsFormsApplication1
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.btnStart = new System.Windows.Forms.Button();
            this.numSize = new System.Windows.Forms.NumericUpDown();
            this.cmbMissing = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.pic1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            resources.ApplyResources(this.btnStart, "btnStart");
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.Name = "btnStart";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // numSize
            // 
            resources.ApplyResources(this.numSize, "numSize");
            this.numSize.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSize.Name = "numSize";
            this.numSize.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // cmbMissing
            // 
            resources.ApplyResources(this.cmbMissing, "cmbMissing");
            this.cmbMissing.AllowDrop = true;
            this.cmbMissing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMissing.FormattingEnabled = true;
            this.cmbMissing.Items.AddRange(new object[] {
            resources.GetString("cmbMissing.Items"),
            resources.GetString("cmbMissing.Items1"),
            resources.GetString("cmbMissing.Items2"),
            resources.GetString("cmbMissing.Items3"),
            resources.GetString("cmbMissing.Items4")});
            this.cmbMissing.Name = "cmbMissing";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // btnSelectImage
            // 
            resources.ApplyResources(this.btnSelectImage, "btnSelectImage");
            this.btnSelectImage.FlatAppearance.BorderSize = 0;
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // pic1
            // 
            resources.ApplyResources(this.pic1, "pic1");
            this.pic1.Image = global::WindowsFormsApplication1.Properties.Resources.tree_square;
            this.pic1.InitialImage = global::WindowsFormsApplication1.Properties.Resources.tree_square;
            this.pic1.Name = "pic1";
            this.pic1.TabStop = false;
            // 
            // frmMenu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.btnSelectImage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMissing);
            this.Controls.Add(this.numSize);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label2);
            this.Name = "frmMenu";
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown numSize;
        private System.Windows.Forms.ComboBox cmbMissing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.PictureBox pic1;
    }
}