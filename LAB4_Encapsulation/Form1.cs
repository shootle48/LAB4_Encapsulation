using System.Xml.Linq;

namespace LAB4_Encapsulation
{
    public partial class Form1 : Form
    {
        Classroom classroom;
        public Form1()
        {
            InitializeComponent();
            classroom = new Classroom("OOP");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textName.Text;
            string bYear = textbYear.Text;
            string gpa = textGPA.Text;
            int ibYear = Int32.Parse(bYear);
            double iGpa = double.Parse(gpa);

            Person newPerson = new Person(name, ibYear, iGpa);

            /*this.textList.Text += newPerson.getName()+"\r\n";
            int currentAge = Int32.Parse(this.labelTotal.Text);
            int newTotal = currentAge + newPerson.getAge();
            this.labelTotal.Text = newTotal.ToString();*/

            this.classroom.addPersonToClass(newPerson);
            this.classroom.addGPAToClass();
            this.textList.Text = this.classroom.showAllPersoninClass();

            int currentAge = Int32.Parse(this.labelTotal.Text);
            int newTotal = currentAge + this.classroom.showTotalAgeinClass();
            this.labelTotal.Text = newTotal.ToString();

            double newMax = this.classroom.showGPXMax();
            this.labelMax.Text = newMax.ToString();

            double newMin = this.classroom.showGPXMin();
            this.labelMin.Text = newMin.ToString();

            double newAvg = this.classroom.showGPXAvg();
            this.labelAvg.Text = newAvg.ToString("N2");

            this.textMax.Text = this.classroom.showNameMax();
            this.textMin.Text = this.classroom.showNameMin();
        }
    }
}