// SPDX-FileCopyrightText: 2025 Baine Junk <wym0n@proton.me>
// SPDX-FileCopyrightText: 2025 Bibble-B-Boop <mysticball8@gmail.com>
// SPDX-FileCopyrightText: 2025 JamboreeBot <JamboreeBot@proton.me>
//
// SPDX-License-Identifier: AGPL-3.0-or-later

using Content.Shared._Imp.Pleebnar.Components;
using Content.Shared.Actions;
using Content.Shared.DoAfter;
using Robust.Shared.Serialization;

namespace Content.Shared._Imp.Pleebnar;
/// <summary>
/// contains the relevant functions to pleebnar gibbing needed across client and server side operation
/// </summary>
public abstract partial class SharedPleebnarGibSystem : EntitySystem
{

    [Dependency] private readonly SharedActionsSystem _actionsSystem = default!;

    //init function
    public override void Initialize()
    {
        base.Initialize();

        SubscribeLocalEvent<PleebnarGibActionComponent, ComponentStartup>(OnStartup);
        SubscribeLocalEvent<PleebnarGibActionComponent, ComponentShutdown>(OnShutdown);
    }

    //event for selecting a gibbing target
    public sealed partial class PleebnarGibEvent : EntityTargetActionEvent;
    // event for gibbing target after delay
    [Serializable, NetSerializable]
    public sealed partial class PleebnarGibDoAfterEvent : SimpleDoAfterEvent;
    //remove actions when component is removed
    public void OnShutdown(Entity<PleebnarGibActionComponent> ent, ref ComponentShutdown args)
    {
        _actionsSystem.RemoveAction(ent.Owner, ent.Comp.gibAction);

    }
    //add actions when component is added
    public void OnStartup(Entity<PleebnarGibActionComponent> ent, ref ComponentStartup args)
    {
        _actionsSystem.AddAction(ent, ref ent.Comp.gibAction, ent.Comp.gibActionId);
    }
}
