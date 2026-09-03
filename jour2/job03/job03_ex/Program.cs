using System;



MerchantCart cart = new MerchantCart();

cart.AddGold(100);
Console.WriteLine("Current gold : " + cart.GetGold());

cart.PayFee(30);
Console.WriteLine("Current gold : " + cart.GetGold());


cart.PayFee(1000);



class MerchantCart
{

    private int gold;


    public void AddGold(int amount)
    {
        gold = gold + amount;
    }


    public bool PayFee(int amount)
    {

        if (amount > gold)
        {
            Console.WriteLine("Alert : insufficant funds to pay " + amount + " gold coins.");
            return false;
        }

        gold = gold - amount;
        return true;
    }


    public int GetGold()
    {
        return gold;
    }
}