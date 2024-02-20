namespace Home
{
    partial class Stafftype
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
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.buttonexit = new System.Windows.Forms.Button();
            this.buttonview = new System.Windows.Forms.Button();
            this.buttondelete = new System.Windows.Forms.Button();
            this.buttonedit = new System.Windows.Forms.Button();
            this.buttonadd = new System.Windows.Forms.Button();
            this.buttonfind = new System.Windows.Forms.Button();
            this.textsearch = new System.Windows.Forms.TextBox();
            this.textfee = new System.Windows.Forms.TextBox();
            this.textname = new System.Windows.Forms.TextBox();
            this.textid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrid
            // 
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Location = new System.Drawing.Point(-1, 264);
            this.datagrid.Name = "datagrid";
            this.datagrid.RowHeadersWidth = 51;
            this.datagrid.RowTemplate.Height = 24;
            this.datagrid.Size = new System.Drawing.Size(801, 187);
            this.datagrid.TabIndex = 47;
            // 
            // buttonexit
            // 
            this.buttonexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonexit.Location = new System.Drawing.Point(288, 191);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(95, 37);
            this.buttonexit.TabIndex = 46;
            this.buttonexit.Text = "EXIT";
            this.buttonexit.UseVisualStyleBackColor = true;
            this.buttonexit.Click += new System.EventHandler(this.buttonexit_Click);
            // 
            // buttonview
            // 
            this.buttonview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonview.Location = new System.Drawing.Point(50, 191);
            this.buttonview.Name = "buttonview";
            this.buttonview.Size = new System.Drawing.Size(118, 37);
            this.buttonview.TabIndex = 45;
            this.buttonview.Text = "VIEW ALL";
            this.buttonview.UseVisualStyleBackColor = true;
            this.buttonview.Click += new System.EventHandler(this.buttonview_Click);
            // 
            // buttondelete
            // 
            this.buttondelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondelete.Location = new System.Drawing.Point(276, 142);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(107, 34);
            this.buttondelete.TabIndex = 44;
            this.buttondelete.Text = "DELETE";
            this.buttondelete.UseVisualStyleBackColor = true;
            this.buttondelete.Click += new System.EventHandler(this.buttondelete_Click);
            // 
            // buttonedit
            // 
            this.buttonedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonedit.Location = new System.Drawing.Point(169, 142);
            this.buttonedit.Name = "buttonedit";
            this.buttonedit.Size = new System.Drawing.Size(75, 34);
            this.buttonedit.TabIndex = 43;
            this.buttonedit.Text = "EDIT";
            this.buttonedit.UseVisualStyleBackColor = true;
            this.buttonedit.Click += new System.EventHandler(this.buttonedit_Click);
            // 
            // buttonadd
            // 
            this.buttonadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonadd.Location = new System.Drawing.Point(50, 142);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(78, 34);
            this.buttonadd.TabIndex = 42;
            this.buttonadd.Text = "ADD";
            this.buttonadd.UseVisualStyleBackColor = true;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // buttonfind
            // 
            this.buttonfind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonfind.Location = new System.Drawing.Point(713, 55);
            this.buttonfind.Name = "buttonfind";
            this.buttonfind.Size = new System.Drawing.Size(75, 30);
            this.buttonfind.TabIndex = 41;
            this.buttonfind.Text = "FIND";
            this.buttonfind.UseVisualStyleBackColor = true;
            this.buttonfind.Click += new System.EventHandler(this.buttonfind_Click);
            // 
            // textsearch
            // 
            this.textsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textsearch.Location = new System.Drawing.Point(459, 55);
            this.textsearch.Name = "textsearch";
            this.textsearch.Size = new System.Drawing.Size(234, 30);
            this.textsearch.TabIndex = 40;
            // 
            // textfee
            // 
            this.textfee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textfee.Location = new System.Drawing.Point(183, 89);
            this.textfee.Name = "textfee";
            this.textfee.Size = new System.Drawing.Size(248, 30);
            this.textfee.TabIndex = 38;
            // 
            // textname
            // 
            this.textname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textname.Location = new System.Drawing.Point(183, 53);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(248, 30);
            this.textname.TabIndex = 37;
            // 
            // textid
            // 
            this.textid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textid.Location = new System.Drawing.Point(183, 17);
            this.textid.Name = "textid";
            this.textid.Size = new System.Drawing.Size(248, 30);
            this.textid.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 34;
            this.label3.Text = "Fee per day";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 33;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "StafftypeID";
            // 
            // buttonback
            // 
            this.buttonback.Location = new System.Drawing.Point(682, 191);
            this.buttonback.Name = "buttonback";
            this.buttonback.Size = new System.Drawing.Size(97, 48);
            this.buttonback.TabIndex = 48;
            this.buttonback.Text = "BACK TO HOME";
            this.buttonback.UseVisualStyleBackColor = true;
            this.buttonback.Click += new System.EventHandler(this.buttonback_Click);
            // 
            // Stafftype
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
            this.Controls.Add(this.textfee);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.textid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Stafftype";
            this.Text = "Stafftype";
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.Button buttonexit;
        private System.Windows.Forms.Button buttonview;
        private System.Windows.Forms.Button buttondelete;
        private System.Windows.Forms.Button buttonedit;
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.Button buttonfind;
        private System.Windows.Forms.TextBox textsearch;
        private System.Windows.Forms.TextBox textfee;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.TextBox textid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonback;
    }
}