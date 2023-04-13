
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace pracownik.Presenter
{
	internal class MainPresenter
	{
		private View.Form1 _view;
		private Model.MainModel _model;
		private string result;
		public MainPresenter(View.Form1 view,Model.MainModel model)
		{
            _view = view;
            _model = model;

            /*UpdateView();*/
            _view.SaveData += _view_SaveData;
            _view.SendData += _view_SendData;
            _view.WczytajData += _view_WczytajData;
            
        }

        private void _view_WczytajData()
        {
            ArrayList list = new ArrayList();
            XmlSerializer serializer = new XmlSerializer(typeof(ArrayList));
            using (StreamReader reader = new StreamReader("plik.xml"))
            {
                list = (ArrayList)serializer.Deserialize(reader);
            }
            _view.AddToItemmBox(list);
        }

        private void UpdateView() => _view.DisplayText = _model.Fromat();
		private void DetectedError(string nazwa) {
			_view.ShowError(nazwa);
		}
		private void _view_SaveData(ArrayList list)
		{

            XmlSerializer serializer = new XmlSerializer(typeof(ArrayList));
/*			var i = Directory.GetCurrentDirectory();
			var k = i;*/
            FileStream stream = new FileStream("~plik.xml", FileMode.Create);

            serializer.Serialize(stream, list);

            stream.Close();
        }
		private void _view_SendData(string imie, string nazwisko, DateTime dt, int zarobki, string RadioBox, string Stanowisko)
		{
			_model.Dopis(imie, nazwisko, dt, zarobki, RadioBox, Stanowisko);
			string text=_model.Test();
			if (text == "nic")
            {
                _model.Fromat();
                UpdateView();
            }
			else
			{
				DetectedError(text);
            } 
        }
    }
}
