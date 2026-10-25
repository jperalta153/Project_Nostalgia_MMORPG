public class Item
{
    public string itemName;
    public int price;
    public int quantity;

    public Item(string itemName, int price, int quantity)
    {
        this.itemName = itemName;
        this.price = price;
        this.quantity = quantity;
    }

    public int GetTotalValue()
    {
        return price * quantity;
    }
}
