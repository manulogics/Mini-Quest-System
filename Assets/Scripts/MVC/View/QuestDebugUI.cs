using System;
using System.Linq;
using manulogics.Enemies;
using manulogics.Items;
using manulogics.Quests;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace manulogics.UI
{
    public class QuestDebugUI : MonoBehaviour
    {
        [Header("Collect Item Quest")]
        [SerializeField] private TMP_InputField collectItemAmountInput;
        [SerializeField] private TMP_Dropdown collectItemTypeDropdown;
        [SerializeField] private Button collectItemButton;
        
        [Header("Defeat Enemy Quest")]
        [SerializeField] private TMP_InputField defeatEnemyAmountInput;
        [SerializeField] private TMP_Dropdown defeatEnemyTypeDropdown;
        [SerializeField] private Button defeatEnemyButton;
        
        [Header("Debug Log")]
        [SerializeField] private TMP_Text questLogText;
        
        private QuestManager _questManager;

        [Inject]
        public void Construct(QuestManager questManager)
        {
            _questManager = questManager;
        }

        private void Start()
        {
            collectItemButton.onClick.AddListener(StartCollectItemQuest);
            defeatEnemyButton.onClick.AddListener(StartDefeatEnemyQuest);
            
            collectItemTypeDropdown.ClearOptions();
            collectItemTypeDropdown.AddOptions(System.Enum.GetNames(typeof(ItemType)).ToList());
            defeatEnemyTypeDropdown.ClearOptions();
            defeatEnemyTypeDropdown.AddOptions(System.Enum.GetNames(typeof(ItemType)).ToList());
        }

        private void StartCollectItemQuest()
        {
            if (!int.TryParse(collectItemAmountInput.text, out int amount) || amount <= 0)
            {
                LogQuest("Invalid amount for Collect Item Quest!");
                return;
            }
            
            ItemType selectedItemType = (ItemType)collectItemTypeDropdown.value;
            string questName = $"Collect {amount} items of type {selectedItemType}";
            _questManager.StartQuest<CollectItem_Quest>(questName, selectedItemType, amount);
            LogQuest($"Started Quest: {questName}");
        }

        private void StartDefeatEnemyQuest()
        {
            if (!int.TryParse(defeatEnemyAmountInput.text, out int amount) || amount <= 0)
            {
                LogQuest("Invalid amount for Collect Item Quest!");
                return;
            }
            
            EnemyType selectedEnemyType = (EnemyType)collectItemTypeDropdown.value;
            string questName = $"Defeat {amount} enemies of type {selectedEnemyType}";
            _questManager.StartQuest<DefeatEnemy_Quest>(questName, selectedEnemyType, amount);
            LogQuest($"Started Quest: {questName}");
        }

        private void LogQuest(string message)
        {
            questLogText.text += "\n" + message;
        }
    }
}