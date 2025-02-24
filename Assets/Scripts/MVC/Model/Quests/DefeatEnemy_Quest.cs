using UnityEngine;

namespace manulogics.Quests
{
    public class DefeatEnemy_Quest : Quest
    {
        private int _requiredAmount;
        private int _currentAmount;
        
        public DefeatEnemy_Quest(string title, int amount) : base(title)
        {
            _requiredAmount = amount;
            _currentAmount = 0;
        }

        public override void StartQuest()
        {
            Debug.Log($"Quest started: {Title} - Defeat enemies");
        }

        public override void CheckProgress()
        {
            if (_currentAmount >= _requiredAmount)
            {
                IsCompleted = true;
                Debug.Log($"Quest Completed: {Title}");
            }
        }
    }
}