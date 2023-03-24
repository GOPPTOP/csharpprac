using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z_2
{
    class Program
    {
        class SmsMessage
        {
            private string messageText;
            public string MessageText
            {
                get
                {
                    return messageText;
                }
                private set
                {
                    messageText = NormalizeMessageText(value);
                }
            }
            private double Price
            {
                get
                {
                    return CalculatePrice();
                }
            }
            public SmsMessage(string text)
            {
                MessageText = text;
            }
            public void SendMessage()
            {

                Console.WriteLine($"Текст: '{messageText}' - длина {messageText.Length} символов, стоимость {Price} руб");
            }
            private string NormalizeMessageText(string text)
            {
                if (text.Length > 250)
                {
                    return text.Substring(0, text.Length - 250);
                }
                return text;
            }
            private double CalculatePrice()
            {
                if (messageText.Length < 65)
                {
                    return 1.5;
                }
                else
                {
                    int length = MessageText.Length - 65;
                    return 1.5 + length * 0.5;
                }
            }
        }
        static void Main(string[] args)
        {
            SmsMessage sms = new SmsMessage("обед очки уютненько обед очки уютненько обед очки уютненько обед очки уютненько обед очки уютненько обед очки уютненько ");
            sms.SendMessage();
            Console.ReadKey(true);
        }
    }
}
