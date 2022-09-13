using Kontrolltoo_Mang;
using System.Text;

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
Tegelane qwe = new Tegelane("Stratos");
Tegelane asd = new Tegelane("Nebula");

qwe.issueItems(items_, qwe.addItem(1));
qwe.punktideArv();
qwe.info();
asd.issueItems(items_, asd.addItem(2));
asd.punktideArv();
asd.info();

