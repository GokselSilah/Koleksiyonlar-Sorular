// See https://aka.ms/new-console-template for more information


using System.Collections;
//ArrayList asalArray = new ArrayList();
//ArrayList intArray = new ArrayList();
//int control;

//for (int i = 0; i < 20; i++)
//{
//    control = 0;
//    int n = int.Parse(Console.ReadLine());

//    if (n < 0 || n.GetType()==typeof(string))
//    {
//        throw new Exception("N sayısı 0 dan büyük olmalıdır.");
//    }

 



//    for (int j = 2; j < n; j++)
//        {
//            if (n % j == 0)
//            {
//                control++;
//            }



//        }

//        if (control == 0)
//        {
//            asalArray.Add(n);
//        }
//        else
//        {
//            intArray.Add(n);
//        }

//}


//asalArray.Sort();

//intArray.Sort();



//Console.WriteLine("---------------------------------------------------------");

//foreach (var item in asalArray)
//{
//    Console.Write($"{item} - ");
//}

//Console.WriteLine("\n");
//Console.WriteLine("---------------------------------------------------------");

//foreach (var item in intArray)
//{
//    Console.Write($"{item} - ");
//}

//Console.WriteLine("\n");
//Console.WriteLine("---------------------------------------------------------");

//Console.WriteLine($"{asalArray.Count} tane asal sayı bulunmaktadır");
//Console.WriteLine($"{intArray.Count} tane asal olmayan sayı bulunmaktadır");

//Console.WriteLine("---------------------------------------------------------");

//decimal resultAsal = 0;
//decimal result = 0;

//foreach (int item in asalArray)
//{
//    resultAsal += item;    
//}

//foreach (int item in intArray)
//{
//    result += item;
//}
//Console.WriteLine($"Asal Sayıların Ortalaması = {resultAsal/asalArray.Count}");
//Console.WriteLine($"Asal Olmayan Sayıların Ortalaması = {result / intArray.Count}");




//ArrayList list = new ArrayList();
//ArrayList maxs = new ArrayList();
//ArrayList mins = new ArrayList();

//decimal maxAvg = 0;
//decimal minAvg = 0;
//decimal avgSum = 0;
//decimal tempNumber = 0;

//for (int i = 0; i < 20; i++)
//{
//    int n = int.Parse(Console.ReadLine());

//    list.Add(n);
//}

//list.Sort();

//mins = list.GetRange(0, 3);

//maxs = list.GetRange(17, 3);


//Console.WriteLine("En Küçük 3 değer: ");

//foreach (var item in mins)
//{
//    Console.Write($"{item} - ");
//}
//Console.WriteLine("\n");
//Console.WriteLine("En Büyük 3 değer: ");


//foreach (var item in maxs)
//{
//    Console.Write($"{item} - ");
//}
//Console.WriteLine("\n");


//foreach (int item in maxs)
//{
//    tempNumber += item;
//}

//maxAvg = tempNumber / 3;

//Console.WriteLine($"Büyük Sayılar Ortalaması: {maxAvg}");

//tempNumber = 0;

//foreach (int item in mins)
//{
//    tempNumber += item;
//}

//minAvg = tempNumber / 3;

//Console.WriteLine($"Küçük Sayılar Ortalaması: {minAvg}");

//Console.WriteLine($"Ortalamalar Toplamı = {minAvg + maxAvg}");


string s = Console.ReadLine();

string[] words = s.Split();

List<Char> sesliHarfler = new List<Char>() { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };

List<Char> cumledekiSesliHafler = new List<Char>();

foreach (string word in words)
{
    char[] harfler = word.ToCharArray();

    foreach (var harf in harfler)
    {
        if (sesliHarfler.Contains(harf))
        {
            cumledekiSesliHafler.Add(harf);
        }

    }

}

foreach (var item in cumledekiSesliHafler)
{
    Console.Write($"{item} -");
}