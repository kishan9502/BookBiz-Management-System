namespace BookBiz_Management_System.GUI
{
    partial class AuthorPage
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
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonDeleteAuthor = new System.Windows.Forms.Button();
            this.listViewAuthor = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonListAuthor = new System.Windows.Forms.Button();
            this.buttonSearchAuthor = new System.Windows.Forms.Button();
            this.buttonAddAuthor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxAuthorId = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelEmpLastName = new System.Windows.Forms.Label();
            this.labelBookId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(276, 284);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(171, 22);
            this.textBoxSearch.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(147, 288);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 18);
            this.label5.TabIndex = 63;
            this.label5.Text = "Search By ID";
            // 
            // buttonDeleteAuthor
            // 
            this.buttonDeleteAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteAuthor.Location = new System.Drawing.Point(766, 505);
            this.buttonDeleteAuthor.Name = "buttonDeleteAuthor";
            this.buttonDeleteAuthor.Size = new System.Drawing.Size(184, 34);
            this.buttonDeleteAuthor.TabIndex = 62;
            this.buttonDeleteAuthor.Text = "Delete Author";
            this.buttonDeleteAuthor.UseVisualStyleBackColor = true;
            this.buttonDeleteAuthor.Click += new System.EventHandler(this.buttonDeleteAuthor_Click);
            // 
            // listViewAuthor
            // 
            this.listViewAuthor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewAuthor.GridLines = true;
            this.listViewAuthor.HideSelection = false;
            this.listViewAuthor.Location = new System.Drawing.Point(57, 339);
            this.listViewAuthor.Name = "listViewAuthor";
            this.listViewAuthor.Size = new System.Drawing.Size(665, 200);
            this.listViewAuthor.TabIndex = 61;
            this.listViewAuthor.UseCompatibleStateImageBehavior = false;
            this.listViewAuthor.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Author Id";
            this.columnHeader1.Width = 104;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "First Name";
            this.columnHeader2.Width = 160;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Last Name";
            this.columnHeader3.Width = 242;
            // 
            // buttonListAuthor
            // 
            this.buttonListAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListAuthor.Location = new System.Drawing.Point(766, 339);
            this.buttonListAuthor.Name = "buttonListAuthor";
            this.buttonListAuthor.Size = new System.Drawing.Size(184, 34);
            this.buttonListAuthor.TabIndex = 60;
            this.buttonListAuthor.Text = "List Author";
            this.buttonListAuthor.UseVisualStyleBackColor = true;
            this.buttonListAuthor.Click += new System.EventHandler(this.buttonListAuthor_Click);
            // 
            // buttonSearchAuthor
            // 
            this.buttonSearchAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchAuthor.Location = new System.Drawing.Point(589, 268);
            this.buttonSearchAuthor.Name = "buttonSearchAuthor";
            this.buttonSearchAuthor.Size = new System.Drawing.Size(174, 34);
            this.buttonSearchAuthor.TabIndex = 59;
            this.buttonSearchAuthor.Text = "Search Author";
            this.buttonSearchAuthor.UseVisualStyleBackColor = true;
            this.buttonSearchAuthor.Click += new System.EventHandler(this.buttonSearchAuthor_Click);
            // 
            // buttonAddAuthor
            // 
            this.buttonAddAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddAuthor.Location = new System.Drawing.Point(589, 106);
            this.buttonAddAuthor.Name = "buttonAddAuthor";
            this.buttonAddAuthor.Size = new System.Drawing.Size(174, 34);
            this.buttonAddAuthor.TabIndex = 58;
            this.buttonAddAuthor.Text = "Add Author";
            this.buttonAddAuthor.UseVisualStyleBackColor = true;
            this.buttonAddAuthor.Click += new System.EventHandler(this.buttonAddAuthor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(427, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 52);
            this.label1.TabIndex = 57;
            this.label1.Text = "Author";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(276, 194);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(171, 22);
            this.textBoxLastName.TabIndex = 56;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(276, 150);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(171, 22);
            this.textBoxFirstName.TabIndex = 55;
            // 
            // textBoxAuthorId
            // 
            this.textBoxAuthorId.Location = new System.Drawing.Point(276, 108);
            this.textBoxAuthorId.Name = "textBoxAuthorId";
            this.textBoxAuthorId.Size = new System.Drawing.Size(171, 22);
            this.textBoxAuthorId.TabIndex = 54;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(151, 152);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(102, 20);
            this.labelTitle.TabIndex = 53;
            this.labelTitle.Text = "First Name";
            // 
            // labelEmpLastName
            // 
            this.labelEmpLastName.AutoSize = true;
            this.labelEmpLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpLastName.Location = new System.Drawing.Point(151, 196);
            this.labelEmpLastName.Name = "labelEmpLastName";
            this.labelEmpLastName.Size = new System.Drawing.Size(100, 20);
            this.labelEmpLastName.TabIndex = 52;
            this.labelEmpLastName.Text = "Last Name";
            // 
            // labelBookId
            // 
            this.labelBookId.AutoSize = true;
            this.labelBookId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookId.Location = new System.Drawing.Point(151, 106);
            this.labelBookId.Name = "labelBookId";
            this.labelBookId.Size = new System.Drawing.Size(89, 20);
            this.labelBookId.TabIndex = 51;
            this.labelBookId.Text = "Author ID";
            // 
            // AuthorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 579);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonDeleteAuthor);
            this.Controls.Add(this.listViewAuthor);
            this.Controls.Add(this.buttonListAuthor);
            this.Controls.Add(this.buttonSearchAuthor);
            this.Controls.Add(this.buttonAddAuthor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxAuthorId);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelEmpLastName);
            this.Controls.Add(this.labelBookId);
            this.Name = "AuthorPage";
            this.Text = "Author";
            this.Load += new System.EventHandler(this.AuthorPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonDeleteAuthor;
        private System.Windows.Forms.ListView listViewAuthor;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button buttonListAuthor;
        private System.Windows.Forms.Button buttonSearchAuthor;
        private System.Windows.Forms.Button buttonAddAuthor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxAuthorId;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelEmpLastName;
        private System.Windows.Forms.Label labelBookId;
    }
}