using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace History
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

      
      
        private void Form2_Load(object sender, EventArgs e)
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

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }
    }
}
