namespace ContractingDesktop
{
    partial class AddContract
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
            this.FirstText = new System.Windows.Forms.TextBox();
            this.CityText = new System.Windows.Forms.TextBox();
            this.LastText = new System.Windows.Forms.TextBox();
            this.ZipText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddressText = new System.Windows.Forms.TextBox();
            this.CorpNameText = new System.Windows.Forms.TextBox();
            this.EmailText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FirstText
            // 
            this.FirstText.BackColor = System.Drawing.Color.AliceBlue;
            this.FirstText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstText.Location = new System.Drawing.Point(95, 31);
            this.FirstText.Margin = new System.Windows.Forms.Padding(2);
            this.FirstText.Name = "FirstText";
            this.FirstText.Size = new System.Drawing.Size(527, 26);
            this.FirstText.TabIndex = 0;
            // 
            // CityText
            // 
            this.CityText.BackColor = System.Drawing.Color.AliceBlue;
            this.CityText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityText.Location = new System.Drawing.Point(95, 111);
            this.CityText.Margin = new System.Windows.Forms.Padding(2);
            this.CityText.Name = "CityText";
            this.CityText.Size = new System.Drawing.Size(527, 26);
            this.CityText.TabIndex = 1;
            this.CityText.TextChanged += new System.EventHandler(this.EmailText_TextChanged);
            // 
            // LastText
            // 
            this.LastText.BackColor = System.Drawing.Color.AliceBlue;
            this.LastText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastText.Location = new System.Drawing.Point(95, 71);
            this.LastText.Margin = new System.Windows.Forms.Padding(2);
            this.LastText.Name = "LastText";
            this.LastText.Size = new System.Drawing.Size(527, 26);
            this.LastText.TabIndex = 2;
            // 
            // ZipText
            // 
            this.ZipText.BackColor = System.Drawing.Color.AliceBlue;
            this.ZipText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZipText.Location = new System.Drawing.Point(95, 153);
            this.ZipText.Margin = new System.Windows.Forms.Padding(2);
            this.ZipText.Name = "ZipText";
            this.ZipText.Size = new System.Drawing.Size(527, 26);
            this.ZipText.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "City";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.Location = new System.Drawing.Point(527, 475);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add Person";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.EmailText);
            this.groupBox1.Controls.Add(this.CorpNameText);
            this.groupBox1.Controls.Add(this.AddressText);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.FirstText);
            this.groupBox1.Controls.Add(this.ZipText);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.LastText);
            this.groupBox1.Controls.Add(this.CityText);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(627, 510);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // AddressText
            // 
            this.AddressText.BackColor = System.Drawing.Color.AliceBlue;
            this.AddressText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressText.Location = new System.Drawing.Point(95, 193);
            this.AddressText.Margin = new System.Windows.Forms.Padding(2);
            this.AddressText.Name = "AddressText";
            this.AddressText.Size = new System.Drawing.Size(527, 26);
            this.AddressText.TabIndex = 9;
            // 
            // CorpNameText
            // 
            this.CorpNameText.BackColor = System.Drawing.Color.AliceBlue;
            this.CorpNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorpNameText.Location = new System.Drawing.Point(95, 232);
            this.CorpNameText.Margin = new System.Windows.Forms.Padding(2);
            this.CorpNameText.Name = "CorpNameText";
            this.CorpNameText.Size = new System.Drawing.Size(527, 26);
            this.CorpNameText.TabIndex = 10;
            // 
            // EmailText
            // 
            this.EmailText.BackColor = System.Drawing.Color.AliceBlue;
            this.EmailText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailText.Location = new System.Drawing.Point(95, 274);
            this.EmailText.Margin = new System.Windows.Forms.Padding(2);
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(527, 26);
            this.EmailText.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 232);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Company";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 193);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 153);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "ZIP ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 274);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Email";
            // 
            // AddContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(651, 534);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddContract";
            this.Text = "AddContract";
            this.Load += new System.EventHandler(this.AddContract_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox FirstText;
        private System.Windows.Forms.TextBox CityText;
        private System.Windows.Forms.TextBox LastText;
        private System.Windows.Forms.TextBox ZipText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EmailText;
        private System.Windows.Forms.TextBox CorpNameText;
        private System.Windows.Forms.TextBox AddressText;
    }
}