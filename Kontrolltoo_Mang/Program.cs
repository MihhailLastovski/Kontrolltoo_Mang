using Kontrolltoo_Mang;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

UTF8Encoding utf8 = new UTF8Encoding();
List <Ese> items_ = new List<Ese> ();
StreamReader from_file = new StreamReader(@"..\..\..\esemed.txt");
string text;
while ((text = from_file.ReadLine()) != null)
{
    string[] values = text.Split(';');
    items_.Add(new Ese(values[0], int.Parse(values[1])));
}

from_file.Close();
Tegelane qwe = new Tegelane("bender");

qwe.punktideArv_(items_);
qwe.issueItems(items_, qwe.addItem(0));
qwe.info();

