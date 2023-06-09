using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        // Services
        Container.BindInterfacesAndSelfTo<ActionService>().AsSingle();

        // UI
        Container.Bind<IPanel>().To<LoadingPanel>().AsSingle();
    }
}