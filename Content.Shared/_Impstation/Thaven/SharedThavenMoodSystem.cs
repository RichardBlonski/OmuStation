using Content.Shared.Emag.Systems;

namespace Content.Shared._Impstation.Thaven;

public abstract class SharedThavenMoodSystem : EntitySystem
{
    public override void Initialize()
    {
        base.Initialize();

        SubscribeLocalEvent<ThavenMoodsComponent, GotEmaggedEvent>(OnEmagged);
    }
    protected virtual void OnEmagged(EntityUid uid, ThavenMoodsComponent comp, ref GotEmaggedEvent args)
    {
        args.Handled = true;
    }
}
