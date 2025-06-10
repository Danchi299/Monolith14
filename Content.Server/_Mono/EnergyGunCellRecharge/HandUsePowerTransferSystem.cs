// using Content.Server.PowerCell.PowerCellSystem

public sealed class EnergyTradeSender : EntitySystem
{
    // pass
}

public sealed class EnergyTradeReciever : EntitySystem
{

    // public override void Initialize()
    // {
    //     base.Initialize();

    //     SubscribeLocalEvent<EnergyGunComponent, ActivateInWorldEvent>(OnInteractHandEvent);
    //     SubscribeLocalEvent<EnergyGunComponent, GetVerbsEvent<Verb>>(OnGetVerb);
    //     SubscribeLocalEvent<EnergyGunComponent, ExaminedEvent>(OnExamined);
    // }

    private void OnExamined()
    {
        args.PushMarkup("Hello, World!");
    }

    // private void OnInteractHandEvent(EntityUid uid, EnergyGunComponent component, ActivateInWorldEvent args)
    // {
    //     if (component.FireModes == null || component.FireModes.Count < 2)
    //         return;

    //     CycleFireMode(uid, component, args.User);
    // }
}
