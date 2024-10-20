Console.Write("Birinci kenar uzunluğunu giriniz:");
int birincikenar = Convert.ToInt32(Console.ReadLine());

Console.Write("İkinci kenar uzunluğunu giriniz:");
int ikincikenar = Convert.ToInt32(Console.ReadLine());

Console.Write("Üçüncü kenar uzunluğunu giriniz:");
int ucuncukenar = Convert.ToInt32(Console.ReadLine());

int hacim = birincikenar * ikincikenar * ucuncukenar;


Console.Write("Dikdörtgenler prizmasının hacmi:" + hacim);

Console.ReadKey();