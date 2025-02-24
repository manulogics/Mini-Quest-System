using System.Collections.Generic;
using manulogics.Signals;
using Zenject;

namespace manulogics.Quests
{
    public class QuestManager
    {
        private readonly List<IQuest> _activeQuests = new();
        private readonly DiContainer _container;

        [Inject]
        public QuestManager(DiContainer container)
        {
            _container = container;
        }

        public void StartQuest<T>() where T : IQuest
        {
            var quest = _container.Resolve<T>();
            _activeQuests.Add(quest);
            quest.StartQuest();
        }
    }
}