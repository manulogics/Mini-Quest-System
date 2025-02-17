using manulogics.Quests;
using manulogics.Signals;
using Zenject;

namespace manulogics.Installers
{
    public class GameInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            SignalBusInstaller.Install(Container);

            Container.DeclareSignal<ItemCollectedSignal>();
            Container.BindSignal<ItemCollectedSignal>()
                .ToMethod<QuestManager>(x => x.OnItemCollected)
                .FromResolve();
        }
    }
}

