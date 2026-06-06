namespace Kakeibo2App.Pages
{
    partial class ExpensePage
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private TextBox txtTitle;

        private Label lblCategory;
        private ComboBox cmbCategory;

        private Label lblAmount;
        private NumericUpDown numAmount;

        private Label lblMemo;
        private TextBox txtMemo;

        private Label lblDate;
        private DateTimePicker dtpDate;

        private Button btnAdd;

        private DataGridView dgvExpense;

        private Button btnPrevPage;
        private Button btnNextPage;
        private Label lblPage;

        protected override void Dispose(bool disposing)
        {
            if (disposing &&
                (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            txtTitle = new TextBox();
            lblCategory = new Label();
            cmbCategory = new ComboBox();
            lblAmount = new Label();
            numAmount = new NumericUpDown();
            lblMemo = new Label();
            txtMemo = new TextBox();
            lblDate = new Label();
            dtpDate = new DateTimePicker();
            btnAdd = new Button();
            dgvExpense = new DataGridView();
            btnPrevPage = new Button();
            btnNextPage = new Button();
            lblPage = new Label();
            ((System.ComponentModel.ISupportInitialize)numAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvExpense).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(100, 23);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "タイトル";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(20, 45);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(180, 23);
            txtTitle.TabIndex = 1;
            // 
            // lblCategory
            // 
            lblCategory.Location = new Point(220, 20);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(100, 23);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "カテゴリ";
            // 
            // cmbCategory
            // 
            cmbCategory.Location = new Point(220, 45);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(150, 23);
            cmbCategory.TabIndex = 3;
            // 
            // lblAmount
            // 
            lblAmount.Location = new Point(390, 20);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(100, 23);
            lblAmount.TabIndex = 4;
            lblAmount.Text = "金額";
            // 
            // numAmount
            // 
            numAmount.Location = new Point(390, 45);
            numAmount.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numAmount.Name = "numAmount";
            numAmount.Size = new Size(120, 23);
            numAmount.TabIndex = 5;
            // 
            // lblMemo
            // 
            lblMemo.Location = new Point(560, 20);
            lblMemo.Name = "lblMemo";
            lblMemo.Size = new Size(100, 23);
            lblMemo.TabIndex = 6;
            lblMemo.Text = "メモ";
            // 
            // txtMemo
            // 
            txtMemo.Location = new Point(560, 45);
            txtMemo.Name = "txtMemo";
            txtMemo.Size = new Size(250, 23);
            txtMemo.TabIndex = 7;
            // 
            // lblDate
            // 
            lblDate.Location = new Point(830, 20);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(100, 23);
            lblDate.TabIndex = 8;
            lblDate.Text = "日付";
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(830, 45);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 23);
            dtpDate.TabIndex = 9;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1060, 40);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 35);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "追加";
            // 
            // dgvExpense
            // 
            dgvExpense.AllowUserToAddRows = false;
            dgvExpense.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvExpense.Location = new Point(20, 110);
            dgvExpense.Name = "dgvExpense";
            dgvExpense.ReadOnly = true;
            dgvExpense.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvExpense.Size = new Size(1200, 275);
            dgvExpense.TabIndex = 11;
            // 
            // btnPrevPage
            // 
            btnPrevPage.Location = new Point(900, 405);
            btnPrevPage.Name = "btnPrevPage";
            btnPrevPage.Size = new Size(75, 23);
            btnPrevPage.TabIndex = 12;
            btnPrevPage.Text = "前へ";
            // 
            // btnNextPage
            // 
            btnNextPage.Location = new Point(1080, 405);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(75, 23);
            btnNextPage.TabIndex = 14;
            btnNextPage.Text = "次へ";
            // 
            // lblPage
            // 
            lblPage.AutoSize = true;
            lblPage.Location = new Point(1020, 413);
            lblPage.Name = "lblPage";
            lblPage.Size = new Size(30, 15);
            lblPage.TabIndex = 13;
            lblPage.Text = "1 / 1";
            // 
            // ExpensePage
            // 
            Controls.Add(lblTitle);
            Controls.Add(txtTitle);
            Controls.Add(lblCategory);
            Controls.Add(cmbCategory);
            Controls.Add(lblAmount);
            Controls.Add(numAmount);
            Controls.Add(lblMemo);
            Controls.Add(txtMemo);
            Controls.Add(lblDate);
            Controls.Add(dtpDate);
            Controls.Add(btnAdd);
            Controls.Add(dgvExpense);
            Controls.Add(btnPrevPage);
            Controls.Add(lblPage);
            Controls.Add(btnNextPage);
            Name = "ExpensePage";
            Size = new Size(1400, 900);
            ((System.ComponentModel.ISupportInitialize)numAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvExpense).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}