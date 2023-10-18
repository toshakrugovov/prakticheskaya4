

zametka zam1 = new zametka();
zametka zam2 = new zametka();
zametka zam3 = new zametka();
zametka zam4 = new zametka();
zametka zam5 = new zametka();
zametka[] zam = new zametka[5];


int position = 0;
int data = 1;
text_zametki();
hod_strelki();
data1();
ConsoleKeyInfo key;
do
{

    naznachenie();
    if (key.Key == ConsoleKey.Enter)
    {
        nalichie();
    }
    else
    {
        hod_strelki();
        data1();
    }
}
while (key.Key != ConsoleKey.Escape);



void text_zametki()
{
    zam1.nazvanie1 = "Сон на выходных.";
    zam1.opisanie1 = "Можно поспать до 9, так как на учебу идти не надо!";
    zam1.nazvanie2 = "Приготовить ужин";
    zam1.opisanie2 = "На ужин надо купить курицу и почистить картошечку \n" +
                     "                      А также запечь в духовке с сырком";
    zam[0] = zam1;
    zam2.nazvanie1 = "Посмотреть лекции";
    zam2.opisanie1 = "Зайти в классрум и посмотреть лекции";
    zam2.nazvanie2 = "Погулять в центре";
    zam2.opisanie2 = "Съездить на Арбат и погулять с другом";
    zam[1] = zam2;
    zam3.nazvanie1 = "Идти на пары";
    zam3.opisanie1 = "К 8-30 я должен успеть на пары";
    zam3.nazvanie2 = "Поспать после учёбы";
    zam3.opisanie2 = "Прийти домой покушать и поспать";
    zam[2] = zam3;
    zam4.nazvanie1 = "Посмотреть фильм";
    zam4.opisanie1 = "Прийти домой и посмотреть какие-нибудь сваты, в каком-нибудь ютубе";
    zam4.nazvanie2 = "Вынести мусор";
    zam4.opisanie2 = "Вынести мусор или получу от мамы бан";
    zam[3] = zam4;
    zam5.nazvanie1 = "Сделать практическую работу";
    zam5.opisanie1 = "Выполнить практическую работу, иначе ещё отчислят ";
    zam5.nazvanie2 = "Переехать в Гаити";
    zam5.opisanie2 = "Съездить в Гаити и почиллить";
    zam[4] = zam5;



}

void hod_strelki()
{
    if (position < 0)
    {
        position = 0;
    }

    if (position > 1)
    {
        position = 0;
    }

    Console.Clear();
    Console.SetCursorPosition(0, position + 1);
    Console.WriteLine("=>");
}
void naznachenie()
{
    key = Console.ReadKey();
    if (key.Key == ConsoleKey.UpArrow)
    {
        position--;
    }
    else if (key.Key == ConsoleKey.DownArrow)
    {
        position++;
    }
    else if (key.Key == ConsoleKey.LeftArrow)
    {
        data--;
    }
    else if (key.Key == ConsoleKey.RightArrow)
    {
        data++;
    }
}
void data1()
{

    data = Math.Max(1, Math.Min(30, data));

    Console.SetCursorPosition(0, 0);
    if (data < 10)
    {
        Console.WriteLine("Выбранная дата: " + "0" + data + ".11.2023 г.");
    }
    else if (data == 10)
    {
        Console.WriteLine("Выбранная дата: " + data + ".11.2023 г.");
    }
    else if (data > 10)
    {
        Console.Write("Выбранная дата: " + data + ".11.2023 г.");
    }
    if (data < 6)
    {
        Console.SetCursorPosition(2, 1);
        Console.Write(" 1. ");
        Console.Write(zam[data - 1].nazvanie1);
        Console.SetCursorPosition(2, 2);
        Console.Write(" 2. ");
        Console.Write(zam[data - 1].nazvanie2);
    }

}
void nalichie()
{
    Console.Clear();
    if (position == 0)
    {

        Console.WriteLine(zam[data - 1].nazvanie1);
        Console.WriteLine("===========================================");
        Console.WriteLine(" ");
        Console.WriteLine("Описание: " + zam[data - 1].opisanie1 + "  ");
        Console.WriteLine(" ");
        Console.WriteLine("===========================================");
        Console.Write("Дата: " + "0" + data + ".11.2023" + " 09:00:00");

    }
    else
    {
        Console.WriteLine(zam[data - 1].nazvanie2);
        Console.WriteLine("===========================================");
        Console.WriteLine(" ");
        Console.WriteLine("Описание: " + zam[data - 1].opisanie2);
        Console.WriteLine(" ");
        Console.WriteLine("===========================================");
        Console.Write("Дата: " + "0" + data + ".11.2023" + " 15:00:00");

    }


}
class zametka
{
    public string nazvanie1;
    public string opisanie1;
    public string nazvanie2;
    public string opisanie2;
}