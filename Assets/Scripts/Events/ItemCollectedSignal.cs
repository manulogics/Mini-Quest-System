using manulogics.Items;

namespace manulogics.Signals
{
    public class ItemCollectedSignal
    {
        public Item Item { get; private set; }

        public ItemCollectedSignal(Item item)
        {
            Item = item;
        }
    }
}

