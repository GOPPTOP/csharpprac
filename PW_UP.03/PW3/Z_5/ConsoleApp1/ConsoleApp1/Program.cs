using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z_5
{
    class Program
    {
        class SmsMessage
        {
            private string messagetext;
            private int maxlength;
            private double initialprice;
            private double symbolprice;
            public string MessageText
            {
                get
                {
                    return messagetext;
                }
                private set
                {
                    messagetext = NormalizeMessageText(value, maxlength);
                }
            }
            public int MaxLength
            {
                get
                {
                    return maxlength;
                }
                private set
                {
                    maxlength = value;
                }
            }
            public double InitialPrice
            {
                get
                {
                    return initialprice;
                }
                private set
                {
                    initialprice = value;
                }
            }
            public double SymbolPrice
            {
                get
                {
                    return symbolprice;
                }
                private set
                {
                    symbolprice = value;
                }
            }
            private double Price
            {
                get
                {
                    return CalculatePrice(initialprice, symbolprice);
                }
            }
            public SmsMessage(string text, int length, double initialprice, double symbolprice)
            {
                MessageText = text;
                MaxLength = length;
                InitialPrice = initialprice;
                SymbolPrice = symbolprice;
            }
            public void SendMessage()
            {

                Console.WriteLine($"Текст: '{messagetext}' - длина {messagetext.Length} символов, стоимость {Price} руб");
            }
            private string NormalizeMessageText(string text, int length)
            {
                if (text.Length > length)
                {
                    return text.Substring(0, text.Length - length);
                }
                return text;
            }
            private double CalculatePrice(double initialprice, double symbolprice)
            {
                if (messagetext.Length < 65)
                {
                    return initialprice;
                }
                else
                {
                    int length = MessageText.Length - 65;
                    return initialprice + length * symbolprice;
                }
            }
        }
        static void Main(string[] args)
        {
            SmsMessage sms = new SmsMessage("обед очки уютненько обед очки уютненько обед очки уютненько обед очки уютненько обед очки уютненько обед очки уютненько", 100, 2, 0.9);
            sms.SendMessage();
            Console.ReadKey(true);
        }
    }
}