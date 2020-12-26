namespace Diary
{
    partial class Home
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
            this.Back = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.text = new System.Windows.Forms.TextBox();
            this.Update = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.EventName = new System.Windows.Forms.TextBox();
            this.PriorityBox = new System.Windows.Forms.ComboBox();
            this.View = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EventDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(803, 461);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 2;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(361, 461);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 3;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(361, 87);
            this.text.Multiline = true;
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(517, 332);
            this.text.TabIndex = 4;
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(523, 461);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 5;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(442, 461);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(75, 23);
            this.Remove.TabIndex = 6;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // EventName
            // 
            this.EventName.Location = new System.Drawing.Point(418, 12);
            this.EventName.Multiline = true;
            this.EventName.Name = "EventName";
            this.EventName.Size = new System.Drawing.Size(460, 20);
            this.EventName.TabIndex = 7;
            // 
            // PriorityBox
            // 
            this.PriorityBox.FormattingEnabled = true;
            this.PriorityBox.Items.AddRange(new object[] {
            "High",
            "Medium",
            "Low"});
            this.PriorityBox.Location = new System.Drawing.Point(418, 48);
            this.PriorityBox.Name = "PriorityBox";
            this.PriorityBox.Size = new System.Drawing.Size(121, 21);
            this.PriorityBox.TabIndex = 9;
            // 
            // View
            // 
            this.View.Location = new System.Drawing.Point(604, 461);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(75, 23);
            this.View.TabIndex = 10;
            this.View.Text = "View";
            this.View.UseVisualStyleBackColor = true;
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(343, 472);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Event";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Priority";
            // 
            // EventDate
            // 
            this.EventDate.CustomFormat = "dd-MM-yyyy";
            this.EventDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EventDate.Location = new System.Drawing.Point(613, 48);
            this.EventDate.Name = "EventDate";
            this.EventDate.Size = new System.Drawing.Size(200, 20);
            this.EventDate.TabIndex = 8;
            this.EventDate.Value = new System.DateTime(2020, 12, 27, 1, 55, 43, 0);
            this.EventDate.Visible = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 496);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.View);
            this.Controls.Add(this.PriorityBox);
            this.Controls.Add(this.EventDate);
            this.Controls.Add(this.EventName);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.text);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Back);
            this.Name = "Home";
            this.Text = "Home";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Home_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.TextBox EventName;
        private System.Windows.Forms.ComboBox PriorityBox;
        private System.Windows.Forms.Button View;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker EventDate;

    }
}