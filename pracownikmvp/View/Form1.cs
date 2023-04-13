using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace pracownik.View
{
	public partial class Form1 : Form
	{
        public event Action <string,string,DateTime,int,string,string> SendData;
        public event Action <ArrayList> SaveData;
        public event Action WczytajData;
        public string DisplayText
        {
            set
            {
                errorProvider_puste.Clear();
                listBox_lista.Items.Add(value);
            }
            get
            {
                return listBox_lista.Items.ToString();
            }
        }
        public Form1()
		{
			InitializeComponent();
		}
        public void ShowError(string nazwa)
        {
            if (nazwa == "imie")
            {
                errorProvider_puste.SetError(textBox_imie, "To pole jest wymagane");
            }
            else if(nazwa=="nazwisko")
            {
                errorProvider_puste.SetError(textBox_nazwisko, "To pole jest wymagane");

            }else if(nazwa== "stanowisko")
            {
                errorProvider_puste.SetError(comboBox_Stanowisko, "To pole jest wymagane");
            }
            else
            {
                errorProvider_puste.Clear();
            }
        }
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

        private void listBox_lista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_wyslij_Click(object sender, EventArgs e)
        {
            string czy="";
            if (radioButton_tak.Checked)
            {
                czy = "umowa na czas nie określony";
            }
            if (radioButton_nie.Checked)
            {
                czy = "umowa na czas określony";
            }
            if (radioButton_niewiem.Checked)
            {
                czy = "umowa na zlecenie";
            }
            SendData?.Invoke(textBox_imie.Text,textBox_nazwisko.Text,dateTimePicker_urodz.Value, (int)numericUpDown_saropki.Value,comboBox_Stanowisko.Text, czy);
        }

        private void radioButton_tak_Click(object sender, EventArgs e)
        {

        }
        private void button_Zapisz_Click(object sender, EventArgs e)
        {
            ArrayList list = new ArrayList();
            foreach (var item in listBox_lista.Items)
            {
                list.Add(item);
            }
            SaveData?.Invoke(list/*listBox_lista.Items*/);
            /*  XmlSerializer serializer = new XmlSerializer(typeof(ICollection));
              FileStream stream = new FileStream("plik.xml", FileMode.Create);*/
        }

        private void button_wczytaj_Click(object sender, EventArgs e)
        {
            WczytajData?.Invoke();
        }
        public void AddToItemmBox(ArrayList lista)
        {
            if (lista.Count > 0)
            {
                foreach(var  item in lista)
                {
                    listBox_lista.Items.Add(item.ToString());
                }
            }
        }
    }
}
