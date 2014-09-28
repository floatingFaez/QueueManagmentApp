using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueueManagmentAppForm
{
    public partial class CustomerQueueManagmentForm : Form
    {
        public CustomerQueueManagmentForm()
        {
            InitializeComponent();
        }

        Queue<Complain> serviceQueue = new Queue<Complain>();
        int counter = 0;

        private void enqueueButton_Click(object sender, EventArgs e)
        {
            if (enqueeNameTextBox.Text != string.Empty && enqueeComplainTextBox.Text != string.Empty)
            {
                Complain aComplain = new Complain();
                aComplain.Serial = Convert.ToString(++counter);
                aComplain.Name = enqueeNameTextBox.Text;
                aComplain.NewComplain = enqueeComplainTextBox.Text;

                serviceQueue.Enqueue(aComplain);

                enqueeNameTextBox.Text = string.Empty;
                enqueeComplainTextBox.Text = string.Empty;

                ListViewItem lvi = new ListViewItem(aComplain.Serial);
                lvi.SubItems.Add(aComplain.Name);
                lvi.SubItems.Add(aComplain.NewComplain);

                queueListView.Items.Add(lvi);

                MessageBox.Show(aComplain.Name + "'s serial number is " + aComplain.Serial);
            }
            else
                MessageBox.Show("Eneter name and complain field");
        }

        private void dequeueButton_Click(object sender, EventArgs e)
        {
            if (queueListView.Items.Count != 0)
            {
                Complain bComplain = serviceQueue.Dequeue();
                serialNoTextBox.Text = bComplain.Serial;
                dequeeNameTextBox.Text = bComplain.Name;
                dequeeComplainTextBox.Text = bComplain.NewComplain;
                queueListView.Items.RemoveAt(0);
            }
            else
            {
                MessageBox.Show("There is no any item in service queue");
            }
        }
    }
}
