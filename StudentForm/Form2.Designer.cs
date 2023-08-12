namespace StudentForm
{
    partial class Form2
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
            this.zipBox1 = new System.Windows.Forms.TextBox();
            this.phonBox1 = new System.Windows.Forms.TextBox();
            this.emailBox1 = new System.Windows.Forms.TextBox();
            this.nameBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NAME = new System.Windows.Forms.Label();
            this.updatebtn = new System.Windows.Forms.Button();
            this.hobbiesBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // zipBox1
            // 
            this.zipBox1.Location = new System.Drawing.Point(358, 213);
            this.zipBox1.Multiline = true;
            this.zipBox1.Name = "zipBox1";
            this.zipBox1.Size = new System.Drawing.Size(233, 36);
            this.zipBox1.TabIndex = 28;
            // 
            // phonBox1
            // 
            this.phonBox1.Location = new System.Drawing.Point(358, 172);
            this.phonBox1.Multiline = true;
            this.phonBox1.Name = "phonBox1";
            this.phonBox1.Size = new System.Drawing.Size(233, 35);
            this.phonBox1.TabIndex = 27;
            this.phonBox1.TextChanged += new System.EventHandler(this.phonBox_TextChanged);
            // 
            // emailBox1
            // 
            this.emailBox1.Location = new System.Drawing.Point(358, 129);
            this.emailBox1.Multiline = true;
            this.emailBox1.Name = "emailBox1";
            this.emailBox1.Size = new System.Drawing.Size(233, 37);
            this.emailBox1.TabIndex = 26;
            // 
            // nameBox1
            // 
            this.nameBox1.Location = new System.Drawing.Point(358, 86);
            this.nameBox1.Multiline = true;
            this.nameBox1.Name = "nameBox1";
            this.nameBox1.Size = new System.Drawing.Size(233, 37);
            this.nameBox1.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(264, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "HOBBIES*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(264, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "ZIP CODE*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(264, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "PHONE*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(264, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "EMAIL*";
            // 
            // NAME
            // 
            this.NAME.AccessibleName = "Name";
            this.NAME.AutoSize = true;
            this.NAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NAME.Location = new System.Drawing.Point(264, 89);
            this.NAME.Name = "NAME";
            this.NAME.Size = new System.Drawing.Size(63, 20);
            this.NAME.TabIndex = 16;
            this.NAME.Text = "NAME*";
            // 
            // updatebtn
            // 
            this.updatebtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.updatebtn.Location = new System.Drawing.Point(358, 325);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(125, 43);
            this.updatebtn.TabIndex = 29;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = false;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // hobbiesBox1
            // 
            this.hobbiesBox1.Location = new System.Drawing.Point(358, 255);
            this.hobbiesBox1.Multiline = true;
            this.hobbiesBox1.Name = "hobbiesBox1";
            this.hobbiesBox1.Size = new System.Drawing.Size(233, 36);
            this.hobbiesBox1.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AccessibleName = "Name";
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(246, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(374, 36);
            this.label6.TabIndex = 31;
            this.label6.Text = "Student Information Form";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(858, 511);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.hobbiesBox1);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.zipBox1);
            this.Controls.Add(this.phonBox1);
            this.Controls.Add(this.emailBox1);
            this.Controls.Add(this.nameBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NAME);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox zipBox1;
        private System.Windows.Forms.TextBox phonBox1;
        private System.Windows.Forms.TextBox emailBox1;
        private System.Windows.Forms.TextBox nameBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NAME;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.TextBox hobbiesBox1;
        private System.Windows.Forms.Label label6;
    }
}