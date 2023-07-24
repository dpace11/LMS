using LMS.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class ViewBook : Form
    {
        LmsDataModel datacontext = new();
        Book b = new();
        public ViewBook()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void ViewBook_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            GridViewDefault();
        }

        public void clearfunc()
        {
            txtBookName.Clear();
            txtAuthorName.Clear();
            txtPublicationName.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
            txtLocation.Clear();
            txtRemQuanity.Clear();

        }
        void GridViewDefault()
        {
            var query = from b in datacontext.Books
                        select new
                        {
                            b.BookId,
                            b.BookName,
                            b.AuthorName,
                            b.PublicationName,
                            b.Price,
                            b.PurchaseDate,
                            b.Quantity,
                            b.BookLocation,
                            b.RemainingQuantity
                        };

            var result = query.ToList();
            gridViewBook.DataSource = result;
        }

        int bid;
        private void gridViewBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel2.Visible = true;
            if (gridViewBook.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = Convert.ToInt32(gridViewBook.Rows[e.RowIndex].Cells[0].Value.ToString());
            }

            var bookclick = datacontext.Books.Where(c => c.BookId == bid).FirstOrDefault();

            txtBookName.Text = bookclick.BookName;
            txtAuthorName.Text = bookclick.AuthorName;
            txtPublicationName.Text = bookclick.PublicationName;
            txtPrice.Text = bookclick.Price.ToString();
            //datePurchaseDate.Value = bookclick.PurchaseDate;
            txtQuantity.Text = bookclick.Quantity.ToString();
            txtLocation.Text = bookclick.BookLocation;
            txtRemQuanity.Text = bookclick.RemainingQuantity.ToString();


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtBookName.Text != "" && txtAuthorName.Text != "" && txtPublicationName.Text != "" && txtPrice.Text != "" && txtQuantity.Text != "" && txtLocation.Text != "" && txtRemQuanity.Text != "")
            {
                int bookId = bid;

                var ex = datacontext.Books.Where(b => b.BookId == bookId).FirstOrDefault();
                if (ex != null)
                {   
                    ex.BookName = txtBookName.Text;
                    ex.AuthorName = txtAuthorName.Text;
                    ex.PublicationName = txtPublicationName.Text;
                    ex.Price = Convert.ToInt32(txtPrice.Text);
                    ex.Quantity = Convert.ToInt32(txtQuantity.Text);
                    ex.BookLocation = txtLocation.Text;
                    ex.RemainingQuantity = Convert.ToInt32(txtRemQuanity.Text);

                    datacontext.SaveChanges();
                    MessageBox.Show("Data Updated Successfully!", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GridViewDefault();
                    clearfunc();
                }
                else
                {
                    MessageBox.Show("Book with ID " + bookId + " not found.", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Cannot enter empty field", "Empty Field Encountered", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("do you want to delete data", "delete alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                var bookdelete = datacontext.Books.Where(c => c.BookId == bid).FirstOrDefault();
                datacontext.Remove(bookdelete);
                int a = datacontext.SaveChanges();

                if (a > 0)
                {
                    MessageBox.Show("data deleted successfully!!!", "Delete Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GridViewDefault();
                    clearfunc();
                }

                else
                {
                    MessageBox.Show("data deletion fail!!!", "Delete Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("you chose no");
            }
        }

        private void txtBookSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtBookSearch.Text != "")
            {
                var query = datacontext.Books.Where(b => b.BookName.Contains(txtBookSearch.Text)).ToList();
                gridViewBook.DataSource = query;
            }
            else
            {
                GridViewDefault();
            }

        }

        private void gridViewBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearchRefresh_Click(object sender, EventArgs e)
        {
            txtBookSearch.Clear();
        }
    }
}
