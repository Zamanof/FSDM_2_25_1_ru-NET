/*
 ref -  для отправки значимых типов в методы как ссылка
        До отправки в метод наша переменная должна быть инициализировано
        https://learn.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/ref

 out -  для отправки значимых типов в методы как ссылка
        До отправки в метод наша переменная может быть не инициализировано,
        но внутри метода она непременно должна быть инициализировано
        https://learn.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/out

 in -   для отправки значимых типов в методы как ссылка
        переменную внутри метода можно только читать(readonly)
        https://learn.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/in
 */

int numb = 10;
int numb1 = 15;
int numb2;
int numb4 = 45;
int[] arr = [2, 6, 78];
Console.WriteLine($"numb = {numb}, numb1 = {numb1}");
ChangeValue(numb, arr, ref numb1, out numb2, out int numb3, in numb4);
foreach (var item in arr)
{
    Console.Write($"{item} ");
}
Console.WriteLine();
Console.WriteLine($"numb = {numb}, numb1 = {numb1}");



void ChangeValue(
    int number, 
    int[] arr, 
    ref int number1, 
    out int number2, 
    out int number3,
    in int number4)
{
    number += 10;
    arr[0] = 25;
    number1 += 10;
    number2 = 26;
    number3 = number + number1;
}

void MyTryParse(string value,out int n)
{
    try
    {
        n = int.Parse(value);
    }
    catch (Exception)
    {

        n = default;
    }
}
