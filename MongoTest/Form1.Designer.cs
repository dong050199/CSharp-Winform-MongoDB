
namespace MongoTest
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
            this.dtpk_date_from = new System.Windows.Forms.DateTimePicker();
            this.dtpk_time_from = new System.Windows.Forms.DateTimePicker();
            this.bt_Insert = new System.Windows.Forms.Button();
            this.bt_Delete = new System.Windows.Forms.Button();
            this.bt_Query = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dtpk_time_to = new System.Windows.Forms.DateTimePicker();
            this.dtpk_date_to = new System.Windows.Forms.DateTimePicker();
            this.dtpk_time_delete = new System.Windows.Forms.DateTimePicker();
            this.dtpk_date_delete = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpk_date_from
            // 
            this.dtpk_date_from.Location = new System.Drawing.Point(431, 35);
            this.dtpk_date_from.Name = "dtpk_date_from";
            this.dtpk_date_from.Size = new System.Drawing.Size(199, 20);
            this.dtpk_date_from.TabIndex = 3;
            // 
            // dtpk_time_from
            // 
            this.dtpk_time_from.Location = new System.Drawing.Point(636, 35);
            this.dtpk_time_from.Name = "dtpk_time_from";
            this.dtpk_time_from.Size = new System.Drawing.Size(123, 20);
            this.dtpk_time_from.TabIndex = 4;
            // 
            // bt_Insert
            // 
            this.bt_Insert.Location = new System.Drawing.Point(431, 173);
            this.bt_Insert.Name = "bt_Insert";
            this.bt_Insert.Size = new System.Drawing.Size(175, 58);
            this.bt_Insert.TabIndex = 5;
            this.bt_Insert.Text = "Insert";
            this.bt_Insert.UseVisualStyleBackColor = true;
            this.bt_Insert.Click += new System.EventHandler(this.bt_Insert_Click);
            // 
            // bt_Delete
            // 
            this.bt_Delete.Location = new System.Drawing.Point(431, 250);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.Size = new System.Drawing.Size(175, 58);
            this.bt_Delete.TabIndex = 6;
            this.bt_Delete.Text = "delete";
            this.bt_Delete.UseVisualStyleBackColor = true;
            this.bt_Delete.Click += new System.EventHandler(this.bt_Delete_Click);
            // 
            // bt_Query
            // 
            this.bt_Query.Location = new System.Drawing.Point(431, 328);
            this.bt_Query.Name = "bt_Query";
            this.bt_Query.Size = new System.Drawing.Size(175, 58);
            this.bt_Query.TabIndex = 7;
            this.bt_Query.Text = "query";
            this.bt_Query.UseVisualStyleBackColor = true;
            this.bt_Query.Click += new System.EventHandler(this.bt_Query_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(398, 426);
            this.dataGridView1.TabIndex = 8;
            // 
            // dtpk_time_to
            // 
            this.dtpk_time_to.Location = new System.Drawing.Point(636, 80);
            this.dtpk_time_to.Name = "dtpk_time_to";
            this.dtpk_time_to.Size = new System.Drawing.Size(123, 20);
            this.dtpk_time_to.TabIndex = 10;
            // 
            // dtpk_date_to
            // 
            this.dtpk_date_to.Location = new System.Drawing.Point(431, 80);
            this.dtpk_date_to.Name = "dtpk_date_to";
            this.dtpk_date_to.Size = new System.Drawing.Size(199, 20);
            this.dtpk_date_to.TabIndex = 9;
            // 
            // dtpk_time_delete
            // 
            this.dtpk_time_delete.Location = new System.Drawing.Point(636, 130);
            this.dtpk_time_delete.Name = "dtpk_time_delete";
            this.dtpk_time_delete.Size = new System.Drawing.Size(123, 20);
            this.dtpk_time_delete.TabIndex = 12;
            // 
            // dtpk_date_delete
            // 
            this.dtpk_date_delete.Location = new System.Drawing.Point(431, 130);
            this.dtpk_date_delete.Name = "dtpk_date_delete";
            this.dtpk_date_delete.Size = new System.Drawing.Size(199, 20);
            this.dtpk_date_delete.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(428, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "From date time query";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(428, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "to date time query";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "delete time from";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpk_time_delete);
            this.Controls.Add(this.dtpk_date_delete);
            this.Controls.Add(this.dtpk_time_to);
            this.Controls.Add(this.dtpk_date_to);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_Query);
            this.Controls.Add(this.bt_Delete);
            this.Controls.Add(this.bt_Insert);
            this.Controls.Add(this.dtpk_time_from);
            this.Controls.Add(this.dtpk_date_from);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpk_date_from;
        private System.Windows.Forms.DateTimePicker dtpk_time_from;
        private System.Windows.Forms.Button bt_Insert;
        private System.Windows.Forms.Button bt_Delete;
        private System.Windows.Forms.Button bt_Query;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dtpk_time_to;
        private System.Windows.Forms.DateTimePicker dtpk_date_to;
        private System.Windows.Forms.DateTimePicker dtpk_time_delete;
        private System.Windows.Forms.DateTimePicker dtpk_date_delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

