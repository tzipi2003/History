namespace History
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
             {
            try
            {
                dataGridView1.DataSource = new BL.EventsBL().GetAllData();

            }
            catch (Exception)
            {
                MessageBox.Show("ארעה שגיאה בשליפת הנתונים");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BL.EventsBL bl=new BL.EventsBL();
            DAL.DbModels.HistoryEvent _event=new();

            _event.Eyear =Convert.ToInt32( numericUpDown1.Value);
            _event.EventDate = dateTimePicker1.Value ;
            _event.TiteleEvent = textTitle.Text;
            _event.CountryId = Convert.ToInt32(numericUpDown2.Value);
            _event.Edescription = textDescripion.Text;
            _event.Ecity=texteventCity.Text;    
            bool b=bl.SavenewEvent(_event );
            MessageBox.Show("הנתונים נשמרו בהצלחה");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textCountryId_TextChanged(object sender, EventArgs e)
        {

        }

        private void textDescripion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}