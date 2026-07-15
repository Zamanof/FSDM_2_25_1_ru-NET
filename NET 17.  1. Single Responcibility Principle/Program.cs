/*
 1. Single Responsibility Principle - Принцип единственной ответственности
                                      У класса должна быть только 
                                      одна причина для изменения.
*/
using System.Text.RegularExpressions;

#region Bad example
//class SendMail
//{
//    public bool Send(string mailAddress, string message)
//    {
//        if (IsMailAddressValid(mailAddress))
//        {
//            // Send mail code
//            return true;
//        }
//        return false;
//    }
//    private bool IsMailAddressValid(string mailAddress)
//    {
//        Regex mailPattern = new Regex(@"^[\w\.-]+@[\w\.-]+\.\w{2,}$");
//        return mailPattern.IsMatch(mailAddress);
//    }
//}
#endregion

#region Good example
SendMail sendMail = new(new MailAddressValidationWithAI());
sendMail.Send("Salam@salam.com", "Salam Aleykum bratello");

interface IMailValidation
{
    bool IsMailAddressValid(string mailAddress);
}

class MailAddressValidation : IMailValidation
{
    public bool IsMailAddressValid(string mailAddress)
    {
        Console.WriteLine("Проверка мейла с помощю регулярных выражений");
        Regex mailPattern = new Regex(@"^[\w\.-]+@[\w\.-]+\.\w{2,}$");
        return mailPattern.IsMatch(mailAddress);
    }
}

class MailAddressValidationWithAI : IMailValidation
{
    public bool IsMailAddressValid(string mailAddress)
    {
        // use ChatGpt API for validation;
        Console.WriteLine("Проверка мейла с помощю ИИ");
        return true;
    }
}

class SendMail
{
    private IMailValidation _validation;

    public SendMail(IMailValidation validation)
    {
        _validation = validation;
    }

    public bool Send(string mailAddress, string message)
    {
        if (_validation.IsMailAddressValid(mailAddress))
        {
            // Send mail code
            return true;
        }
        return false;
    }
}
#endregion

