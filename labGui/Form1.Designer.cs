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
            this.button1 = new System.Windows.Forms.Button();
            this.number = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.inventory = new System.Windows.Forms.Label();
            this.obname = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.txt_number = new System.Windows.Forms.TextBox();
            this.txt_inventory = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_count = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_date = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 59);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number.Location = new System.Drawing.Point(36, 33);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(114, 32);
            this.number.TabIndex = 3;
            this.number.Text = "Number";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(207, 33);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(74, 32);
            this.date.TabIndex = 4;
            this.date.Text = "Date";
            // 
            // inventory
            // 
            this.inventory.AutoSize = true;
            this.inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventory.Location = new System.Drawing.Point(538, 33);
            this.inventory.Name = "inventory";
            this.inventory.Size = new System.Drawing.Size(237, 32);
            this.inventory.TabIndex = 5;
            this.inventory.Text = "Inventory Number";
            // 
            // obname
            // 
            this.obname.AutoSize = true;
            this.obname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obname.Location = new System.Drawing.Point(36, 132);
            this.obname.Name = "obname";
            this.obname.Size = new System.Drawing.Size(182, 32);
            this.obname.TabIndex = 6;
            this.obname.Text = "Object name ";
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.count.Location = new System.Drawing.Point(36, 257);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(90, 32);
            this.count.TabIndex = 7;
            this.count.Text = "Count";
            this.count.Click += new System.EventHandler(this.label5_Click);
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(335, 257);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(79, 32);
            this.price.TabIndex = 8;
            this.price.Text = "Price";
            // 
            // txt_number
            // 
            this.txt_number.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_number.Location = new System.Drawing.Point(40, 65);
            this.txt_number.Multiline = true;
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(165, 33);
            this.txt_number.TabIndex = 9;
            // 
            // txt_inventory
            // 
            this.txt_inventory.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_inventory.Location = new System.Drawing.Point(542, 65);
            this.txt_inventory.Multiline = true;
            this.txt_inventory.Name = "txt_inventory";
            this.txt_inventory.Size = new System.Drawing.Size(443, 33);
            this.txt_inventory.TabIndex = 11;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(40, 173);
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(945, 33);
            this.txt_name.TabIndex = 12;
            // 
            // txt_count
            // 
            this.txt_count.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_count.Location = new System.Drawing.Point(40, 296);
            this.txt_count.Multiline = true;
            this.txt_count.Name = "txt_count";
            this.txt_count.Size = new System.Drawing.Size(294, 33);
            this.txt_count.TabIndex = 13;
            // 
            // txt_price
            // 
            this.txt_price.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.Location = new System.Drawing.Point(340, 296);
            this.txt_price.Multiline = true;
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(249, 33);
            this.txt_price.TabIndex = 14;
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(213, 65);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(323, 26);
            this.txt_date.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(340, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 59);
            this.button2.TabIndex = 16;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 472);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_count);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_inventory);
            this.Controls.Add(this.txt_number);
            this.Controls.Add(this.price);
            this.Controls.Add(this.count);
            this.Controls.Add(this.obname);
            this.Controls.Add(this.inventory);
            this.Controls.Add(this.date);
            this.Controls.Add(this.number);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label number;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label inventory;
        private System.Windows.Forms.Label obname;
        private System.Windows.Forms.Label count;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.TextBox txt_number;
        private System.Windows.Forms.TextBox txt_inventory;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_count;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.DateTimePicker txt_date;
        private System.Windows.Forms.Button button2;
    }
}

