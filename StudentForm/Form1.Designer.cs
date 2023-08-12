namespace StudentForm
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
            this.NAME = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.moviecheckBox = new System.Windows.Forms.CheckBox();
            this.footballcheckBox = new System.Windows.Forms.CheckBox();
            this.swimmingcheckBox = new System.Windows.Forms.CheckBox();
            this.musiccheckBox = new System.Windows.Forms.CheckBox();
            this.Addbtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.phonBox = new System.Windows.Forms.TextBox();
            this.zipBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.editbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // NAME
            // 
            this.NAME.AccessibleName = "Name";
            this.NAME.AutoSize = true;
            this.NAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NAME.Location = new System.Drawing.Point(83, 100);
            this.NAME.Name = "NAME";
            this.NAME.Size = new System.Drawing.Size(63, 20);
            this.NAME.TabIndex = 0;
            this.NAME.Text = "NAME*";
            this.NAME.Click += new System.EventHandler(this.NAME_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "EMAIL*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "PHONE*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "ZIP CODE*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(83, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "HOBBIES*";
            // 
            // moviecheckBox
            // 
            this.moviecheckBox.AutoSize = true;
            this.moviecheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moviecheckBox.Location = new System.Drawing.Point(86, 305);
            this.moviecheckBox.Name = "moviecheckBox";
            this.moviecheckBox.Size = new System.Drawing.Size(75, 24);
            this.moviecheckBox.TabIndex = 5;
            this.moviecheckBox.Text = "Movie";
            this.moviecheckBox.UseVisualStyleBackColor = true;
            this.moviecheckBox.CheckedChanged += new System.EventHandler(this.moviecheckBox_CheckedChanged);
            // 
            // footballcheckBox
            // 
            this.footballcheckBox.AutoSize = true;
            this.footballcheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.footballcheckBox.Location = new System.Drawing.Point(86, 331);
            this.footballcheckBox.Name = "footballcheckBox";
            this.footballcheckBox.Size = new System.Drawing.Size(90, 24);
            this.footballcheckBox.TabIndex = 6;
            this.footballcheckBox.Text = "Football";
            this.footballcheckBox.UseVisualStyleBackColor = true;
            this.footballcheckBox.CheckedChanged += new System.EventHandler(this.footballcheckBox_CheckedChanged);
            // 
            // swimmingcheckBox
            // 
            this.swimmingcheckBox.AutoSize = true;
            this.swimmingcheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swimmingcheckBox.Location = new System.Drawing.Point(86, 357);
            this.swimmingcheckBox.Name = "swimmingcheckBox";
            this.swimmingcheckBox.Size = new System.Drawing.Size(108, 24);
            this.swimmingcheckBox.TabIndex = 7;
            this.swimmingcheckBox.Text = "Swimming";
            this.swimmingcheckBox.UseVisualStyleBackColor = true;
            this.swimmingcheckBox.CheckedChanged += new System.EventHandler(this.swimmingcheckBox_CheckedChanged);
            // 
            // musiccheckBox
            // 
            this.musiccheckBox.AutoSize = true;
            this.musiccheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musiccheckBox.Location = new System.Drawing.Point(86, 383);
            this.musiccheckBox.Name = "musiccheckBox";
            this.musiccheckBox.Size = new System.Drawing.Size(76, 24);
            this.musiccheckBox.TabIndex = 8;
            this.musiccheckBox.Text = "Music";
            this.musiccheckBox.UseVisualStyleBackColor = true;
            this.musiccheckBox.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // Addbtn
            // 
            this.Addbtn.BackColor = System.Drawing.Color.Chartreuse;
            this.Addbtn.Location = new System.Drawing.Point(86, 430);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(157, 46);
            this.Addbtn.TabIndex = 9;
            this.Addbtn.Text = "Add";
            this.Addbtn.UseVisualStyleBackColor = false;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.BackColor = System.Drawing.Color.Chocolate;
            this.Deletebtn.Location = new System.Drawing.Point(279, 430);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(150, 46);
            this.Deletebtn.TabIndex = 10;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = false;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(86, 492);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(879, 179);
            this.dataGrid.TabIndex = 11;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(177, 97);
            this.nameBox.Multiline = true;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(233, 37);
            this.nameBox.TabIndex = 12;
            this.nameBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(177, 140);
            this.emailBox.Multiline = true;
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(233, 37);
            this.emailBox.TabIndex = 13;
            // 
            // phonBox
            // 
            this.phonBox.Location = new System.Drawing.Point(177, 183);
            this.phonBox.Multiline = true;
            this.phonBox.Name = "phonBox";
            this.phonBox.Size = new System.Drawing.Size(233, 35);
            this.phonBox.TabIndex = 14;
            this.phonBox.TextChanged += new System.EventHandler(this.phonBox_TextChanged);
            // 
            // zipBox
            // 
            this.zipBox.Location = new System.Drawing.Point(177, 224);
            this.zipBox.Multiline = true;
            this.zipBox.Name = "zipBox";
            this.zipBox.Size = new System.Drawing.Size(233, 36);
            this.zipBox.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AccessibleName = "Name";
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(316, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(374, 36);
            this.label6.TabIndex = 17;
            this.label6.Text = "Student Information Form";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // editbtn
            // 
            this.editbtn.Location = new System.Drawing.Point(462, 430);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(139, 46);
            this.editbtn.TabIndex = 18;
            this.editbtn.Text = "Edit";
            this.editbtn.UseVisualStyleBackColor = true;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1058, 683);
            this.Controls.Add(this.editbtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.zipBox);
            this.Controls.Add(this.phonBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.musiccheckBox);
            this.Controls.Add(this.swimmingcheckBox);
            this.Controls.Add(this.footballcheckBox);
            this.Controls.Add(this.moviecheckBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NAME);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NAME;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox moviecheckBox;
        private System.Windows.Forms.CheckBox footballcheckBox;
        private System.Windows.Forms.CheckBox swimmingcheckBox;
        private System.Windows.Forms.CheckBox musiccheckBox;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox phonBox;
        private System.Windows.Forms.TextBox zipBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button editbtn;
    }
}

