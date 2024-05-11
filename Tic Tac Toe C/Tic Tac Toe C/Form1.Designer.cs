namespace WindowsFormsApplication1
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
            this.lblturn = new System.Windows.Forms.Label();
            this.btnnew = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.oplayer = new System.Windows.Forms.RadioButton();
            this.xplayer = new System.Windows.Forms.RadioButton();
            this.picbox = new System.Windows.Forms.PictureBox();
            this.sq9 = new System.Windows.Forms.Label();
            this.sq8 = new System.Windows.Forms.Label();
            this.sq6 = new System.Windows.Forms.Label();
            this.sq5 = new System.Windows.Forms.Label();
            this.sq4 = new System.Windows.Forms.Label();
            this.sq3 = new System.Windows.Forms.Label();
            this.sq2 = new System.Windows.Forms.Label();
            this.sq7 = new System.Windows.Forms.Label();
            this.sq1 = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblturn
            // 
            this.lblturn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblturn.Location = new System.Drawing.Point(19, 207);
            this.lblturn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblturn.Name = "lblturn";
            this.lblturn.Size = new System.Drawing.Size(159, 29);
            this.lblturn.TabIndex = 30;
            this.lblturn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(221, 201);
            this.btnnew.Margin = new System.Windows.Forms.Padding(4);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(175, 33);
            this.btnnew.TabIndex = 29;
            this.btnnew.Text = "New Game";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.oplayer);
            this.GroupBox1.Controls.Add(this.xplayer);
            this.GroupBox1.Location = new System.Drawing.Point(220, 26);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Size = new System.Drawing.Size(181, 105);
            this.GroupBox1.TabIndex = 28;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Who First?";
            this.GroupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // oplayer
            // 
            this.oplayer.AutoSize = true;
            this.oplayer.Location = new System.Drawing.Point(32, 63);
            this.oplayer.Margin = new System.Windows.Forms.Padding(4);
            this.oplayer.Name = "oplayer";
            this.oplayer.Size = new System.Drawing.Size(90, 21);
            this.oplayer.TabIndex = 16;
            this.oplayer.Text = "Player O";
            this.oplayer.UseVisualStyleBackColor = true;
            // 
            // xplayer
            // 
            this.xplayer.AutoSize = true;
            this.xplayer.Checked = true;
            this.xplayer.Location = new System.Drawing.Point(32, 31);
            this.xplayer.Margin = new System.Windows.Forms.Padding(4);
            this.xplayer.Name = "xplayer";
            this.xplayer.Size = new System.Drawing.Size(90, 21);
            this.xplayer.TabIndex = 16;
            this.xplayer.TabStop = true;
            this.xplayer.Text = "Player X";
            this.xplayer.UseVisualStyleBackColor = true;
            // 
            // picbox
            // 
            this.picbox.Image = ((System.Drawing.Image)(resources.GetObject("picbox.Image")));
            this.picbox.Location = new System.Drawing.Point(19, 24);
            this.picbox.Margin = new System.Windows.Forms.Padding(4);
            this.picbox.Name = "picbox";
            this.picbox.Size = new System.Drawing.Size(159, 168);
            this.picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox.TabIndex = 27;
            this.picbox.TabStop = false;
            // 
            // sq9
            // 
            this.sq9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sq9.Enabled = false;
            this.sq9.Font = new System.Drawing.Font("Tahoma", 15F);
            this.sq9.Location = new System.Drawing.Point(129, 141);
            this.sq9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sq9.Name = "sq9";
            this.sq9.Size = new System.Drawing.Size(43, 42);
            this.sq9.TabIndex = 39;
            this.sq9.Text = "X";
            this.sq9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sq8
            // 
            this.sq8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sq8.Enabled = false;
            this.sq8.Font = new System.Drawing.Font("Tahoma", 15F);
            this.sq8.Location = new System.Drawing.Point(77, 141);
            this.sq8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sq8.Name = "sq8";
            this.sq8.Size = new System.Drawing.Size(43, 42);
            this.sq8.TabIndex = 38;
            this.sq8.Text = "X";
            this.sq8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sq6
            // 
            this.sq6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sq6.Enabled = false;
            this.sq6.Font = new System.Drawing.Font("Tahoma", 15F);
            this.sq6.Location = new System.Drawing.Point(129, 89);
            this.sq6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sq6.Name = "sq6";
            this.sq6.Size = new System.Drawing.Size(43, 42);
            this.sq6.TabIndex = 36;
            this.sq6.Text = "X";
            this.sq6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sq5
            // 
            this.sq5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sq5.Enabled = false;
            this.sq5.Font = new System.Drawing.Font("Tahoma", 15F);
            this.sq5.Location = new System.Drawing.Point(76, 89);
            this.sq5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sq5.Name = "sq5";
            this.sq5.Size = new System.Drawing.Size(43, 42);
            this.sq5.TabIndex = 35;
            this.sq5.Text = "X";
            this.sq5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sq4
            // 
            this.sq4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sq4.Enabled = false;
            this.sq4.Font = new System.Drawing.Font("Tahoma", 15F);
            this.sq4.Location = new System.Drawing.Point(23, 89);
            this.sq4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sq4.Name = "sq4";
            this.sq4.Size = new System.Drawing.Size(43, 42);
            this.sq4.TabIndex = 34;
            this.sq4.Text = "X";
            this.sq4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sq3
            // 
            this.sq3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sq3.Enabled = false;
            this.sq3.Font = new System.Drawing.Font("Tahoma", 15F);
            this.sq3.Location = new System.Drawing.Point(129, 37);
            this.sq3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sq3.Name = "sq3";
            this.sq3.Size = new System.Drawing.Size(43, 42);
            this.sq3.TabIndex = 33;
            this.sq3.Text = "X";
            this.sq3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sq2
            // 
            this.sq2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sq2.Enabled = false;
            this.sq2.Font = new System.Drawing.Font("Tahoma", 15F);
            this.sq2.Location = new System.Drawing.Point(76, 37);
            this.sq2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sq2.Name = "sq2";
            this.sq2.Size = new System.Drawing.Size(43, 42);
            this.sq2.TabIndex = 32;
            this.sq2.Text = "X";
            this.sq2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sq7
            // 
            this.sq7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sq7.Enabled = false;
            this.sq7.Font = new System.Drawing.Font("Tahoma", 15F);
            this.sq7.Location = new System.Drawing.Point(23, 141);
            this.sq7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sq7.Name = "sq7";
            this.sq7.Size = new System.Drawing.Size(43, 42);
            this.sq7.TabIndex = 37;
            this.sq7.Text = "X";
            this.sq7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sq1
            // 
            this.sq1.BackColor = System.Drawing.Color.Transparent;
            this.sq1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sq1.Enabled = false;
            this.sq1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.sq1.Location = new System.Drawing.Point(23, 37);
            this.sq1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sq1.Name = "sq1";
            this.sq1.Size = new System.Drawing.Size(43, 42);
            this.sq1.TabIndex = 31;
            this.sq1.Text = "X";
            this.sq1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(412, 250);
            this.Controls.Add(this.sq9);
            this.Controls.Add(this.sq8);
            this.Controls.Add(this.sq6);
            this.Controls.Add(this.sq5);
            this.Controls.Add(this.sq4);
            this.Controls.Add(this.sq3);
            this.Controls.Add(this.sq2);
            this.Controls.Add(this.sq7);
            this.Controls.Add(this.sq1);
            this.Controls.Add(this.lblturn);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.picbox);
            this.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XO Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label lblturn;
        internal System.Windows.Forms.Button btnnew;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.RadioButton oplayer;
        internal System.Windows.Forms.RadioButton xplayer;
        internal System.Windows.Forms.PictureBox picbox;
        internal System.Windows.Forms.Label sq9;
        internal System.Windows.Forms.Label sq8;
        internal System.Windows.Forms.Label sq6;
        internal System.Windows.Forms.Label sq5;
        internal System.Windows.Forms.Label sq4;
        internal System.Windows.Forms.Label sq3;
        internal System.Windows.Forms.Label sq2;
        internal System.Windows.Forms.Label sq7;
        internal System.Windows.Forms.Label sq1;
    }
}

