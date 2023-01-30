/*Задача. Написать программу, которая из имеющегося массива строк сформирует массив из строк, 
длина которых меньше или равна 3 символа. Первоначальный массив сожно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*/

string [] CreateArray(int num)
{
    string [] array=new string[num];
    for (int i=0;i < num; i++)
    {
        array[i]=Convert.ToString(Console.ReadLine());
    }
    return array;
}

string [] ModifiedArray(string [] array)
{
    int count=0;
    for (int i=0;i < array.Length; i++)
    {    
        int len=array[i].Length;
        if (len<3 || len==3 ) count++;  
    }
    int j=0;
    string [] modArray=new string[count];
    while (j<count)
    {
        for (int i=0;i < array.Length; i++)
        {
            int len=array[i].Length;
            if (len<3 || len==3 ) 
            {
                modArray[j]=array[i];  
                j++;
            }
        }
    }
    return modArray;
}


void ShowArray(string [] array)
{
    if (array.Length!=0)
    {
        Console.Write("[");
        for(int i = 0; i < array.Length; i++)
        if (i!=array.Length-1) Console.Write(  "\""+  array[i] + "\""+",");
        else Console.Write(  "\""+  array[i] + "\""+"]");
        Console.WriteLine(); 
    }
    else Console.WriteLine("[]");

    
}

Console.WriteLine("Input the number of items: ");
int num=Convert.ToInt32(Console.ReadLine());

string[] myArray=CreateArray(num);
string[] modmyArray=ModifiedArray(myArray);
ShowArray(myArray);
ShowArray(modmyArray);
