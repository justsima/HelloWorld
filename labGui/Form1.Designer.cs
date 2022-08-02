using System;

namespace labGui
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.inventory = new System.Windows.Forms.Label();
            this.txt_number = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_date = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.errorPro1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_count = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.chkList = new System.Windows.Forms.CheckedListBox();
            this.checkbox1 = new System.Windows.Forms.CheckBox();
            this.dt1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbtn2 = new System.Windows.Forms.RadioButton();
            this.rdbtn1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DisplayName = new System.Windows.Forms.Label();
            this.txt_inventory = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorPro1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(219, 522);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 59);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inventory
            // 
            this.inventory.AutoSize = true;
            this.inventory.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventory.Location = new System.Drawing.Point(721, 51);
            this.inventory.Name = "inventory";
            this.inventory.Size = new System.Drawing.Size(251, 31);
            this.inventory.TabIndex = 5;
            this.inventory.Text = "Inventory Number";
            // 
            // txt_number
            // 
            this.txt_number.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_number.Location = new System.Drawing.Point(151, 93);
            this.txt_number.Multiline = true;
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(165, 34);
            this.txt_number.TabIndex = 9;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(151, 195);
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(809, 36);
            this.txt_name.TabIndex = 12;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(359, 93);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(333, 26);
            this.txt_date.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(657, 522);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 59);
            this.button2.TabIndex = 16;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // errorPro1
            // 
            this.errorPro1.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(145, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 31);
            this.label3.TabIndex = 24;
            this.label3.Text = "Number";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(362, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 31);
            this.label4.TabIndex = 25;
            this.label4.Text = "Date";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(146, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 30);
            this.label5.TabIndex = 26;
            this.label5.Text = "Object Name ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(145, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 31);
            this.label6.TabIndex = 27;
            this.label6.Text = "Count";
            // 
            // txt_count
            // 
            this.txt_count.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_count.Location = new System.Drawing.Point(150, 290);
            this.txt_count.Multiline = true;
            this.txt_count.Name = "txt_count";
            this.txt_count.Size = new System.Drawing.Size(165, 37);
            this.txt_count.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(354, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 31);
            this.label7.TabIndex = 29;
            this.label7.Text = "Price";
            // 
            // txt_price
            // 
            this.txt_price.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.Location = new System.Drawing.Point(359, 290);
            this.txt_price.Multiline = true;
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(333, 37);
            this.txt_price.TabIndex = 30;
            // 
            // chkList
            // 
            this.chkList.FormattingEnabled = true;
            this.chkList.Items.AddRange(new object[] {
            "Imported",
            "Exported",
            "Produced"});
            this.chkList.Location = new System.Drawing.Point(150, 395);
            this.chkList.Name = "chkList";
            this.chkList.Size = new System.Drawing.Size(542, 96);
            this.chkList.TabIndex = 19;
            this.chkList.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // checkbox1
            // 
            this.checkbox1.AutoSize = true;
            this.checkbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox1.Location = new System.Drawing.Point(738, 290);
            this.checkbox1.Name = "checkbox1";
            this.checkbox1.Size = new System.Drawing.Size(138, 36);
            this.checkbox1.TabIndex = 18;
            this.checkbox1.Text = "In Store";
            this.checkbox1.UseVisualStyleBackColor = true;
            this.checkbox1.CheckedChanged += new System.EventHandler(this.checkbox1_CheckedChanged);
            // 
            // dt1
            // 
            this.dt1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt1.Location = new System.Drawing.Point(12, 597);
            this.dt1.Name = "dt1";
            this.dt1.RowHeadersWidth = 62;
            this.dt1.RowTemplate.Height = 28;
            this.dt1.Size = new System.Drawing.Size(1132, 313);
            this.dt1.TabIndex = 31;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbtn2);
            this.groupBox1.Controls.Add(this.rdbtn1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(738, 372);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 133);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdbtn2
            // 
            this.rdbtn2.AutoSize = true;
            this.rdbtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn2.Location = new System.Drawing.Point(38, 82);
            this.rdbtn2.Name = "rdbtn2";
            this.rdbtn2.Size = new System.Drawing.Size(83, 29);
            this.rdbtn2.TabIndex = 21;
            this.rdbtn2.TabStop = true;
            this.rdbtn2.Text = "Used";
            this.rdbtn2.UseVisualStyleBackColor = true;
            this.rdbtn2.CheckedChanged += new System.EventHandler(this.rdbtn2_CheckedChanged);
            // 
            // rdbtn1
            // 
            this.rdbtn1.AutoSize = true;
            this.rdbtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn1.Location = new System.Drawing.Point(38, 34);
            this.rdbtn1.Name = "rdbtn1";
            this.rdbtn1.Size = new System.Drawing.Size(81, 29);
            this.rdbtn1.TabIndex = 20;
            this.rdbtn1.TabStop = true;
            this.rdbtn1.Text = "New ";
            this.rdbtn1.UseVisualStyleBackColor = true;
            this.rdbtn1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, -6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 30);
            this.label2.TabIndex = 22;
            this.label2.Text = "Condition ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 30);
            this.label1.TabIndex = 32;
            this.label1.Text = "Product type";
            // 
            // DisplayName
            // 
            this.DisplayName.AutoSize = true;
            this.DisplayName.Font = new System.Drawing.Font("Monotype Corsiva", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayName.Location = new System.Drawing.Point(6, 9);
            this.DisplayName.Name = "DisplayName";
            this.DisplayName.Size = new System.Drawing.Size(103, 31);
            this.DisplayName.TabIndex = 33;
            this.DisplayName.Text = "Welcome";
            this.DisplayName.Click += new System.EventHandler(this.DisplayName_Click);
            // 
            // txt_inventory
            // 
            this.txt_inventory.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_inventory.Location = new System.Drawing.Point(738, 93);
            this.txt_inventory.Multiline = true;
            this.txt_inventory.Name = "txt_inventory";
            this.txt_inventory.Size = new System.Drawing.Size(165, 34);
            this.txt_inventory.TabIndex = 34;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 962);
            this.Controls.Add(this.txt_inventory);
            this.Controls.Add(this.DisplayName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dt1);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_count);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkList);
            this.Controls.Add(this.checkbox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_number);
            this.Controls.Add(this.inventory);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.errorPro1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label inventory;
        private System.Windows.Forms.TextBox txt_number;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.DateTimePicker txt_date;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorPro1;
        private EventHandler label5_Click;
        private EventHandler txt_number_TextChanged;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_count;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox chkList;
        private System.Windows.Forms.CheckBox checkbox1;
        private System.Windows.Forms.DataGridView dt1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbtn2;
        private System.Windows.Forms.RadioButton rdbtn1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DisplayName;
        private System.Windows.Forms.TextBox txt_inventory;
    }
}

