namespace Lab004_653450279_6
{
    public partial class Form1 : Form
    {
        Classroom classroom;
        public Form1()
        {
            List<double> GPAlist = new List<double>();
            InitializeComponent();
            classroom = new Classroom("OOP");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string input_name = this.Name.Text;
            string input_year = this.BY.Text;
            string input_gpa = this.GetgpatextBox.Text;
            int iYear = Int32.Parse(input_year);

            Person person = new Person(input_name, iYear);
            this.classroom.addPerson2Class(person);

            this.tbListofPerson.Text =
                this.classroom.showAllPersoninClass();

            this.tbTotal.Text = "";
        }
    }
}