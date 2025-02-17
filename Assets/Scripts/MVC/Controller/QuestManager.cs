using System.Collections.Generic;
using manulogics.Signals;
using Zenject;

namespace manulogics.Quests
{
    public class QuestManager
    {
        private List<IQuest> _activeQuests = new();
        private SignalBus _signalBus;

        [Inject]
        public QuestManager(SignalBus signalBus)
        {
            _signalBus = signalBus;
            signalBus.Subscribe<ItemCollectedSignal>(OnItemCollected);
        }

        public void AddQuest(IQuest quest)
        {
            _activeQuests.Add(quest);
        }

        public void OnItemCollected(ItemCollectedSignal signal)
        {
            foreach (var quest in _activeQuests)
            {
                if (quest is CollectItem_Quest collectQuest)
                    collectQuest.OnItemCollected(signal.Item);
            }
        }
    }
}