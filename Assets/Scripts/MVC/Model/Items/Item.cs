namespace manulogics.Items
{
    public class Item
    {
        public ItemType Type { get; private set; }

        public Item(ItemType type)
        {
            Type = type;
        }
    }
}