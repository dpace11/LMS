using LMS.DataModel;
using System.Data;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace LMS
{
    public partial class ReturnBook : Form
    {
        LmsDataModel datacontext = new();

        DateTime currentDateTime = DateTime.Now;

        string currentime = Convert.ToString(DateTime.Now);

        public ReturnBook()
        {
            InitializeComponent();
        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {
            panelBookReturnDetail.Visible = true;
            DataGridDefault();
        }

        void DataGridDefault()
        {

            var query = datacontext.IssueReturnBooks.
                Select(c => new { c.IRid, c.RollNo, c.Name, c.Book_Name, c.Book_Issue_Date, c.Book_Return_Date }).Where(d => d.Book_Return_Date == "n/a").ToList();
            gridBookDetails.DataSource = query;
        }

        private void txtRollNoReturn_TextChanged(object sender, EventArgs e)
        {
            if (txtNameReturn.Text != "")
            {
                var query = datacontext.IssueReturnBooks.Where(c => c.Name.Contains(txtNameReturn.Text) && c.Book_Return_Date == "n/a")
                    .Select(c => new { c.IRid, c.RollNo, c.Name, c.Book_Name, c.Book_Issue_Date, c.Book_Return_Date });


                gridBookDetails.DataSource = query.ToList();
            }
            else
            {
                DataGridDefault();
            }
        }

        private void gridBookDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        int id;
        private void gridBookDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panelBookReturnDetail.Visible = true;
            if (gridBookDetails.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                id = Convert.ToInt32(gridBookDetails.Rows[e.RowIndex].Cells[0].Value.ToString());
            }

            var bookreturnclick = datacontext.IssueReturnBooks.Where(c => c.IRid == id).FirstOrDefault();

            txtTxnId.Text = bookreturnclick.IRid.ToString();
            txtRollNo.Text = bookreturnclick.RollNo.ToString();
            txtName.Text = bookreturnclick.Name;
            txtBookName.Text = bookreturnclick.Book_Name;
            txtIssueDate.Text = bookreturnclick.Book_Issue_Date;
        }
        void clearfunc()
        {
            txtTxnId.Clear();
            txtRollNo.Clear();
            txtName.Clear();
            txtBookName.Clear();
            txtIssueDate.Clear();
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelBookReturnDetail.Visible = false;
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            string selectedbook = txtBookName.Text;

            var recordToUpdate = datacontext.IssueReturnBooks.Where(c => c.IRid == Convert.ToInt32(txtTxnId.Text)).FirstOrDefault();

            if (recordToUpdate != null)
            {
                recordToUpdate.Book_Return_Date = currentime;
                int a = datacontext.SaveChanges();

                int remqty = datacontext.Books.Where(b => b.BookName == selectedbook).Select(b => b.RemainingQuantity).FirstOrDefault();
                remqty = remqty + 1;

                var updatebookqty = datacontext.Books.Where(b => b.BookName == selectedbook);
                foreach (var r in updatebookqty)
                {
                    r.RemainingQuantity = remqty;
                }

                int b = datacontext.SaveChanges();

                if (a > 0 && b > 0)
                {
                    MessageBox.Show("book returned successfully!!!", "Return Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataGridDefault();
                    clearfunc();
                }

                else
                {
                    MessageBox.Show("book returned fail!!!", "Return Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            txtNameReturn.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelBookReturnDetail_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNameReturn.Clear();
            txtViewHistory.Clear();

        }

        private void txtViewHistory_TextChanged(object sender, EventArgs e)
        {
            string studenHistoryName = txtViewHistory.Text;
            if (studenHistoryName != "")
            {
                var searchhistory = datacontext.IssueReturnBooks.Where(c => c.Name.Contains(studenHistoryName))
                    .Select(c => new { c.IRid, c.RollNo, c.Name, c.Book_Name, c.Book_Issue_Date, c.Book_Return_Date });

                gridBookDetails.DataSource = searchhistory.ToList();

            }
            else
            {
                DataGridDefault();
            }
        }
    }
}