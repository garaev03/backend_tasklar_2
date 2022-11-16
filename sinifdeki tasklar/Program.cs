static string substring(string name, int from, int to)
{
    string str="";
    for (int i = from; i < to; i++) 
        str += name[i];
    Console.WriteLine(str);
    return str;
}

static void repeated(string name)
{
   
    for (int i = 0; i < name.Length; i++)
    {
        int say = 0;
        for (int j = 0; j < name.Length; j++)
        {
            if (name[i] == name[j])
                say++;
            else
                continue;
        }
    if(say<2)
            Console.WriteLine(name[i]);
    }
    return ;
}
//repeated(Console.ReadLine());
static void contains(string name, string contain)
{
    int num = 0,say=0;
    for (int i = 0; i < name.Length; i++)
    {
        int index = i;
        for (int j = num; j < contain.Length; j++)
        {
            if (name[i] == contain[j])
            {
                say++;
                i++;
                if (say == contain.Length)
                {
                    Console.WriteLine("TRUE");
                    return;
                }
            }
            else
            {
                i = index;
                say = 0;
                break;
            }
        }
    }
    Console.WriteLine("FALSE");
}
//contains(Console.ReadLine(),Console.ReadLine());


