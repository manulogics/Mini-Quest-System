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

        public void StartQuest<T>(params object[] args) where T : IQuest
        {
            var quest = (T)System.Activator.CreateInstance(typeof(T), args);
            _activeQuests.Add(quest);
            quest.StartQuest();
        }
    }
}