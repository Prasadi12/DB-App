namespace Home
{
    partial class Production
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textid = new System.Windows.Forms.TextBox();
            this.textclientid = new System.Windows.Forms.TextBox();
            this.textproductiontype = new System.Windows.Forms.TextBox();
            this.textday = new System.Windows.Forms.TextBox();
            this.textsearch = new System.Windows.Forms.TextBox();
            this.buttonfind = new System.Windows.Forms.Button();
            this.buttonadd = new System.Windows.Forms.Button();
            this.buttonedit = new System.Windows.Forms.Button();
            this.buttondelete = new System.Windows.Forms.Button();
            this.buttonview = new System.Windows.Forms.Button();
            this.buttonexit = new System.Windows.Forms.Button();
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.buttonback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ProductionID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "ClientID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "ProductionType";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "No of days";
            // 
            // textid
            // 
            this.textid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textid.Location = new System.Drawing.Point(181, 12);
            this.textid.Name = "textid";
            this.textid.Size = new System.Drawing.Size(248, 30);
            this.textid.TabIndex = 4;
            // 
            // textclientid
            // 
            this.textclientid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textclientid.Location = new System.Drawing.Point(181, 48);
            this.textclientid.Name = "textclientid";
            this.textclientid.Size = new System.Drawing.Size(248, 30);
            this.textclientid.TabIndex = 5;
            // 
            // textproductiontype
            // 
            this.textproductiontype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textproductiontype.Location = new System.Drawing.Point(181, 84);
            this.textproductiontype.Name = "textproductiontype";
            this.textproductiontype.Size = new System.Drawing.Size(248, 30);
            this.textproductiontype.TabIndex = 6;
            // 
            // textday
            // 
            this.textday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textday.Location = new System.Drawing.Point(181, 126);
            this.textday.Name = "textday";
            this.textday.Size = new System.Drawing.Size(248, 30);
            this.textday.TabIndex = 7;
            // 
            // textsearch
            // 
            this.textsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textsearch.Location = new System.Drawing.Point(473, 13);
            this.textsearch.Name = "textsearch";
            this.textsearch.Size = new System.Drawing.Size(234, 30);
            this.textsearch.TabIndex = 8;
            // 
            // buttonfind
            // 
            this.buttonfind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonfind.Location = new System.Drawing.Point(713, 12);
            this.buttonfind.Name = "buttonfind";
            this.buttonfind.Size = new System.Drawing.Size(75, 30);
            this.buttonfind.TabIndex = 9;
            this.buttonfind.Text = "FIND";
            this.buttonfind.UseVisualStyleBackColor = true;
            this.buttonfind.Click += new System.EventHandler(this.buttonfind_Click);
            // 
            // buttonadd
            // 
            this.buttonadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonadd.Location = new System.Drawing.Point(34, 162);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(78, 34);
            this.buttonadd.TabIndex = 10;
            this.buttonadd.Text = "ADD";
            this.buttonadd.UseVisualStyleBackColor = true;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // buttonedit
            // 
            this.buttonedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonedit.Location = new System.Drawing.Point(153, 162);
            this.buttonedit.Name = "buttonedit";
            this.buttonedit.Size = new System.Drawing.Size(75, 34);
            this.buttonedit.TabIndex = 11;
            this.buttonedit.Text = "EDIT";
            this.buttonedit.UseVisualStyleBackColor = true;
            this.buttonedit.Click += new System.EventHandler(this.buttonedit_Click);
            // 
            // buttondelete
            // 
            this.buttondelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondelete.Location = new System.Drawing.Point(260, 162);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(107, 34);
            this.buttondelete.TabIndex = 12;
            this.buttondelete.Text = "DELETE";
            this.buttondelete.UseVisualStyleBackColor = true;
            this.buttondelete.Click += new System.EventHandler(this.buttondelete_Click);
            // 
            // buttonview
            // 
            this.buttonview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonview.Location = new System.Drawing.Point(34, 211);
            this.buttonview.Name = "buttonview";
            this.buttonview.Size = new System.Drawing.Size(118, 37);
            this.buttonview.TabIndex = 13;
            this.buttonview.Text = "VIEW ALL";
            this.buttonview.UseVisualStyleBackColor = true;
            this.buttonview.Click += new System.EventHandler(this.buttonview_Click);
            // 
            // buttonexit
            // 
            this.buttonexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonexit.Location = new System.Drawing.Point(272, 211);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(95, 37);
            this.buttonexit.TabIndex = 14;
            this.buttonexit.Text = "EXIT";
            this.buttonexit.UseVisualStyleBackColor = true;
            this.buttonexit.Click += new System.EventHandler(this.buttonexit_Click);
            // 
            // datagrid
            // 
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Location = new System.Drawing.Point(-1, 270);
            this.datagrid.Name = "datagrid";
            this.datagrid.RowHeadersWidth = 51;
            this.datagrid.RowTemplate.Height = 24;
            this.datagrid.Size = new System.Drawing.Size(799, 176);
            this.datagrid.TabIndex = 15;
            // 
            // buttonback
            // 
            this.buttonback.Location = new System.Drawing.Point(687, 206);
            this.buttonback.Name = "buttonback";
            this.buttonback.Size = new System.Drawing.Size(101, 52);
            this.buttonback.TabIndex = 16;
            this.buttonback.Text = "BACK TO HOME";
            this.buttonback.UseVisualStyleBackColor = true;
            this.buttonback.Click += new System.EventHandler(this.buttonback_Click);
            // 
            // Production
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonback);
            this.Controls.Add(this.datagrid);
            this.Controls.Add(this.buttonexit);
            this.Controls.Add(this.buttonview);
            this.Controls.Add(this.buttondelete);
            this.Controls.Add(this.buttonedit);
            this.Controls.Add(this.buttonadd);
            this.Controls.Add(this.buttonfind);
            this.Controls.Add(this.textsearch);
            this.Controls.Add(this.textday);
            this.Controls.Add(this.textproductiontype);
            this.Controls.Add(this.textclientid);
            this.Controls.Add(this.textid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Production";
            this.Text = "Production";
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textid;
        private System.Windows.Forms.TextBox textclientid;
        private System.Windows.Forms.TextBox textproductiontype;
        private System.Windows.Forms.TextBox textday;
        private System.Windows.Forms.TextBox textsearch;
        private System.Windows.Forms.Button buttonfind;
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.Button buttonedit;
        private System.Windows.Forms.Button buttondelete;
        private System.Windows.Forms.Button buttonview;
        private System.Windows.Forms.Button buttonexit;
        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.Button buttonback;
    }
}