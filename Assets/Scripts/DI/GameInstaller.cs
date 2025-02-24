using manulogics.Quests;
using manulogics.Signals;
using Zenject;

namespace manulogics.Installers
{
    public class GameInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesTo<QuestManager>().AsSingle();
            QuestInstaller.Install(Container);
        }
    }
}

