using manulogics.Quests;
using manulogics.Signals;
using manulogics.UI;
using UnityEngine;
using Zenject;

namespace manulogics.Installers
{
    public class GameInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<QuestManager>().AsSingle();
            QuestInstaller.Install(Container);
        }
    }
}

