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


static void calculator()
{
    double result = 0;
    Console.Write("First Number: ");
    double num1 = Convert.ToDouble(Console.ReadLine());
    result=num1;
    while (true)
    {
        Console.Write("Choose the operator: ");
        string operation = Console.ReadLine();

        if (operation == "=")
        {
            Console.WriteLine("The result is: " + result);
            return;
        }
        Console.Write("Add Number: ");
        double addedNum = Convert.ToDouble(Console.ReadLine());

        double sum(double num1, double num2)
        {
            result = result + num2;
            return result;
        }
        double product(double num1, double num2)
        {
            result = result * num2;
            return result;
        }
        double divide(double num1, double num2)
        {
            result = result / num2;
            return result;
        }
        double sub(double num1, double num2)
        {
            result = result - num2;
            return result;
        }

        if (operation == "+")
            sum(num1, addedNum);
        else if (operation == "-")
            sub(num1, addedNum);
        else if (operation == "*")
            product(num1, addedNum);
        else if (operation == "/")
            divide(num1, addedNum);
        else
        {
            Console.WriteLine("Please choose the correct operator!");
        }
        Console.WriteLine("To finish the operation press '=' !");
        
    }
}



calculator();