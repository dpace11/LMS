using LMS.DataModel;

namespace LMS
{
    public partial class AddBooks : Form
    {
        LmsDataModel datacontext = new();
        Book book = new();
        public AddBooks()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void clearfunc()
        {

            txtBookName.Clear();
            txtAuthorName.Clear();
            txtPublicationName.Clear();
            txtPrice.Clear();
            //dateBookPurchase.Value = null;
            txtBookQuantity.Clear();
            txtRemQuantity.Clear();
            txtBookLoaction.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBookName.Text != null && txtAuthorName.Text != null && txtPublicationName.Text != null && txtPrice.Text != null && dateBookPurchase.Text != null && txtBookQuantity.Text != null && txtBookLoaction.Text != null && txtRemQuantity.Text != null)
            {
                Book newbook = new()
                {
                    BookName = txtBookName.Text,
                    AuthorName = txtAuthorName.Text,
                    PublicationName = txtPublicationName.Text,
                    Price = Convert.ToInt32(txtPrice.Text),
                    // PurchaseDate = dateBookPurchase.Text,

                    PurchaseDate = dateBookPurchase.Value.ToString(), // Correctly accessing the selected date value


                    Quantity = Convert.ToInt32(txtBookQuantity.Text),
                    BookLocation = txtBookLoaction.Text,
                    RemainingQuantity = Convert.ToInt32(txtRemQuantity.Text)

                };

                bool ispresent = datacontext.Books.Any(item => item.BookName == newbook.BookName);
                if (ispresent)
                {
                    MessageBox.Show("Book Name Already Present In Database.... Go to View Book Section", "Book Name Conflict", MessageBoxButtons.OK);
                }

                else
                {
                    datacontext.Books.Add(newbook);
                    int a = datacontext.SaveChanges();

                    if (a > 0)
                    {
                        MessageBox.Show("data inserted successfully!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearfunc();
                    }
                }

            }

            else
            {
                MessageBox.Show("Invalid Input- Input Field cannot be empty", "Book Entry Fail", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            clearfunc();
        }
    }
}
