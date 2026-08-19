using System.Numerics;
using Content.Shared.Nutrition;
using Robust.Shared.GameStates;

namespace Content.SIS.Shared.Animal;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState(true)]

public sealed partial class ScaleMothComponent : Component
{
    public EdibleEvent MothUid;

    [DataField]
    public Vector2 Scaler = new(0.3f, 0.3f);

    [AutoNetworkedField]
    public bool EatIt = false;
}
