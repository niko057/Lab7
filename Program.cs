
//Task1.
//Bir array yaradin ,o arraydaki ededlerin cemini ve ededi ortasinin tapin

//int[] arr = { 1, 3, 4, 5, 6, 7, 8, 9, 10 };
//int sum = 0;
//foreach (var i in arr)
//{
//    sum += i;
//}

//double average=sum/arr.Length;
//Console.WriteLine("Ededlerin cemi:"+sum);
//Console.WriteLine("Ededi Orta:" + average);

//Task2.
// Istifadeci uc noqte (x1,y1),(x2,y2) ve (x3,y3) alan proqram yazin.
// Proqram uc noqtenin hamisinin bir duz xette dusub-dusmediyini yoxlamalidir.

Console.WriteLine("Birinci koordinati daxil edin (x1, y1):");
double x1 = double.Parse(Console.ReadLine());
double y1 = double.Parse(Console.ReadLine());

Console.WriteLine("İkinci koordinati daxil edin (x2, y2):");
double x2 = double.Parse(Console.ReadLine());
double y2 = double.Parse(Console.ReadLine());

Console.WriteLine("Üçüncü koordinati daxil edin (x3, y3):");
double x3 = double.Parse(Console.ReadLine());
double y3 = double.Parse(Console.ReadLine());

bool rightOn = (y2 - y1) / (x2 - x1) == (y3 - y2) / (x3 - x2);

Console.WriteLine(rightOn ? "Uc noqte ust uste dusur." : "Uc noqte ust uste dusmur.");