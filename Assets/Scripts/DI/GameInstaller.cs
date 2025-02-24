using manulogics.Quests;
using manulogics.Signals;
using manulogics.UI;
using UnityEngine;
using Zenject;

namespace manulogics.Installers
{
    public class GameInstaller : MonoInstaller
    {
        [SerializeField] private QuestDebugUI questDebugUI;
        
        public override void InstallBindings()
        {
            Container.BindInterfacesTo<QuestManager>().AsSingle();
            QuestInstaller.Install(Container);
            Container.Bind<QuestDebugUI>().FromInstance(questDebugUI).AsSingle();
        }
    }
}

