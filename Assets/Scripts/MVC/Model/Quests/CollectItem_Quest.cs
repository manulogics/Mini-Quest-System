using manulogics.Items;
using UnityEngine;

namespace manulogics.Quests
{
    public class CollectItem_Quest : Quest
    {
        private ItemType _requiredItem;
        private int _requiredAmount;
        private int _currentAmount;

        public CollectItem_Quest(string title, ItemType itemType, int amount) : base(title)
        {
            _requiredItem = itemType;
            _requiredAmount = amount;
            _currentAmount = 0;
        }

        public override void StartQuest()
        {
            Debug.Log($"Quest Started: {Title} - Collect {_requiredAmount} items of type {_requiredItem}!");
        }

        public override void CheckProgress()
        {
            if (_currentAmount >= _requiredAmount)
            {
                IsCompleted = true;
                Debug.Log($"Quest Completed: {Title}");
            }
        }
        
        public void OnItemCollected(Item item)
        {
            if (item.Type == _requiredItem)
            {
                _currentAmount++;
                CheckProgress();
            }
        }
    }
}