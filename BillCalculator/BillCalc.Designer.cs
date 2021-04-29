
namespace BillCalculator
{
    partial class BillCalc
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillCalc));
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtKWH = new System.Windows.Forms.TextBox();
            this.listCust = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFname = new System.Windows.Forms.Label();
            this.lblLname = new System.Windows.Forms.Label();
            this.lblKWH = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblAvgBill = new System.Windows.Forms.Label();
            this.lblTotalKWH = new System.Windows.Forms.Label();
            this.lblAvgTitle = new System.Windows.Forms.Label();
            this.lblAvg = new System.Windows.Forms.Label();
            this.lblTotalCust = new System.Windows.Forms.Label();
            this.lblTotalCusts = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFname
            // 
            this.txtFname.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFname.Location = new System.Drawing.Point(274, 515);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(210, 23);
            this.txtFname.TabIndex = 0;
            this.txtFname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFname_KeyPress);
            // 
            // txtLname
            // 
            this.txtLname.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLname.Location = new System.Drawing.Point(274, 569);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(210, 23);
            this.txtLname.TabIndex = 1;
            this.txtLname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLname_KeyPress);
            // 
            // txtKWH
            // 
            this.txtKWH.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtKWH.Location = new System.Drawing.Point(274, 621);
            this.txtKWH.Name = "txtKWH";
            this.txtKWH.Size = new System.Drawing.Size(210, 23);
            this.txtKWH.TabIndex = 2;
            this.txtKWH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKWH_KeyPress);
            // 
            // listCust
            // 
            this.listCust.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listCust.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listCust.FormattingEnabled = true;
            this.listCust.ItemHeight = 18;
            this.listCust.Location = new System.Drawing.Point(593, 494);
            this.listCust.Name = "listCust";
            this.listCust.Size = new System.Drawing.Size(485, 236);
            this.listCust.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(497, 458);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customers";
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.BackColor = System.Drawing.Color.LightGray;
            this.lblFname.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFname.Location = new System.Drawing.Point(102, 515);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(121, 23);
            this.lblFname.TabIndex = 3;
            this.lblFname.Text = "First Name:";
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.BackColor = System.Drawing.Color.LightGray;
            this.lblLname.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLname.Location = new System.Drawing.Point(105, 569);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(118, 23);
            this.lblLname.TabIndex = 4;
            this.lblLname.Text = "Last Name:";
            // 
            // lblKWH
            // 
            this.lblKWH.AutoSize = true;
            this.lblKWH.BackColor = System.Drawing.Color.LightGray;
            this.lblKWH.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKWH.Location = new System.Drawing.Point(110, 621);
            this.lblKWH.Name = "lblKWH";
            this.lblKWH.Size = new System.Drawing.Size(113, 23);
            this.lblKWH.TabIndex = 5;
            this.lblKWH.Text = "kWh Used:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DimGray;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(335, 678);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(138, 38);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "&Add Customer";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DimGray;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(120, 678);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(138, 38);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblAvgBill
            // 
            this.lblAvgBill.AutoSize = true;
            this.lblAvgBill.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAvgBill.ForeColor = System.Drawing.Color.White;
            this.lblAvgBill.Location = new System.Drawing.Point(629, 802);
            this.lblAvgBill.Name = "lblAvgBill";
            this.lblAvgBill.Size = new System.Drawing.Size(25, 25);
            this.lblAvgBill.TabIndex = 6;
            this.lblAvgBill.Text = "0";
            // 
            // lblTotalKWH
            // 
            this.lblTotalKWH.AutoSize = true;
            this.lblTotalKWH.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalKWH.ForeColor = System.Drawing.Color.White;
            this.lblTotalKWH.Location = new System.Drawing.Point(629, 763);
            this.lblTotalKWH.Name = "lblTotalKWH";
            this.lblTotalKWH.Size = new System.Drawing.Size(25, 25);
            this.lblTotalKWH.TabIndex = 7;
            this.lblTotalKWH.Text = "0";
            // 
            // lblAvgTitle
            // 
            this.lblAvgTitle.AutoSize = true;
            this.lblAvgTitle.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAvgTitle.ForeColor = System.Drawing.Color.White;
            this.lblAvgTitle.Location = new System.Drawing.Point(335, 763);
            this.lblAvgTitle.Name = "lblAvgTitle";
            this.lblAvgTitle.Size = new System.Drawing.Size(191, 25);
            this.lblAvgTitle.TabIndex = 8;
            this.lblAvgTitle.Text = "Total KWH Used:";
            // 
            // lblAvg
            // 
            this.lblAvg.AutoSize = true;
            this.lblAvg.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAvg.ForeColor = System.Drawing.Color.White;
            this.lblAvg.Location = new System.Drawing.Point(276, 802);
            this.lblAvg.Name = "lblAvg";
            this.lblAvg.Size = new System.Drawing.Size(250, 25);
            this.lblAvg.TabIndex = 9;
            this.lblAvg.Text = "Average Customer Bill:";
            // 
            // lblTotalCust
            // 
            this.lblTotalCust.AutoSize = true;
            this.lblTotalCust.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalCust.ForeColor = System.Drawing.Color.White;
            this.lblTotalCust.Location = new System.Drawing.Point(334, 840);
            this.lblTotalCust.Name = "lblTotalCust";
            this.lblTotalCust.Size = new System.Drawing.Size(192, 25);
            this.lblTotalCust.TabIndex = 10;
            this.lblTotalCust.Text = "Total Customers:";
            // 
            // lblTotalCusts
            // 
            this.lblTotalCusts.AutoSize = true;
            this.lblTotalCusts.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalCusts.ForeColor = System.Drawing.Color.White;
            this.lblTotalCusts.Location = new System.Drawing.Point(629, 840);
            this.lblTotalCusts.Name = "lblTotalCusts";
            this.lblTotalCusts.Size = new System.Drawing.Size(25, 25);
            this.lblTotalCusts.TabIndex = 11;
            this.lblTotalCusts.Text = "0";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightGray;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(940, 827);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(138, 38);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // logoBox
            // 
            this.logoBox.Image = ((System.Drawing.Image)(resources.GetObject("logoBox.Image")));
            this.logoBox.Location = new System.Drawing.Point(120, 11);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(893, 477);
            this.logoBox.TabIndex = 13;
            this.logoBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(58, 494);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(485, 238);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // BillCalc
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(1136, 916);
            this.Controls.Add(this.lblFname);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.logoBox);
            this.Controls.Add(this.txtKWH);
            this.Controls.Add(this.lblTotalCusts);
            this.Controls.Add(this.lblLname);
            this.Controls.Add(this.lblTotalCust);
            this.Controls.Add(this.lblKWH);
            this.Controls.Add(this.lblAvg);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblAvgTitle);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblTotalKWH);
            this.Controls.Add(this.lblAvgBill);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listCust);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BillCalc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill Calculator";
            this.Load += new System.EventHandler(this.BillCalc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtKWH;
        private System.Windows.Forms.ListBox listCust;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.Label lblKWH;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblAvgBill;
        private System.Windows.Forms.Label lblTotalKWH;
        private System.Windows.Forms.Label lblAvgTitle;
        private System.Windows.Forms.Label lblAvg;
        private System.Windows.Forms.Label lblTotalCust;
        private System.Windows.Forms.Label lblTotalCusts;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

