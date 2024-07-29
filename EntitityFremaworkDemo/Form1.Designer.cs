namespace EntitityFremaworkDemo
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
            this.lblStockAmountUpdate = new System.Windows.Forms.Label();
            this.lblUnirPriceUpdate = new System.Windows.Forms.Label();
            this.tbxStockAmountUpdate = new System.Windows.Forms.TextBox();
            this.tbxUnitPriceUpdate = new System.Windows.Forms.TextBox();
            this.tbxNameUpdate = new System.Windows.Forms.TextBox();
            this.lblNameUpdate = new System.Windows.Forms.Label();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStockAmount = new System.Windows.Forms.Label();
            this.tbxStockAmount = new System.Windows.Forms.TextBox();
            this.tbxUnitPrice = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.tbxGetById = new System.Windows.Forms.Button();
            this.gbxUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.gbxAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStockAmountUpdate
            // 
            this.lblStockAmountUpdate.AutoSize = true;
            this.lblStockAmountUpdate.Location = new System.Drawing.Point(475, 359);
            this.lblStockAmountUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStockAmountUpdate.Name = "lblStockAmountUpdate";
            this.lblStockAmountUpdate.Size = new System.Drawing.Size(89, 16);
            this.lblStockAmountUpdate.TabIndex = 28;
            this.lblStockAmountUpdate.Text = "Stock Amount";
            // 
            // lblUnirPriceUpdate
            // 
            this.lblUnirPriceUpdate.AutoSize = true;
            this.lblUnirPriceUpdate.Location = new System.Drawing.Point(475, 327);
            this.lblUnirPriceUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnirPriceUpdate.Name = "lblUnirPriceUpdate";
            this.lblUnirPriceUpdate.Size = new System.Drawing.Size(64, 16);
            this.lblUnirPriceUpdate.TabIndex = 27;
            this.lblUnirPriceUpdate.Text = "Unit Price";
            // 
            // tbxStockAmountUpdate
            // 
            this.tbxStockAmountUpdate.Location = new System.Drawing.Point(582, 351);
            this.tbxStockAmountUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.tbxStockAmountUpdate.Name = "tbxStockAmountUpdate";
            this.tbxStockAmountUpdate.Size = new System.Drawing.Size(132, 22);
            this.tbxStockAmountUpdate.TabIndex = 26;
            // 
            // tbxUnitPriceUpdate
            // 
            this.tbxUnitPriceUpdate.Location = new System.Drawing.Point(582, 319);
            this.tbxUnitPriceUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.tbxUnitPriceUpdate.Name = "tbxUnitPriceUpdate";
            this.tbxUnitPriceUpdate.Size = new System.Drawing.Size(132, 22);
            this.tbxUnitPriceUpdate.TabIndex = 25;
            // 
            // tbxNameUpdate
            // 
            this.tbxNameUpdate.Location = new System.Drawing.Point(582, 287);
            this.tbxNameUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.tbxNameUpdate.Name = "tbxNameUpdate";
            this.tbxNameUpdate.Size = new System.Drawing.Size(132, 22);
            this.tbxNameUpdate.TabIndex = 24;
            this.tbxNameUpdate.TextChanged += new System.EventHandler(this.tbxNameUpdate_TextChanged);
            // 
            // lblNameUpdate
            // 
            this.lblNameUpdate.AutoSize = true;
            this.lblNameUpdate.Location = new System.Drawing.Point(475, 287);
            this.lblNameUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameUpdate.Name = "lblNameUpdate";
            this.lblNameUpdate.Size = new System.Drawing.Size(44, 16);
            this.lblNameUpdate.TabIndex = 23;
            this.lblNameUpdate.Text = "Name";
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Location = new System.Drawing.Point(415, 248);
            this.gbxUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Padding = new System.Windows.Forms.Padding(4);
            this.gbxUpdate.Size = new System.Drawing.Size(346, 175);
            this.gbxUpdate.TabIndex = 29;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Update a product";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(167, 135);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(133, 28);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 359);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Stock Amount";
            // 
            // lblStockAmount
            // 
            this.lblStockAmount.AutoSize = true;
            this.lblStockAmount.Location = new System.Drawing.Point(89, 327);
            this.lblStockAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStockAmount.Name = "lblStockAmount";
            this.lblStockAmount.Size = new System.Drawing.Size(64, 16);
            this.lblStockAmount.TabIndex = 20;
            this.lblStockAmount.Text = "Unit Price";
            // 
            // tbxStockAmount
            // 
            this.tbxStockAmount.Location = new System.Drawing.Point(196, 351);
            this.tbxStockAmount.Margin = new System.Windows.Forms.Padding(4);
            this.tbxStockAmount.Name = "tbxStockAmount";
            this.tbxStockAmount.Size = new System.Drawing.Size(132, 22);
            this.tbxStockAmount.TabIndex = 19;
            // 
            // tbxUnitPrice
            // 
            this.tbxUnitPrice.Location = new System.Drawing.Point(196, 319);
            this.tbxUnitPrice.Margin = new System.Windows.Forms.Padding(4);
            this.tbxUnitPrice.Name = "tbxUnitPrice";
            this.tbxUnitPrice.Size = new System.Drawing.Size(132, 22);
            this.tbxUnitPrice.TabIndex = 18;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(196, 287);
            this.tbxName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(132, 22);
            this.tbxName.TabIndex = 17;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(89, 287);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "Name";
            // 
            // dgwProduct
            // 
            this.dgwProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(29, 56);
            this.dgwProduct.Margin = new System.Windows.Forms.Padding(4);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.RowHeadersWidth = 51;
            this.dgwProduct.Size = new System.Drawing.Size(743, 185);
            this.dgwProduct.TabIndex = 15;
            this.dgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
            this.dgwProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellContentClick);
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.btnAdd);
            this.gbxAdd.Location = new System.Drawing.Point(29, 248);
            this.gbxAdd.Margin = new System.Windows.Forms.Padding(4);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Padding = new System.Windows.Forms.Padding(4);
            this.gbxAdd.Size = new System.Drawing.Size(346, 175);
            this.gbxAdd.TabIndex = 22;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Add a product";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(167, 135);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(133, 28);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(29, 20);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(133, 28);
            this.btnRemove.TabIndex = 30;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(551, 26);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(50, 16);
            this.lblSearch.TabIndex = 32;
            this.lblSearch.Text = "Search";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(619, 25);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(142, 22);
            this.tbxSearch.TabIndex = 33;
            this.tbxSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbxGetById
            // 
            this.tbxGetById.Location = new System.Drawing.Point(169, 20);
            this.tbxGetById.Name = "tbxGetById";
            this.tbxGetById.Size = new System.Drawing.Size(145, 27);
            this.tbxGetById.TabIndex = 34;
            this.tbxGetById.Text = "Get By Id";
            this.tbxGetById.UseVisualStyleBackColor = true;
            this.tbxGetById.Click += new System.EventHandler(this.tbxGetById_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxGetById);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblStockAmountUpdate);
            this.Controls.Add(this.lblUnirPriceUpdate);
            this.Controls.Add(this.tbxStockAmountUpdate);
            this.Controls.Add(this.tbxUnitPriceUpdate);
            this.Controls.Add(this.tbxNameUpdate);
            this.Controls.Add(this.lblNameUpdate);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblStockAmount);
            this.Controls.Add(this.tbxStockAmount);
            this.Controls.Add(this.tbxUnitPrice);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.dgwProduct);
            this.Controls.Add(this.gbxAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxUpdate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.gbxAdd.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStockAmountUpdate;
        private System.Windows.Forms.Label lblUnirPriceUpdate;
        private System.Windows.Forms.TextBox tbxStockAmountUpdate;
        private System.Windows.Forms.TextBox tbxUnitPriceUpdate;
        private System.Windows.Forms.TextBox tbxNameUpdate;
        private System.Windows.Forms.Label lblNameUpdate;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStockAmount;
        private System.Windows.Forms.TextBox tbxStockAmount;
        private System.Windows.Forms.TextBox tbxUnitPrice;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Button tbxGetById;
    }
}

