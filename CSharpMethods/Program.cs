

//1) Verilmiş n - ədədinin 3-ə və 7-ə bölünüb-bölünməməsini tapın.

#region task 1
//IsDividedOrNot(21);
//static void IsDividedOrNot(int n)
//{
//    if (n % 3 == 0 && n % 7 == 0)
//    {
//        Console.WriteLine("bolunur");
//    }
//    else
//    {
//        Console.WriteLine("bolunmur");
//    }
//}
#endregion



//2) n və m ədədləri verilir. Əgər n və m ədədləri hər ikisi cütdürsə n və m ədədlərinin cəmini hesablayın.

#region task 2
//Sum(6, 10);
//static void Sum(int n, int m)
//{

//	if (n % 2 == 0 && m % 2 == 0)
//	{
//		Console.WriteLine(n + m);
//	}
//	else
//	{
//		Console.WriteLine("duzgun reqem daxil edin");
//	}
//}
#endregion



//3) Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin cemini tapin.

#region task 3
//Sum(11, 20);
//static void Sum(int n, int m)
//{
//    int sum = 0;
//    for (int i = n; i < m; i++)
//    {
//        if (i % 2 == 1 )
//        {
//            sum += i;
//        }
//    }
//    Console.WriteLine(sum);
//}
#endregion



//4) Verilmish arrayin icindeki tek ededlerin cemini tapin.

#region task 4
//int[] arr = { 2, 5, 7, 8, 11 };
//Sum(arr);

//static void Sum(int[] arr )
//{
//    int sum = 0;
//    foreach (int item in arr)
//    {
//        if (item % 2 == 1)
//        {
//            sum += item;
//        }

//    }
//    Console.WriteLine(sum);
//
#endregion



//5) Verilmish arrayin icindeki cut ededlerin sayini tapin.

#region task 5
//int[] arr = { 1, 5, 7, 9, 10 };
//Count(arr);
//static void Count(int[] arr)
//{
//    int count = 0;
//    foreach (int item in arr)
//    {
//        if (item % 2 == 0)
//        {
//            count++;
//        }
//    }
//    Console.WriteLine(count);
//}
#endregion



//6) Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin sayini tapin.

#region task 6
//Count(5, 15);

//static void Count(int n, int m)
//{
//    int count = 0;
//    for (int i = n; i < m; i++)
//    {
//        if (i % 2 == 1)
//        {
//            count++;
//        }

//    }
//    Console.WriteLine(count);
//}
#endregion



//7) Verilmis n ve m (n<m) ededleri arasindaki cut ededlerin cemini tapin.

#region task 7
//Sum(5, 9);
//static void Sum(int n, int m)
//{
//    int sum = 0;
//    for (int i = n; i < m; i++)
//    {
//        if ( i % 2 == 0 )   
//        {
//            sum += i;
//        }
//    }
//    Console.WriteLine(sum);
//}
#endregion



//8) Verilmis n ve m (n<m) ededleri arasindaki cut ededlerin sayini tapin.

#region task 8
//Count(5, 10);

//static void Count(int n, int m)
//{
//    int count = 0;
//	for (int i = n; i < m; i++)
//	{
//		if (i % 2 == 0)
//		{
//			count++;
//		}
//	}
//	Console.WriteLine(count);
//}

#endregion



//9) Verilmis n tam ededinin sade ve ya murekkeb oldugunu tapin.

#region task 9

//SimpleOrInk(7);

//static void SimpleOrInk(int n)
//{
//	int count = 0;

//	if (n <= 1)
//	{
//		Console.WriteLine("duzgun reqem daxil edin");
//	}
//	else
//	{
//		for (int i = 2; i < n; i++)
//		{
//			if (n % i == 0)
//			{
//				count++;
//			}
//		}
//	}
//	if (count == 0)
//	{
//		Console.WriteLine("sade ededdir");
//	}
//	else
//	{
//		Console.WriteLine("murekkeb ededdir");
//	}
//}
#endregion



//10) n ededinin faktorialini hesablamaq.

#region task 10

//Factorial(3);

//static void Factorial(int n)
//{
//	int factorial = 1;

//	for (int i = 1; i <= n; i++)
//	{
//		factorial *= i;
//	}
//	Console.WriteLine(factorial);
//}
#endregion






