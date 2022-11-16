using System.ComponentModel;

//static void equal(int num,int[] arr)
//{
//	bool f = true;int index = 0;
//	for (int i = 0; i < arr.Length; i++)
//	{
//        if (arr[i] == num)
//		{
//			f = false;
//			index = i;
//			break;
//		}
//	}
//	if(!f)
//		Console.WriteLine(num+" is equal to the index: " + index);
//	else
//		Console.WriteLine(num+" is not equal to array numbers");
//    return;
//}
//int num = Convert.ToInt32(Console.ReadLine());
//int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//equal(num, arr);


static void calculator(double num1,double num2,string operation)
{
	double result = 0;
	if (operation == "+")
		result = num1 + num2;
	else if (operation == "-")
		result = num1 - num2;
	else if (operation == "*")
		result = num1 * num2;
	else if (operation == "/")
		result = num1 / num2;
	else
	{
		Console.WriteLine("Please choose the correct operation!");
		return;
	}
	Console.WriteLine("The result is: "+result);
}
double num1 = Convert.ToDouble(Console.ReadLine());
double num2 = Convert.ToDouble(Console.ReadLine());
string operation = Console.ReadLine();
calculator(num1,num2,operation);