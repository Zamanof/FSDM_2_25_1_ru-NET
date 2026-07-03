// Extension methods - методы расширения

// Методы расширения позволяют добавлять новые методы
// к существующим типам без необходимости создавать новый производный тип,
// повторно компилировать или изменять исходный тип.
// Они определяются как статические методы в статическом классе,
// но вызываются как если бы они были методами экземпляра на расширяемом типе.
string word = "Lorem ipsum dolor sit amet. Salam. Hi.";
//Console.WriteLine(CountWords(word));
//Console.WriteLine(word.CountWords());


Console.WriteLine("26".ToInt()+ 14);


int CountWords(string text)
{
    var words = text.Split(' ');
    return words.Length;
}
