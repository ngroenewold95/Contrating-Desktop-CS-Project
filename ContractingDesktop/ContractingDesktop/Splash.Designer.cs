namespace ContractingDesktop
{
    partial class Splash
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contractList = new System.Windows.Forms.ListView();
            this.newContract = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.statusBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.statusBox);
            this.groupBox1.Controls.Add(this.contractList);
            this.groupBox1.Location = new System.Drawing.Point(201, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1034, 507);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // contractList
            // 
            this.contractList.Location = new System.Drawing.Point(0, 0);
            this.contractList.Name = "contractList";
            this.contractList.Size = new System.Drawing.Size(1034, 465);
            this.contractList.TabIndex = 0;
            this.contractList.UseCompatibleStateImageBehavior = false;
            this.contractList.SelectedIndexChanged += new System.EventHandler(this.contractList_SelectedIndexChanged);
            // 
            // newContract
            // 
            this.newContract.Location = new System.Drawing.Point(1095, 73);
            this.newContract.Name = "newContract";
            this.newContract.Size = new System.Drawing.Size(140, 38);
            this.newContract.TabIndex = 1;
            this.newContract.Text = "Add New Contract";
            this.newContract.UseVisualStyleBackColor = true;
            this.newContract.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(201, 80);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(338, 31);
            this.searchBox.TabIndex = 2;
            this.searchBox.Text = "Search";
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(173, 507);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(8, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(165, 498);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // statusBox
            // 
            this.statusBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBox.Location = new System.Drawing.Point(0, 460);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(1034, 38);
            this.statusBox.TabIndex = 1;
            this.statusBox.Text = "";
            this.statusBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 638);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.newContract);
            this.Controls.Add(this.groupBox1);
            this.Name = "Splash";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button newContract;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.ListView contractList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RichTextBox statusBox;
    }
}