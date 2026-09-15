namespace Week3Assignment3._4
{
    partial class CoffeeOrders
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
            txtName = new TextBox();
            lblName = new Label();
            lblPrice = new Label();
            txtPrice = new TextBox();
            lblSize = new Label();
            cmbSize = new ComboBox();
            lblRoast = new Label();
            cmbRoast = new ComboBox();
            lblMilk = new Label();
            cmbMilk = new ComboBox();
            chbHot = new CheckBox();
            chbSugar = new CheckBox();
            btnAdd = new Button();
            btnDeleteCoffee = new Button();
            CoffeeOrderGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)CoffeeOrderGrid).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(134, 44);
            txtName.Name = "txtName";
            txtName.Size = new Size(236, 31);
            txtName.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(65, 50);
            lblName.Name = "lblName";
            lblName.Size = new Size(63, 25);
            lblName.TabIndex = 1;
            lblName.Text = "Name:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(426, 50);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(53, 25);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "Price:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(498, 47);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(236, 31);
            txtPrice.TabIndex = 3;
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Location = new Point(81, 110);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(47, 25);
            lblSize.TabIndex = 4;
            lblSize.Text = "Size:";
            // 
            // cmbSize
            // 
            cmbSize.FormattingEnabled = true;
            cmbSize.Location = new Point(134, 102);
            cmbSize.Name = "cmbSize";
            cmbSize.Size = new Size(236, 33);
            cmbSize.TabIndex = 5;
            // 
            // lblRoast
            // 
            lblRoast.AutoSize = true;
            lblRoast.Location = new Point(419, 110);
            lblRoast.Name = "lblRoast";
            lblRoast.Size = new Size(60, 25);
            lblRoast.TabIndex = 6;
            lblRoast.Text = "Roast:";
            // 
            // cmbRoast
            // 
            cmbRoast.FormattingEnabled = true;
            cmbRoast.Location = new Point(498, 102);
            cmbRoast.Name = "cmbRoast";
            cmbRoast.Size = new Size(236, 33);
            cmbRoast.TabIndex = 7;
            // 
            // lblMilk
            // 
            lblMilk.AutoSize = true;
            lblMilk.Location = new Point(37, 170);
            lblMilk.Name = "lblMilk";
            lblMilk.Size = new Size(91, 25);
            lblMilk.TabIndex = 8;
            lblMilk.Text = "Milk Type:";
            // 
            // cmbMilk
            // 
            cmbMilk.FormattingEnabled = true;
            cmbMilk.Location = new Point(134, 162);
            cmbMilk.Name = "cmbMilk";
            cmbMilk.Size = new Size(236, 33);
            cmbMilk.TabIndex = 9;
            // 
            // chbHot
            // 
            chbHot.AutoSize = true;
            chbHot.Location = new Point(498, 162);
            chbHot.Name = "chbHot";
            chbHot.Size = new Size(68, 29);
            chbHot.TabIndex = 12;
            chbHot.Text = "Hot";
            chbHot.UseVisualStyleBackColor = true;
            // 
            // chbSugar
            // 
            chbSugar.AutoSize = true;
            chbSugar.Location = new Point(650, 162);
            chbSugar.Name = "chbSugar";
            chbSugar.Size = new Size(84, 29);
            chbSugar.TabIndex = 13;
            chbSugar.Text = "Sugar";
            chbSugar.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(258, 252);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Add Coffee";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDeleteCoffee
            // 
            btnDeleteCoffee.Location = new Point(419, 252);
            btnDeleteCoffee.Name = "btnDeleteCoffee";
            btnDeleteCoffee.Size = new Size(131, 34);
            btnDeleteCoffee.TabIndex = 15;
            btnDeleteCoffee.Text = "Delete Coffee";
            btnDeleteCoffee.UseVisualStyleBackColor = true;
            btnDeleteCoffee.Click += btnDeleteCoffee_Click;
            // 
            // CoffeeOrderGrid
            // 
            CoffeeOrderGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CoffeeOrderGrid.Location = new Point(37, 334);
            CoffeeOrderGrid.Name = "CoffeeOrderGrid";
            CoffeeOrderGrid.RowHeadersWidth = 62;
            CoffeeOrderGrid.Size = new Size(697, 276);
            CoffeeOrderGrid.TabIndex = 16;
            // 
            // CoffeeOrders
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 654);
            Controls.Add(CoffeeOrderGrid);
            Controls.Add(btnDeleteCoffee);
            Controls.Add(btnAdd);
            Controls.Add(chbSugar);
            Controls.Add(chbHot);
            Controls.Add(cmbMilk);
            Controls.Add(lblMilk);
            Controls.Add(cmbRoast);
            Controls.Add(lblRoast);
            Controls.Add(cmbSize);
            Controls.Add(lblSize);
            Controls.Add(txtPrice);
            Controls.Add(lblPrice);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Name = "CoffeeOrders";
            Text = "Coffee Orders";
            Load += CoffeeOrders_Load;
            ((System.ComponentModel.ISupportInitialize)CoffeeOrderGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Label lblName;
        private Label lblPrice;
        private TextBox txtPrice;
        private Label lblSize;
        private ComboBox cmbSize;
        private Label lblRoast;
        private ComboBox cmbRoast;
        private Label lblMilk;
        private ComboBox cmbMilk;
        private CheckBox chbHot;
        private CheckBox chbSugar;
        private Button btnAdd;
        private Button btnDeleteCoffee;
        private DataGridView CoffeeOrderGrid;
    }
}
