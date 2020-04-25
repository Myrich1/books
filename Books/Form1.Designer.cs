namespace Books
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.bookIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookAuthorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookRepositoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pContainer = new MetroFramework.Controls.MetroPanel();
            this.htmlLabel3 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.htmlLabel4 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.htmlLabel2 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.txtBookRepo = new MetroFramework.Controls.MetroTextBox();
            this.txtBookAuthor = new MetroFramework.Controls.MetroTextBox();
            this.txtBookName = new MetroFramework.Controls.MetroTextBox();
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.txtBookID = new MetroFramework.Controls.MetroTextBox();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.pContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookIDDataGridViewTextBoxColumn,
            this.bookNameDataGridViewTextBoxColumn,
            this.bookAuthorDataGridViewTextBoxColumn,
            this.bookRepositoryDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.bookBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(24, 89);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidth = 62;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.RowTemplate.Height = 28;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(443, 317);
            this.metroGrid1.TabIndex = 0;
            this.metroGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellClick);
            // 
            // bookIDDataGridViewTextBoxColumn
            // 
            this.bookIDDataGridViewTextBoxColumn.DataPropertyName = "bookID";
            this.bookIDDataGridViewTextBoxColumn.HeaderText = "bookID";
            this.bookIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bookIDDataGridViewTextBoxColumn.Name = "bookIDDataGridViewTextBoxColumn";
            this.bookIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // bookNameDataGridViewTextBoxColumn
            // 
            this.bookNameDataGridViewTextBoxColumn.DataPropertyName = "bookName";
            this.bookNameDataGridViewTextBoxColumn.HeaderText = "bookName";
            this.bookNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bookNameDataGridViewTextBoxColumn.Name = "bookNameDataGridViewTextBoxColumn";
            this.bookNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // bookAuthorDataGridViewTextBoxColumn
            // 
            this.bookAuthorDataGridViewTextBoxColumn.DataPropertyName = "bookAuthor";
            this.bookAuthorDataGridViewTextBoxColumn.HeaderText = "bookAuthor";
            this.bookAuthorDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bookAuthorDataGridViewTextBoxColumn.Name = "bookAuthorDataGridViewTextBoxColumn";
            this.bookAuthorDataGridViewTextBoxColumn.Width = 150;
            // 
            // bookRepositoryDataGridViewTextBoxColumn
            // 
            this.bookRepositoryDataGridViewTextBoxColumn.DataPropertyName = "bookRepository";
            this.bookRepositoryDataGridViewTextBoxColumn.HeaderText = "bookRepository";
            this.bookRepositoryDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bookRepositoryDataGridViewTextBoxColumn.Name = "bookRepositoryDataGridViewTextBoxColumn";
            this.bookRepositoryDataGridViewTextBoxColumn.Width = 150;
            // 
            // bookBindingSource
            this.bookBindingSource.DataSource = typeof(Books.Core.Book);
            // 
            // 
            // pContainer
            // 
            this.pContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pContainer.Controls.Add(this.htmlLabel3);
            this.pContainer.Controls.Add(this.htmlLabel4);
            this.pContainer.Controls.Add(this.htmlLabel2);
            this.pContainer.Controls.Add(this.txtBookRepo);
            this.pContainer.Controls.Add(this.txtBookAuthor);
            this.pContainer.Controls.Add(this.txtBookName);
            this.pContainer.Controls.Add(this.htmlLabel1);
            this.pContainer.Controls.Add(this.txtBookID);
            this.pContainer.HorizontalScrollbarBarColor = true;
            this.pContainer.HorizontalScrollbarHighlightOnWheel = false;
            this.pContainer.HorizontalScrollbarSize = 10;
            this.pContainer.Location = new System.Drawing.Point(469, 89);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(456, 317);
            this.pContainer.TabIndex = 1;
            this.pContainer.VerticalScrollbarBarColor = true;
            this.pContainer.VerticalScrollbarHighlightOnWheel = false;
            this.pContainer.VerticalScrollbarSize = 10;
            // 
            // htmlLabel3
            // 
            this.htmlLabel3.AutoScroll = true;
            this.htmlLabel3.AutoScrollMinSize = new System.Drawing.Size(92, 29);
            this.htmlLabel3.AutoSize = false;
            this.htmlLabel3.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel3.Location = new System.Drawing.Point(3, 152);
            this.htmlLabel3.Name = "htmlLabel3";
            this.htmlLabel3.Size = new System.Drawing.Size(165, 34);
            this.htmlLabel3.TabIndex = 4;
            this.htmlLabel3.Text = "bookAuthor";
            // 
            // htmlLabel4
            // 
            this.htmlLabel4.AutoScroll = true;
            this.htmlLabel4.AutoScrollMinSize = new System.Drawing.Size(88, 29);
            this.htmlLabel4.AutoSize = false;
            this.htmlLabel4.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel4.Location = new System.Drawing.Point(3, 91);
            this.htmlLabel4.Name = "htmlLabel4";
            this.htmlLabel4.Size = new System.Drawing.Size(165, 34);
            this.htmlLabel4.TabIndex = 4;
            this.htmlLabel4.Text = "bookName";
            // 
            // htmlLabel2
            // 
            this.htmlLabel2.AutoScroll = true;
            this.htmlLabel2.AutoScrollMinSize = new System.Drawing.Size(122, 29);
            this.htmlLabel2.AutoSize = false;
            this.htmlLabel2.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel2.Location = new System.Drawing.Point(3, 219);
            this.htmlLabel2.Name = "htmlLabel2";
            this.htmlLabel2.Size = new System.Drawing.Size(193, 34);
            this.htmlLabel2.TabIndex = 7;
            this.htmlLabel2.Text = "bookRepository";
            // 
            // txtBookRepo
            // 
            // 
            // 
            // 
            this.txtBookRepo.CustomButton.Image = null;
            this.txtBookRepo.CustomButton.Location = new System.Drawing.Point(183, 2);
            this.txtBookRepo.CustomButton.Name = "";
            this.txtBookRepo.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtBookRepo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBookRepo.CustomButton.TabIndex = 1;
            this.txtBookRepo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBookRepo.CustomButton.UseSelectable = true;
            this.txtBookRepo.CustomButton.Visible = false;
            this.txtBookRepo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "bookRepository", true));
            this.txtBookRepo.Lines = new string[0];
            this.txtBookRepo.Location = new System.Drawing.Point(202, 219);
            this.txtBookRepo.MaxLength = 32767;
            this.txtBookRepo.Name = "txtBookRepo";
            this.txtBookRepo.PasswordChar = '\0';
            this.txtBookRepo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBookRepo.SelectedText = "";
            this.txtBookRepo.SelectionLength = 0;
            this.txtBookRepo.SelectionStart = 0;
            this.txtBookRepo.ShortcutsEnabled = true;
            this.txtBookRepo.Size = new System.Drawing.Size(215, 34);
            this.txtBookRepo.TabIndex = 6;
            this.txtBookRepo.UseSelectable = true;
            this.txtBookRepo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBookRepo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtBookAuthor
            // 
            // 
            // 
            // 
            this.txtBookAuthor.CustomButton.Image = null;
            this.txtBookAuthor.CustomButton.Location = new System.Drawing.Point(183, 2);
            this.txtBookAuthor.CustomButton.Name = "";
            this.txtBookAuthor.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtBookAuthor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBookAuthor.CustomButton.TabIndex = 1;
            this.txtBookAuthor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBookAuthor.CustomButton.UseSelectable = true;
            this.txtBookAuthor.CustomButton.Visible = false;
            this.txtBookAuthor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "bookAuthor", true));
            this.txtBookAuthor.Lines = new string[0];
            this.txtBookAuthor.Location = new System.Drawing.Point(202, 152);
            this.txtBookAuthor.MaxLength = 32767;
            this.txtBookAuthor.Name = "txtBookAuthor";
            this.txtBookAuthor.PasswordChar = '\0';
            this.txtBookAuthor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBookAuthor.SelectedText = "";
            this.txtBookAuthor.SelectionLength = 0;
            this.txtBookAuthor.SelectionStart = 0;
            this.txtBookAuthor.ShortcutsEnabled = true;
            this.txtBookAuthor.Size = new System.Drawing.Size(215, 34);
            this.txtBookAuthor.TabIndex = 5;
            this.txtBookAuthor.UseSelectable = true;
            this.txtBookAuthor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBookAuthor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtBookName
            // 
            // 
            // 
            // 
            this.txtBookName.CustomButton.Image = null;
            this.txtBookName.CustomButton.Location = new System.Drawing.Point(183, 2);
            this.txtBookName.CustomButton.Name = "";
            this.txtBookName.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtBookName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBookName.CustomButton.TabIndex = 1;
            this.txtBookName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBookName.CustomButton.UseSelectable = true;
            this.txtBookName.CustomButton.Visible = false;
            this.txtBookName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "bookName", true));
            this.txtBookName.Lines = new string[0];
            this.txtBookName.Location = new System.Drawing.Point(202, 91);
            this.txtBookName.MaxLength = 32767;
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.PasswordChar = '\0';
            this.txtBookName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBookName.SelectedText = "";
            this.txtBookName.SelectionLength = 0;
            this.txtBookName.SelectionStart = 0;
            this.txtBookName.ShortcutsEnabled = true;
            this.txtBookName.Size = new System.Drawing.Size(215, 34);
            this.txtBookName.TabIndex = 4;
            this.txtBookName.UseSelectable = true;
            this.txtBookName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBookName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(61, 29);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel1.Location = new System.Drawing.Point(3, 24);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(165, 34);
            this.htmlLabel1.TabIndex = 3;
            this.htmlLabel1.Text = "bookID";
            this.htmlLabel1.Click += new System.EventHandler(this.htmlLabel1_Click);
            // 
            // txtBookID
            // 
            // 
            // 
            // 
            this.txtBookID.CustomButton.Image = null;
            this.txtBookID.CustomButton.Location = new System.Drawing.Point(183, 2);
            this.txtBookID.CustomButton.Name = "";
            this.txtBookID.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtBookID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBookID.CustomButton.TabIndex = 1;
            this.txtBookID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBookID.CustomButton.UseSelectable = true;
            this.txtBookID.CustomButton.Visible = false;
            this.txtBookID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "bookID", true));
            this.txtBookID.Lines = new string[0];
            this.txtBookID.Location = new System.Drawing.Point(202, 24);
            this.txtBookID.MaxLength = 32767;
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.PasswordChar = '\0';
            this.txtBookID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBookID.SelectedText = "";
            this.txtBookID.SelectionLength = 0;
            this.txtBookID.SelectionStart = 0;
            this.txtBookID.ShortcutsEnabled = true;
            this.txtBookID.Size = new System.Drawing.Size(215, 34);
            this.txtBookID.TabIndex = 2;
            this.txtBookID.UseSelectable = true;
            this.txtBookID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBookID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(469, 434);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(751, 434);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(657, 434);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(563, 434);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseSelectable = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(850, 434);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 552);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pContainer);
            this.Controls.Add(this.metroGrid1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.pContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroPanel pContainer;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel3;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel4;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel2;
        private MetroFramework.Controls.MetroTextBox txtBookRepo;
        private MetroFramework.Controls.MetroTextBox txtBookAuthor;
        private MetroFramework.Controls.MetroTextBox txtBookName;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        private MetroFramework.Controls.MetroTextBox txtBookID;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookAuthorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookRepositoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private MetroFramework.Controls.MetroButton btnSave;
    }
}

