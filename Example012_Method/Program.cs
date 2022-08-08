// Вид 1. Ничего не принимает. Ничего не возвращает
/*
void Method1()
{
    Console.WriteLine("Автор...."  );
}
Method1();

// Вид 2. Ничего не принимает. Возвращает какие-либо аргументы

void Method2(string text)
{
    System.Console.WriteLine(text);
}
                // Method2(text: "Текст сообщения");

void Method21(string text, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(text);
        i++;
    }
}
Method21(text: "Текст", count: 4);

// Вид 3.Ничего не принимают. Что-то возвращают

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
System.Console.WriteLine(year);

// Вид 4. Что-то принимают, что-то возвращают

/*
string Method4(int count, string c)
{
    int i = 0;
    string result = String.Empty;
    while (i<count)
    {
        result = result + c;
        i++;
    }
    return result;
}

string Method4(int count, string c)
{
    string result = String.Empty;
    for(int i = 0; i<count; i++)
    {
        result = result + c;
    }
    return result;
}

string result = Method4(10, "Символ");
System.Console.WriteLine(result);


// цикл в цикле

for(int i = 2; i <= 10; i ++)
{
    for(int j = 2; j<=10; j++)
    {
        System.Console.WriteLine($"{i}*{j}={i*j}");
    }
    System.Console.WriteLine();
}
System.Console.WriteLine();
*/
/*
//========== Работа с текстом
//Дан текст. В тексте нужно все пробелы заменить черточками,
//маленькие буквы "к" заменить большими "К",
//большие "С" заменить маленькими "с"
string text ="- Я думаю, - сказал князь, улыбаясь, - что,"
            +"ежели бы вас послали вместо нашего милого Винценгероде,"
            +"вы бы взяли приступом согласие прусского короля. "
            +"Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012345
// s[3] // r


string Replace(string text, char oldSimvol, char newSimvol)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {

        if(text[i] == oldSimvol) result = result + $"{newSimvol}";
       else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '|' );
System.Console.WriteLine(newText);
System.Console.WriteLine();
newText = Replace(text, 'к', 'К' );
System.Console.WriteLine(newText);
*/
//Сортировка массива

/*
int[] array ={1,5,4,3,2,6,7,1,1};

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

void Sort(int[] array)
{
for (int i = 0; i < array.Length -1; i++)
{
   int minPosition = i;

   for (int j = i+1; j < array.Length; j++)
   {
    if(array[j]<array[minPosition]) minPosition = j;
   }
   int temporary = array[i];
   array[i] = array[minPosition]; 
   array[minPosition] = temporary;   
}
}
PrintArray(array);
Sort(array);
PrintArray(array);
*/

int[] array ={1,5,4,3,2,6,7,1,1};

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

void Sort(int[] array)
{
for (int i = 0; i < array.Length -1; i++)
{
   int maxPosition = i;

   for (int j = i+1; j < array.Length; j++)
   {
    if(array[j]>array[maxPosition]) maxPosition = j;
   }
   int temporary = array[i];
   array[i] = array[maxPosition]; 
   array[maxPosition] = temporary;   
}
}
PrintArray(array);
System.Console.WriteLine();
Sort(array);
PrintArray(array);





