using AbstractClass.BL;

namespace AbstractClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddMessage(string message)
        {
            string newLine = message;
            newLine += Environment.NewLine;
            txtDisplay.Text += newLine;
        }

        private void btnTestAbstractClass_Click(object sender, EventArgs e)
        {
            List<DataAccess> dbs = new List<DataAccess>()
            {
                new SQLServer(),
                new MySQL(),
            };

            foreach (var db in dbs)
            {
                AddMessage(db.Connecting("10.0.0.1"));
                AddMessage(db.GettingData());
                AddMessage(db.SavingData());
            }
        }
    }
}