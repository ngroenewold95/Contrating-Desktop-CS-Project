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
            this.newContract = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.reminders = new System.Windows.Forms.Label();
            this.monthly = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(988, 502);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // newContract
            // 
            this.newContract.BackColor = System.Drawing.Color.AliceBlue;
            this.newContract.Location = new System.Drawing.Point(859, 80);
            this.newContract.Name = "newContract";
            this.newContract.Size = new System.Drawing.Size(140, 38);
            this.newContract.TabIndex = 1;
            this.newContract.Text = "Add New Contract";
            this.newContract.UseVisualStyleBackColor = false;
            this.newContract.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.AliceBlue;
            this.searchButton.Location = new System.Drawing.Point(713, 80);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(140, 38);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.monthly);
            this.flowLayoutPanel1.Controls.Add(this.listView2);
            this.flowLayoutPanel1.Controls.Add(this.reminders);
            this.flowLayoutPanel1.Controls.Add(this.listView1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1017, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(218, 614);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(3, 338);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(215, 283);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(3, 39);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(215, 277);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // reminders
            // 
            this.reminders.AutoSize = true;
            this.reminders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reminders.Location = new System.Drawing.Point(3, 319);
            this.reminders.Name = "reminders";
            this.reminders.Size = new System.Drawing.Size(68, 16);
            this.reminders.TabIndex = 2;
            this.reminders.Text = "Renewals";
            // 
            // monthly
            // 
            this.monthly.AutoSize = true;
            this.monthly.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthly.Location = new System.Drawing.Point(3, 20);
            this.monthly.Name = "monthly";
            this.monthly.Size = new System.Drawing.Size(95, 16);
            this.monthly.TabIndex = 4;
            this.monthly.Text = "Monthly Forms";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Reminders               ";
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1247, 638);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.newContract);
            this.Controls.Add(this.groupBox1);
            this.Name = "Splash";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button newContract;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Label reminders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label monthly;
    }
}