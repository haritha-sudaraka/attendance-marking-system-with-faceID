namespace Mark_Attendance_UI
{
    partial class Add_Image
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Image));
            this.picBoxPreview = new System.Windows.Forms.PictureBox();
            this.btnAddFace = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblImageURL = new System.Windows.Forms.Label();
            this.lblImageLocation = new System.Windows.Forms.Label();
            this.btnCheckFaces = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRename = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxPreview
            // 
            this.picBoxPreview.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picBoxPreview.BackColor = System.Drawing.Color.Transparent;
            this.picBoxPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxPreview.Location = new System.Drawing.Point(462, 22);
            this.picBoxPreview.Name = "picBoxPreview";
            this.picBoxPreview.Size = new System.Drawing.Size(439, 431);
            this.picBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxPreview.TabIndex = 0;
            this.picBoxPreview.TabStop = false;
            // 
            // btnAddFace
            // 
            this.btnAddFace.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddFace.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAddFace.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFace.Location = new System.Drawing.Point(122, 71);
            this.btnAddFace.Name = "btnAddFace";
            this.btnAddFace.Size = new System.Drawing.Size(207, 110);
            this.btnAddFace.TabIndex = 1;
            this.btnAddFace.Text = "Add Face Image";
            this.btnAddFace.UseVisualStyleBackColor = false;
            this.btnAddFace.Click += new System.EventHandler(this.btnAddFace_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfirm.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnConfirm.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(58, 433);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(147, 66);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Save and Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(245, 433);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(147, 66);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.MouseEnter += new System.EventHandler(this.btnCancel_MouseEnter);
            this.btnCancel.MouseLeave += new System.EventHandler(this.btnCancel_MouseLeave);
            // 
            // lblImageURL
            // 
            this.lblImageURL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblImageURL.AutoSize = true;
            this.lblImageURL.Location = new System.Drawing.Point(459, 522);
            this.lblImageURL.Name = "lblImageURL";
            this.lblImageURL.Size = new System.Drawing.Size(0, 17);
            this.lblImageURL.TabIndex = 2;
            // 
            // lblImageLocation
            // 
            this.lblImageLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblImageLocation.AutoSize = true;
            this.lblImageLocation.BackColor = System.Drawing.Color.Transparent;
            this.lblImageLocation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblImageLocation.Location = new System.Drawing.Point(12, 542);
            this.lblImageLocation.Name = "lblImageLocation";
            this.lblImageLocation.Size = new System.Drawing.Size(111, 17);
            this.lblImageLocation.TabIndex = 3;
            this.lblImageLocation.Text = "No File Selected";
            // 
            // btnCheckFaces
            // 
            this.btnCheckFaces.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCheckFaces.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckFaces.Location = new System.Drawing.Point(462, 472);
            this.btnCheckFaces.Name = "btnCheckFaces";
            this.btnCheckFaces.Size = new System.Drawing.Size(439, 67);
            this.btnCheckFaces.TabIndex = 4;
            this.btnCheckFaces.Text = "Check This Image for Faces";
            this.btnCheckFaces.UseVisualStyleBackColor = true;
            this.btnCheckFaces.Click += new System.EventHandler(this.btnCheckFaces_Click);
            this.btnCheckFaces.MouseEnter += new System.EventHandler(this.btnCheckFaces_MouseEnter);
            this.btnCheckFaces.MouseLeave += new System.EventHandler(this.btnCheckFaces_MouseLeave);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(66, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "*This name will be used for marking the name.";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(64, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Rename Image";
            // 
            // textBoxRename
            // 
            this.textBoxRename.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxRename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRename.Location = new System.Drawing.Point(69, 291);
            this.textBoxRename.Name = "textBoxRename";
            this.textBoxRename.Size = new System.Drawing.Size(299, 30);
            this.textBoxRename.TabIndex = 8;
            // 
            // Add_Image
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(921, 568);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRename);
            this.Controls.Add(this.btnCheckFaces);
            this.Controls.Add(this.lblImageLocation);
            this.Controls.Add(this.lblImageURL);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnAddFace);
            this.Controls.Add(this.picBoxPreview);
            this.Name = "Add_Image";
            this.Text = "Add_Image";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxPreview;
        private System.Windows.Forms.Button btnAddFace;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblImageURL;
        private System.Windows.Forms.Label lblImageLocation;
        private System.Windows.Forms.Button btnCheckFaces;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRename;
    }
}