using System;
namespace Domashka
{
    class Account
    {
        public delegate void MoneyHandler();
        public event MoneyHandler Show;

        private decimal _money;

        public Account(decimal money)
        {
            if (money < 0)
            {
                throw new ArgumentException();
            }
            _money = money;
        }


        public void Take(decimal money)
        {
            if (money <= _money)
            {
                _money -= money;

                Show?.Invoke($"Account removed {money}");
            }
            else
            {
                Show?.Invoke("Not enough money");
            }
        }

        delegate int Put(decimal money);
        public void PutMoney(decimal money)
        {
            Put put = money => _money + money; 

            Show?.Invoke($"Added to account {money}");
        }
    }
    //class Mistake
    //{
    //    static void MistakeException()
    //    {
    //        try
    //        {
    //            Account account = new Account(100);
    //            account.Show += Display;
    //        }
    //        catch (ArgumentException ex)
    //        {
    //            Console.WriteLine(ex.Message);
    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine(ex.Message);
    //        }

    //        Account account = new Account(100);
    //        Console.Read();
    //    }
    //    static void Display()
    //    {
    //        Console.WriteLine();
    //    }
    //}
}

