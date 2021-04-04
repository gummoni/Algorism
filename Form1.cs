using Algorism.Algorisms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var types = Assembly.GetExecutingAssembly().GetTypes().Where(_ => _.GetCustomAttribute<SampleAttribute>() != null).ToArray();
            listBox1.Items.Clear();
            listBox1.Items.AddRange(types);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var type = (Type)listBox1.SelectedItem;
                textBox1.Text = "";
                textBox1.Text = (string)type.GetMethod("Start").Invoke(null, null);
            }
            catch
            {
            }
        }
    }
}
