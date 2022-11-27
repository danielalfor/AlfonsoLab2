namespace AlfonsoLab2
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPicture = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnData = new System.Windows.Forms.Button();
            this.lblStory = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtMultiplier = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblAns = new System.Windows.Forms.Label();
            this.lblMultiplier = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPicture);
            this.groupBox2.Controls.Add(this.lblTitle);
            this.groupBox2.Controls.Add(this.btnExit);
            this.groupBox2.Controls.Add(this.btnHide);
            this.groupBox2.Controls.Add(this.btnData);
            this.groupBox2.Controls.Add(this.lblStory);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(246, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 294);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information";
            // 
            // btnPicture
            // 
            this.btnPicture.Location = new System.Drawing.Point(15, 227);
            this.btnPicture.Name = "btnPicture";
            this.btnPicture.Size = new System.Drawing.Size(81, 34);
            this.btnPicture.TabIndex = 0;
            this.btnPicture.Text = "&Picture";
            this.btnPicture.UseVisualStyleBackColor = true;
            this.btnPicture.Click += new System.EventHandler(this.btnPicture_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(146, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(151, 16);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Biking around Saint John";
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(357, 227);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(81, 34);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(247, 227);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(81, 34);
            this.btnHide.TabIndex = 2;
            this.btnHide.Text = "&Hide";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnData
            // 
            this.btnData.Location = new System.Drawing.Point(132, 227);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(81, 34);
            this.btnData.TabIndex = 1;
            this.btnData.Text = "&Data";
            this.btnData.UseVisualStyleBackColor = true;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // lblStory
            // 
            this.lblStory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStory.Location = new System.Drawing.Point(29, 31);
            this.lblStory.Name = "lblStory";
            this.lblStory.Size = new System.Drawing.Size(409, 184);
            this.lblStory.TabIndex = 1;
            this.lblStory.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(409, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(89, 53);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 22);
            this.txtNumber.TabIndex = 0;
            // 
            // txtMultiplier
            // 
            this.txtMultiplier.Location = new System.Drawing.Point(89, 106);
            this.txtMultiplier.Name = "txtMultiplier";
            this.txtMultiplier.Size = new System.Drawing.Size(100, 22);
            this.txtMultiplier.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnCalculate);
            this.groupBox1.Controls.Add(this.lblAnswer);
            this.groupBox1.Controls.Add(this.lblAns);
            this.groupBox1.Controls.Add(this.lblMultiplier);
            this.groupBox1.Controls.Add(this.lblNumber);
            this.groupBox1.Controls.Add(this.txtMultiplier);
            this.groupBox1.Controls.Add(this.txtNumber);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 294);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Multiplier";
            // 
            // btnReset
            // 
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Location = new System.Drawing.Point(109, 227);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(81, 34);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(21, 227);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(82, 34);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAnswer.Location = new System.Drawing.Point(89, 156);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(100, 25);
            this.lblAnswer.TabIndex = 5;
            // 
            // lblAns
            // 
            this.lblAns.AutoSize = true;
            this.lblAns.Location = new System.Drawing.Point(18, 165);
            this.lblAns.Name = "lblAns";
            this.lblAns.Size = new System.Drawing.Size(54, 16);
            this.lblAns.TabIndex = 4;
            this.lblAns.Text = "Answer:";
            // 
            // lblMultiplier
            // 
            this.lblMultiplier.AutoSize = true;
            this.lblMultiplier.Location = new System.Drawing.Point(18, 109);
            this.lblMultiplier.Name = "lblMultiplier";
            this.lblMultiplier.Size = new System.Drawing.Size(63, 16);
            this.lblMultiplier.TabIndex = 3;
            this.lblMultiplier.Text = "Multiplier:";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(18, 53);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(56, 16);
            this.lblNumber.TabIndex = 2;
            this.lblNumber.Text = "Number:";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnPicture;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(719, 331);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab2 by Daniel";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtMultiplier;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAns;
        private System.Windows.Forms.Label lblMultiplier;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button btnPicture;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.Label lblStory;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalculate;
    }
}

