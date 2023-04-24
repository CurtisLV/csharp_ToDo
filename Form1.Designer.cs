namespace csharp_ToDo
{
    partial class ToDoListForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.newBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.todoListView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.todoListView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1233, 87);
            this.label1.TabIndex = 0;
            this.label1.Text = "ToDo List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(14, 133);
            this.titleTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(1233, 27);
            this.titleTextBox.TabIndex = 1;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(14, 203);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(1233, 27);
            this.descriptionTextBox.TabIndex = 2;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Location = new System.Drawing.Point(14, 168);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(1233, 31);
            this.descriptionLabel.TabIndex = 3;
            this.descriptionLabel.Text = "Description";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // titleLabel
            // 
            this.titleLabel.Location = new System.Drawing.Point(14, 99);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(1233, 31);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Title:";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // newBtn
            // 
            this.newBtn.BackColor = System.Drawing.Color.Azure;
            this.newBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newBtn.Location = new System.Drawing.Point(14, 256);
            this.newBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(291, 44);
            this.newBtn.TabIndex = 5;
            this.newBtn.Text = "New Item";
            this.newBtn.UseVisualStyleBackColor = false;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.Azure;
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveBtn.Location = new System.Drawing.Point(955, 256);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(291, 44);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Azure;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteBtn.Location = new System.Drawing.Point(642, 256);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(289, 44);
            this.deleteBtn.TabIndex = 7;
            this.deleteBtn.Text = "Delete Item";
            this.deleteBtn.UseVisualStyleBackColor = false;
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.Azure;
            this.editBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editBtn.Location = new System.Drawing.Point(329, 256);
            this.editBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(289, 44);
            this.editBtn.TabIndex = 8;
            this.editBtn.Text = "Edit Item";
            this.editBtn.UseVisualStyleBackColor = false;
            // 
            // todoListView
            // 
            this.todoListView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.todoListView.BackgroundColor = System.Drawing.Color.White;
            this.todoListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.todoListView.Location = new System.Drawing.Point(16, 324);
            this.todoListView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.todoListView.Name = "todoListView";
            this.todoListView.RowHeadersWidth = 51;
            this.todoListView.RowTemplate.Height = 25;
            this.todoListView.Size = new System.Drawing.Size(1231, 509);
            this.todoListView.TabIndex = 9;
            this.todoListView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.toDoListView_CellContentClick);
            // 
            // ToDoListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1261, 849);
            this.Controls.Add(this.todoListView);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.newBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ToDoListForm";
            this.Text = "ToDo List";
            this.Load += new System.EventHandler(this.ToDoListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.todoListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox titleTextBox;
        private TextBox descriptionTextBox;
        private Label descriptionLabel;
        private Label titleLabel;
        private Button newBtn;
        private Button saveBtn;
        private Button deleteBtn;
        private Button editBtn;
        private DataGridView todoListView;
    }
}