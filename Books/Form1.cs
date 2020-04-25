using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Books.Business;
using Books.Core;
using Dapper;

namespace Books
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        EntityState objState = EntityState.Unchanged;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                bookBindingSource.DataSource = BookService.GetAll();
                pContainer.Enabled = false;
            }
            //throwing an exception if not connected
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void ClearInput()  //reseting the text menus
        {
            txtBookName.Text = null;
            txtBookAuthor.Text = null;
            txtBookRepo.Text = null;
        }

        private void btnAdd_Click(object sender, EventArgs e) //Adding new book
        {
            objState = EntityState.Added;
            pContainer.Enabled = true;
            bookBindingSource.Add(new Book());
            bookBindingSource.MoveLast();  //new book is going at last place
            txtBookName.Focus();

        }

        private void btnCancel_Click(object sender, EventArgs e) //canceling operation
        {
            pContainer.Enabled = false;
            bookBindingSource.ResetBindings(false);
            ClearInput(); //calling clear method
            //this.Form1_Load(sender, e); //not losing information when canceling 
        }

        private void btnEdit_Click(object sender, EventArgs e)  //Update
        {
            objState = EntityState.Changed;
            pContainer.Enabled = true;  //we can change information when container is enabled
            txtBookName.Focus();
        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e) //when any part of cell is clicked
        {
        }

        private void btnDelete_Click(object sender, EventArgs e) //delete information
        {
            objState = EntityState.Deleted;
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure want to delete this record>", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                //sending a "Are you sure message ?"
            {
                try
                {
                    Book obj = bookBindingSource.Current as Book;
                    if (obj != null)
                    {
                        bool result = BookService.Delete(obj.bookID);
                        //executing delete operation
                        if (result) //deleting the book
                        {
                            bookBindingSource.RemoveCurrent();
                            pContainer.Enabled = false;
                            objState = EntityState.Unchanged;
                        }
                    }
                }
                //throwing an exception if not connected
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)  //save the changes
        {
            try
            {
                bookBindingSource.EndEdit();
                Book obj = bookBindingSource.Current as Book;
                if (obj != null)
                {
                    obj = BookService.Save(obj, objState);
                    //updating the data base
                    metroGrid1.Refresh();
                    pContainer.Enabled = false;
                    objState = EntityState.Unchanged;
                }
            }
            //throwing an exception if not connected
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void htmlLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
