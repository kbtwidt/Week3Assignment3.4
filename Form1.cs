namespace Week3Assignment3._4
{
    public partial class CoffeeOrders : Form
    {
        public CoffeeOrders()
        {
            InitializeComponent();
        }

        private void CoffeeOrders_Load(object sender, EventArgs e)
        {
            CoffeeOrderGrid.DataSource = Data.coffeeList;
            cmbSize.DataSource = Enum.GetValues(typeof(SizeCoffee));
            cmbRoast.DataSource = Enum.GetValues(typeof(Roast));
            cmbMilk.DataSource = Enum.GetValues(typeof(Milk));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("Please enter a coffee name.");
                return;
            }
            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Please enter a valid price.");
                return;
            }
            var newCoffee = new Coffee();
            newCoffee.Name = txtName.Text;
            newCoffee.Price = price;
            newCoffee.Size = cmbSize.Text;
            newCoffee.Roast = cmbRoast.Text;
            newCoffee.MilkType = cmbMilk.Text;
            newCoffee.IsHot = chbHot.Checked;
            newCoffee.HasSugar = chbSugar.Checked;
            Data.coffeeList.Add(newCoffee);

            CoffeeOrderGrid.DataSource = null;
            CoffeeOrderGrid.DataSource = Data.coffeeList;
            txtName.Clear();
            txtPrice.Clear();
        }

        private void btnDeleteCoffee_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete this Coffee Order?", "Warning!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Data.coffeeList.RemoveAt(CoffeeOrderGrid.CurrentRow.Index);
                CoffeeOrderGrid.DataSource = null;
                CoffeeOrderGrid.DataSource= Data.coffeeList;
            }
        }
    }
}
