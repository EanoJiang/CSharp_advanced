using System.Collections;

class Bag
{
    private ArrayList items;

    private int money;

    public Bag(int money)
    {
        this.money = money;
        items = new ArrayList();
    }
    public void BuyItem(Item item)
    {
        //物品信息错误
        if (item.num <= 0 || item.price <= 0)
        {
            Console.WriteLine("物品信息有误");
            return;
        }
        //金钱变化
        if (money < item.price * item.num)
        {
            Console.WriteLine("钱不够");
            return;
        }
        money -= item.price * item.num;
        //添加物品
        foreach (Item i in items)
        {
            //如果已经在背包里面，必须要比较UID
            //  因为传入的item不会和items里的item是同一个对象，所以要判断UID
            if (i.UID == item.UID)
            {
                //叠加数量
                i.num += item.num;
                return;
            }
        }
        items.Add(item);
        Console.WriteLine("买了{0}个{1}，共花费{2}元", item.num, item.name, item.price * item.num);
        ShowItems();
    }
    //根据item卖
    public void SellItem(Item item)
    {
        //遍历物品
        foreach (Item i in items)
        {
            //要卖的东西在背包里有，必须要比较UID
            if (i.UID == item.UID)
            {
                string name = i.name;
                int price = i.price;
                int sellNum = item.num;
                //买的数量判定
                if (i.num < item.num)
                {
                    sellNum = i.num;  //要卖出的数量超出已有，只能卖出已有的全部
                }
                i.num -= sellNum;
                money += (int)(sellNum * price * 0.8f);
                Console.WriteLine("卖了{0}个{1}，共获得{2}元", sellNum, name, (int)(sellNum * price * 0.8f));
                if (i.num <= 0) items.Remove(i);    //卖完了就要移除当前遍历的该项
                ShowItems();
                return;
            }
        }
        Console.WriteLine("没有这个物品");
        return;
    }
    //根据UID卖
    public void SellItem(int UID, int num = 1)
    {
        Item item = new Item();
        item.UID = UID;
        item.num = num;
        SellItem(item);
    }
    public void ShowItems()
    {
        foreach (Item item in items)
        {
            Console.Write("有{0}个{1}，", item.num, item.name);
        }
        Console.WriteLine("现在手里有{0}元",money);
    }
}

class Item
{
    //单价
    public int price;
    public int UID;
    public string name;
    public int num;
    public Item()
    {
    }
    public Item(int UID, int price, string name, int num)
    {
        this.UID = UID;
        this.price = price;
        this.name = name;
        this.num = num;
    }
}

class Program
{
    static void Main()
    {
        Bag bag = new Bag(10000);
        Item i1 = new Item(1, 10, "sb", 10);
        Item i2 = new Item(2, 20, "sb2", 20);
        Item i3 = new Item(3, 999, "sb3", 3);

        bag.BuyItem(i1);
        bag.BuyItem(i2);
        bag.BuyItem(i3);

        bag.SellItem(2);
        bag.SellItem(i1);

        bag.SellItem(i1);

    }
}