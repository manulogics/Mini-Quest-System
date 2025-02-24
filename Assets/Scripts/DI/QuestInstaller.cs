using manulogics.Quests;
using UnityEngine;
using Zenject;

namespace manulogics.Installers
{
    public class QuestInstaller : Installer<QuestInstaller>
    {
        public override void InstallBindings()
        {
            Container.Bind<Quest>().To<CollectItem_Quest>().AsTransient().WhenInjectedInto<QuestManager>();
            Container.Bind<Quest>().To<DefeatEnemy_Quest>().AsTransient().WhenInjectedInto<QuestManager>();
        }
    }
}

