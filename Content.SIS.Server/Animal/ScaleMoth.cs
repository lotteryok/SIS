using Content.Shared.Nutrition;
using Content.SIS.Shared.Animal;

namespace Content.SIS.Server.Animal;

public sealed class ScaleMoth : ScaleMothSystem
{

    public override void Initialize()

    {
        base.Initialize();

        SubscribeLocalEvent<ScaleMothComponent, EdibleEvent>(MothEaten);

    }

    public void MothEaten(Entity<ScaleMothComponent> entity, ref EdibleEvent args)
    {
        if (args.Cancelled)
            return;

        entity.Comp.EatIt = true;
        RaiseNetworkEvent(new ScaleMothEvent(GetNetEntity(entity.Owner), true));
    }
}
