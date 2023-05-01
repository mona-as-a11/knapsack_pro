namespace mona5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.remove = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.item = new System.Windows.Forms.Label();
            this.weight = new System.Windows.Forms.Label();
            this.value = new System.Windows.Forms.Label();
            this.capacity = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.solve = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(352, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(494, 350);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Elephant", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Elephant", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.Color.Bisque;
            this.dataGridView1.Location = new System.Drawing.Point(424, 93);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Elephant", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Gold;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(350, 251);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // remove
            // 
            this.remove.BackColor = System.Drawing.Color.SaddleBrown;
            this.remove.Font = new System.Drawing.Font("Elephant", 8F);
            this.remove.ForeColor = System.Drawing.Color.White;
            this.remove.Location = new System.Drawing.Point(391, 493);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(66, 33);
            this.remove.TabIndex = 2;
            this.remove.Text = "remove";
            this.remove.UseVisualStyleBackColor = false;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Elephant", 13F);
            this.textBox1.Location = new System.Drawing.Point(218, 134);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 35);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Elephant", 13F);
            this.textBox2.Location = new System.Drawing.Point(218, 177);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 35);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Elephant", 13F);
            this.textBox3.Location = new System.Drawing.Point(218, 217);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 35);
            this.textBox3.TabIndex = 5;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.SaddleBrown;
            this.add.Font = new System.Drawing.Font("Elephant", 10F);
            this.add.ForeColor = System.Drawing.Color.White;
            this.add.Location = new System.Drawing.Point(151, 306);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(100, 66);
            this.add.TabIndex = 6;
            this.add.Text = "add";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // item
            // 
            this.item.AutoSize = true;
            this.item.BackColor = System.Drawing.Color.Peru;
            this.item.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.item.Font = new System.Drawing.Font("Elephant", 15F);
            this.item.ForeColor = System.Drawing.Color.White;
            this.item.Location = new System.Drawing.Point(84, 134);
            this.item.Name = "item";
            this.item.Size = new System.Drawing.Size(72, 35);
            this.item.TabIndex = 7;
            this.item.Text = "item";
            // 
            // weight
            // 
            this.weight.AutoSize = true;
            this.weight.BackColor = System.Drawing.Color.Peru;
            this.weight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.weight.Font = new System.Drawing.Font("Elephant", 15F);
            this.weight.ForeColor = System.Drawing.Color.White;
            this.weight.Location = new System.Drawing.Point(84, 176);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(97, 35);
            this.weight.TabIndex = 8;
            this.weight.Text = "weight";
            // 
            // value
            // 
            this.value.AutoSize = true;
            this.value.BackColor = System.Drawing.Color.Peru;
            this.value.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.value.Font = new System.Drawing.Font("Elephant", 15F);
            this.value.ForeColor = System.Drawing.Color.White;
            this.value.Location = new System.Drawing.Point(84, 217);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(81, 35);
            this.value.TabIndex = 9;
            this.value.Text = "value";
            // 
            // capacity
            // 
            this.capacity.AutoSize = true;
            this.capacity.BackColor = System.Drawing.Color.Gold;
            this.capacity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.capacity.Font = new System.Drawing.Font("Elephant", 12F);
            this.capacity.ForeColor = System.Drawing.Color.White;
            this.capacity.Location = new System.Drawing.Point(468, 59);
            this.capacity.Name = "capacity";
            this.capacity.Size = new System.Drawing.Size(122, 28);
            this.capacity.TabIndex = 11;
            this.capacity.Text = "maxweight";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(629, 65);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(80, 22);
            this.textBox4.TabIndex = 12;
            // 
            // solve
            // 
            this.solve.BackColor = System.Drawing.Color.SaddleBrown;
            this.solve.Font = new System.Drawing.Font("Elephant", 15F);
            this.solve.ForeColor = System.Drawing.Color.White;
            this.solve.Location = new System.Drawing.Point(368, 416);
            this.solve.Name = "solve";
            this.solve.Size = new System.Drawing.Size(115, 53);
            this.solve.TabIndex = 13;
            this.solve.Text = "solve";
            this.solve.UseVisualStyleBackColor = false;
            this.solve.Click += new System.EventHandler(this.solve_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Peru;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Elephant", 15F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(543, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 35);
            this.label1.TabIndex = 14;
            this.label1.Text = "mixvalue";
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Gold;
            this.back.Location = new System.Drawing.Point(2, 2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 15;
            this.back.Text = "<---";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1006, 630);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.solve);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.capacity);
            this.Controls.Add(this.value);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.item);
            this.Controls.Add(this.add);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label item;
        private System.Windows.Forms.Label weight;
        private System.Windows.Forms.Label value;
        private System.Windows.Forms.Label capacity;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button solve;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back;
    }
}