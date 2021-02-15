namespace BookBiz_Management_System.GUI
{
    partial class OrderPage
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
            this.label3 = new System.Windows.Forms.Label();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.listViewOrder = new System.Windows.Forms.ListView();
            this.buttonCancelOrder = new System.Windows.Forms.Button();
            this.buttonListOrder = new System.Windows.Forms.Button();
            this.buttonSearchOrder = new System.Windows.Forms.Button();
            this.buttonAddOrder = new System.Windows.Forms.Button();
            this.textBoxIsbn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxClientId = new System.Windows.Forms.TextBox();
            this.textBoxTakenBy = new System.Windows.Forms.TextBox();
            this.textBoxOrderDate = new System.Windows.Forms.TextBox();
            this.textBoxOrderId = new System.Windows.Forms.TextBox();
            this.labelEmpJob = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelEmpLastName = new System.Windows.Forms.Label();
            this.labelBookId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(358, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 68;
            this.label3.Text = "Search ID";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ISBN";
            this.columnHeader5.Width = 161;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Taken By";
            this.columnHeader4.Width = 157;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Client ID";
            this.columnHeader3.Width = 107;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Order Date";
            this.columnHeader2.Width = 160;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Order Id";
            this.columnHeader1.Width = 104;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(483, 223);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(133, 22);
            this.textBoxSearch.TabIndex = 69;
            // 
            // listViewOrder
            // 
            this.listViewOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewOrder.GridLines = true;
            this.listViewOrder.HideSelection = false;
            this.listViewOrder.Location = new System.Drawing.Point(27, 386);
            this.listViewOrder.Name = "listViewOrder";
            this.listViewOrder.Size = new System.Drawing.Size(694, 187);
            this.listViewOrder.TabIndex = 67;
            this.listViewOrder.UseCompatibleStateImageBehavior = false;
            this.listViewOrder.View = System.Windows.Forms.View.Details;
            // 
            // buttonCancelOrder
            // 
            this.buttonCancelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelOrder.Location = new System.Drawing.Point(808, 539);
            this.buttonCancelOrder.Name = "buttonCancelOrder";
            this.buttonCancelOrder.Size = new System.Drawing.Size(161, 34);
            this.buttonCancelOrder.TabIndex = 66;
            this.buttonCancelOrder.Text = "Cancel Order";
            this.buttonCancelOrder.UseVisualStyleBackColor = true;
            this.buttonCancelOrder.Click += new System.EventHandler(this.buttonCancelOrder_Click);
            // 
            // buttonListOrder
            // 
            this.buttonListOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListOrder.Location = new System.Drawing.Point(808, 386);
            this.buttonListOrder.Name = "buttonListOrder";
            this.buttonListOrder.Size = new System.Drawing.Size(161, 34);
            this.buttonListOrder.TabIndex = 65;
            this.buttonListOrder.Text = "List Order";
            this.buttonListOrder.UseVisualStyleBackColor = true;
            this.buttonListOrder.Click += new System.EventHandler(this.buttonListOrder_Click);
            // 
            // buttonSearchOrder
            // 
            this.buttonSearchOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchOrder.Location = new System.Drawing.Point(675, 211);
            this.buttonSearchOrder.Name = "buttonSearchOrder";
            this.buttonSearchOrder.Size = new System.Drawing.Size(161, 34);
            this.buttonSearchOrder.TabIndex = 64;
            this.buttonSearchOrder.Text = "Search Order";
            this.buttonSearchOrder.UseVisualStyleBackColor = true;
            this.buttonSearchOrder.Click += new System.EventHandler(this.buttonSearchOrder_Click);
            // 
            // buttonAddOrder
            // 
            this.buttonAddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddOrder.Location = new System.Drawing.Point(675, 105);
            this.buttonAddOrder.Name = "buttonAddOrder";
            this.buttonAddOrder.Size = new System.Drawing.Size(161, 34);
            this.buttonAddOrder.TabIndex = 63;
            this.buttonAddOrder.Text = "Add Order";
            this.buttonAddOrder.UseVisualStyleBackColor = true;
            this.buttonAddOrder.Click += new System.EventHandler(this.buttonAddOrder_Click);
            // 
            // textBoxIsbn
            // 
            this.textBoxIsbn.Location = new System.Drawing.Point(483, 163);
            this.textBoxIsbn.Name = "textBoxIsbn";
            this.textBoxIsbn.Size = new System.Drawing.Size(133, 22);
            this.textBoxIsbn.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(358, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 61;
            this.label2.Text = "ISBN";
            // 
            // textBoxClientId
            // 
            this.textBoxClientId.Location = new System.Drawing.Point(164, 223);
            this.textBoxClientId.Name = "textBoxClientId";
            this.textBoxClientId.Size = new System.Drawing.Size(133, 22);
            this.textBoxClientId.TabIndex = 60;
            // 
            // textBoxTakenBy
            // 
            this.textBoxTakenBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTakenBy.Location = new System.Drawing.Point(483, 111);
            this.textBoxTakenBy.Name = "textBoxTakenBy";
            this.textBoxTakenBy.Size = new System.Drawing.Size(133, 22);
            this.textBoxTakenBy.TabIndex = 59;
            // 
            // textBoxOrderDate
            // 
            this.textBoxOrderDate.Location = new System.Drawing.Point(164, 165);
            this.textBoxOrderDate.Name = "textBoxOrderDate";
            this.textBoxOrderDate.Size = new System.Drawing.Size(133, 22);
            this.textBoxOrderDate.TabIndex = 58;
            // 
            // textBoxOrderId
            // 
            this.textBoxOrderId.Location = new System.Drawing.Point(164, 107);
            this.textBoxOrderId.Name = "textBoxOrderId";
            this.textBoxOrderId.Size = new System.Drawing.Size(133, 22);
            this.textBoxOrderId.TabIndex = 57;
            // 
            // labelEmpJob
            // 
            this.labelEmpJob.AutoSize = true;
            this.labelEmpJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpJob.Location = new System.Drawing.Point(358, 111);
            this.labelEmpJob.Name = "labelEmpJob";
            this.labelEmpJob.Size = new System.Drawing.Size(81, 20);
            this.labelEmpJob.TabIndex = 56;
            this.labelEmpJob.Text = "TakenBy";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(39, 167);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(103, 20);
            this.labelTitle.TabIndex = 55;
            this.labelTitle.Text = "Order Date";
            // 
            // labelEmpLastName
            // 
            this.labelEmpLastName.AutoSize = true;
            this.labelEmpLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpLastName.Location = new System.Drawing.Point(39, 225);
            this.labelEmpLastName.Name = "labelEmpLastName";
            this.labelEmpLastName.Size = new System.Drawing.Size(76, 20);
            this.labelEmpLastName.TabIndex = 54;
            this.labelEmpLastName.Text = "client Id";
            // 
            // labelBookId
            // 
            this.labelBookId.AutoSize = true;
            this.labelBookId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookId.Location = new System.Drawing.Point(39, 105);
            this.labelBookId.Name = "labelBookId";
            this.labelBookId.Size = new System.Drawing.Size(82, 20);
            this.labelBookId.TabIndex = 53;
            this.labelBookId.Text = "Order ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(417, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 52);
            this.label1.TabIndex = 52;
            this.label1.Text = "Order";
            // 
            // OrderPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 608);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.listViewOrder);
            this.Controls.Add(this.buttonCancelOrder);
            this.Controls.Add(this.buttonListOrder);
            this.Controls.Add(this.buttonSearchOrder);
            this.Controls.Add(this.buttonAddOrder);
            this.Controls.Add(this.textBoxIsbn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxClientId);
            this.Controls.Add(this.textBoxTakenBy);
            this.Controls.Add(this.textBoxOrderDate);
            this.Controls.Add(this.textBoxOrderId);
            this.Controls.Add(this.labelEmpJob);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelEmpLastName);
            this.Controls.Add(this.labelBookId);
            this.Controls.Add(this.label1);
            this.Name = "OrderPage";
            this.Text = "OrderPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ListView listViewOrder;
        private System.Windows.Forms.Button buttonCancelOrder;
        private System.Windows.Forms.Button buttonListOrder;
        private System.Windows.Forms.Button buttonSearchOrder;
        private System.Windows.Forms.Button buttonAddOrder;
        private System.Windows.Forms.TextBox textBoxIsbn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxClientId;
        private System.Windows.Forms.TextBox textBoxTakenBy;
        private System.Windows.Forms.TextBox textBoxOrderDate;
        private System.Windows.Forms.TextBox textBoxOrderId;
        private System.Windows.Forms.Label labelEmpJob;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelEmpLastName;
        private System.Windows.Forms.Label labelBookId;
        private System.Windows.Forms.Label label1;
    }
}