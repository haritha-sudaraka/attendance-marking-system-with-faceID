namespace Mark_Attendance_UI
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.btnStartFaceScanner = new System.Windows.Forms.Button();
            this.btnAddNewFace = new System.Windows.Forms.Button();
            this.lblHowTo = new System.Windows.Forms.Label();
            this.btnOpenImgDir = new System.Windows.Forms.Button();
            this.btnOpenCSVDir = new System.Windows.Forms.Button();
            this.btnClearOld = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStartFaceScanner
            // 
            this.btnStartFaceScanner.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStartFaceScanner.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartFaceScanner.Location = new System.Drawing.Point(166, 31);
            this.btnStartFaceScanner.Name = "btnStartFaceScanner";
            this.btnStartFaceScanner.Size = new System.Drawing.Size(213, 141);
            this.btnStartFaceScanner.TabIndex = 0;
            this.btnStartFaceScanner.Text = "Start Face\r\nScanner";
            this.btnStartFaceScanner.UseVisualStyleBackColor = true;
            this.btnStartFaceScanner.Click += new System.EventHandler(this.btnStartFaceScanner_Click);
            this.btnStartFaceScanner.MouseEnter += new System.EventHandler(this.btnStartFaceScanner_MouseEnter);
            this.btnStartFaceScanner.MouseLeave += new System.EventHandler(this.btnStartFaceScanner_MouseLeave);
            // 
            // btnAddNewFace
            // 
            this.btnAddNewFace.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddNewFace.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewFace.Location = new System.Drawing.Point(439, 31);
            this.btnAddNewFace.Name = "btnAddNewFace";
            this.btnAddNewFace.Size = new System.Drawing.Size(213, 141);
            this.btnAddNewFace.TabIndex = 0;
            this.btnAddNewFace.Text = "Add\r\nNew Face";
            this.btnAddNewFace.UseVisualStyleBackColor = true;
            this.btnAddNewFace.Click += new System.EventHandler(this.btnAddNewFace_Click);
            this.btnAddNewFace.MouseEnter += new System.EventHandler(this.btnAddNewFace_MouseEnter);
            this.btnAddNewFace.MouseLeave += new System.EventHandler(this.btnAddNewFace_MouseLeave);
            // 
            // lblHowTo
            // 
            this.lblHowTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHowTo.AutoSize = true;
            this.lblHowTo.BackColor = System.Drawing.Color.Transparent;
            this.lblHowTo.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHowTo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHowTo.Location = new System.Drawing.Point(189, 468);
            this.lblHowTo.Name = "lblHowTo";
            this.lblHowTo.Size = new System.Drawing.Size(441, 27);
            this.lblHowTo.TabIndex = 1;
            this.lblHowTo.Text = "How to get the marked attendance sheet?";
            this.lblHowTo.Click += new System.EventHandler(this.lblHowTo_Click);
            this.lblHowTo.MouseEnter += new System.EventHandler(this.lblHowTo_MouseEnter);
            this.lblHowTo.MouseLeave += new System.EventHandler(this.lblHowTo_MouseLeave);
            // 
            // btnOpenImgDir
            // 
            this.btnOpenImgDir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOpenImgDir.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenImgDir.Location = new System.Drawing.Point(166, 202);
            this.btnOpenImgDir.Name = "btnOpenImgDir";
            this.btnOpenImgDir.Size = new System.Drawing.Size(213, 141);
            this.btnOpenImgDir.TabIndex = 2;
            this.btnOpenImgDir.Text = "Open Face\r\nImage Folder";
            this.btnOpenImgDir.UseVisualStyleBackColor = true;
            this.btnOpenImgDir.Click += new System.EventHandler(this.btnOpenImgDir_Click);
            this.btnOpenImgDir.MouseEnter += new System.EventHandler(this.btnOpenImgDir_MouseEnter);
            this.btnOpenImgDir.MouseLeave += new System.EventHandler(this.btnOpenImgDir_MouseLeave);
            // 
            // btnOpenCSVDir
            // 
            this.btnOpenCSVDir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOpenCSVDir.Font = new System.Drawing.Font("Montserrat", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenCSVDir.Location = new System.Drawing.Point(439, 202);
            this.btnOpenCSVDir.Name = "btnOpenCSVDir";
            this.btnOpenCSVDir.Size = new System.Drawing.Size(213, 141);
            this.btnOpenCSVDir.TabIndex = 2;
            this.btnOpenCSVDir.Text = "Open Attendance\r\nSheet Location\r\n(.csv)";
            this.btnOpenCSVDir.UseVisualStyleBackColor = true;
            this.btnOpenCSVDir.Click += new System.EventHandler(this.btnOpenCSVDir_Click);
            this.btnOpenCSVDir.MouseEnter += new System.EventHandler(this.btnOpenCSVDir_MouseEnter);
            this.btnOpenCSVDir.MouseLeave += new System.EventHandler(this.btnOpenCSVDir_MouseLeave);
            // 
            // btnClearOld
            // 
            this.btnClearOld.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClearOld.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearOld.Location = new System.Drawing.Point(166, 369);
            this.btnClearOld.Name = "btnClearOld";
            this.btnClearOld.Size = new System.Drawing.Size(486, 79);
            this.btnClearOld.TabIndex = 3;
            this.btnClearOld.Text = "Clear Old Records";
            this.btnClearOld.UseVisualStyleBackColor = true;
            this.btnClearOld.Click += new System.EventHandler(this.btnClearOld_Click);
            this.btnClearOld.MouseEnter += new System.EventHandler(this.btnClearOld_MouseEnter);
            this.btnClearOld.MouseLeave += new System.EventHandler(this.btnClearOld_MouseLeave);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(833, 552);
            this.Controls.Add(this.btnClearOld);
            this.Controls.Add(this.btnOpenCSVDir);
            this.Controls.Add(this.btnOpenImgDir);
            this.Controls.Add(this.lblHowTo);
            this.Controls.Add(this.btnAddNewFace);
            this.Controls.Add(this.btnStartFaceScanner);
            this.Name = "frmHome";
            this.Text = "Attendance Marking System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartFaceScanner;
        private System.Windows.Forms.Button btnAddNewFace;
        private System.Windows.Forms.Label lblHowTo;
        private System.Windows.Forms.Button btnOpenImgDir;
        private System.Windows.Forms.Button btnOpenCSVDir;
        private System.Windows.Forms.Button btnClearOld;
    }
}

