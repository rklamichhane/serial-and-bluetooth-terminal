using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace serial_communication
{

    public partial class Form1 : Form
    {
        SerialPort sp=new SerialPort();
        int[] BaudRates = new int[]{300, 1200, 2400, 4800, 9600, 14400, 19200, 28800, 38400, 57600, 115200, 230400};
        public Form1()
        {
            InitializeComponent();
          //  MessageBox.Show("hello");
            foreach (string str in SerialPort.GetPortNames())
            {
                COMlist.Items.Add(str);
                
            }
            foreach(int bd in BaudRates)
            {
                Baud_Rate.Items.Add(bd);
            }
            foreach(string ab  in Enum.GetNames(typeof(Parity)))
            {
                Parity_Bits.Items.Add(ab);

            }
            foreach (string ab in Enum.GetNames(typeof(StopBits)))
            {
                Stop_Bits.Items.Add(ab);

            }
            for(int i=5;i<=8;i++)
            {
                Data_Bits.Items.Add(i);
            }
            pnl.Text = pnl.Text + "NONE";
            brl.Text = brl.Text + serialPort1.BaudRate;
            dbl.Text = dbl.Text + serialPort1.DataBits;
            sbl.Text = sbl.Text + serialPort1.StopBits;
            pl.Text = pl.Text + serialPort1.Parity;



        }

        private void COM_list(object sender, PreviewKeyDownEventArgs e)
        {
            COMlist.DropDownStyle = ComboBoxStyle.DropDownList;
            //COMlist.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        private void setup_changed_mannual(object sender, EventArgs e)
        {
            var radioButton = sender as RadioButton;
            if (radioButton == null || !radioButton.Checked) return;


        }

        private void setup_changed_automatic(object sender, EventArgs e)
        {
            var radioButton = sender as RadioButton;
            if (radioButton == null || !radioButton.Checked) return;
        }


        private void setup_clicked(object sender, EventArgs e)
        {
            setup.ForeColor = Color.RosyBrown;
            setup.BackColor = Color.DarkSalmon;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void disable_key_press(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void port_name(object sender, EventArgs e)
        {
            serialPort1.PortName = COMlist.Text;
            pnl.Text = "current port"  + COMlist.Text;
        }

        private void text_updated_baud(object sender, EventArgs e)
        {
            try
            {

                if (System.Text.RegularExpressions.Regex.IsMatch(Baud_Rate.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter only numbers.");
                    if (Baud_Rate.Text.Length >= 1)
                        Baud_Rate.Text = "BAUD RATE";
                    return;
                }
                if (Baud_Rate.Text.Length <= 3)
                {
                    return;
                }
                else if (Convert.ToInt32(Baud_Rate.Text) >= 240400)
                {
                    Baud_Rate.Text = "230400";
                }
                serialPort1.BaudRate = Convert.ToInt32(Baud_Rate.Text);
                
                label_update1();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        public void label_update1()
        {
            brl.Text = "current baud rate=" + serialPort1.BaudRate;
            dbl.Text = "current data bits="+ serialPort1.DataBits;
            sbl.Text = "current stop bits=" + serialPort1.StopBits;
            pl.Text = "current parity=" + serialPort1.Parity;
        }
        private void label_update(object sender, EventArgs e)
        {
            label_update1();
           
        }

        private void data_bits_changed(object sender, EventArgs e)
        {
            serialPort1.DataBits=
        }
    }
}
