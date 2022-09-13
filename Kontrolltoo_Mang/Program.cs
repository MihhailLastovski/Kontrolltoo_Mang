using Kontrolltoo_Mang;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

UTF8Encoding utf8 = new UTF8Encoding();
List <Ese> items_ = new List<Ese> ();
StreamReader from_file = new StreamReader(@"..\..\..\esemed.txt");

Tegelane qwe = new Tegelane("bender");

qwe.punktideArv_(items_,from_file);
qwe.issueItems(items_, qwe.addItem(0));
qwe.info();

