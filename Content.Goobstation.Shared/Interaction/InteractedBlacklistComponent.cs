// SPDX-FileCopyrightText: 2025 JamboreeBot <JamboreeBot@proton.me>
// SPDX-FileCopyrightText: 2025 deltanedas <39013340+deltanedas@users.noreply.github.com>
//
// SPDX-License-Identifier: AGPL-3.0-or-later

using Content.Shared.Whitelist;
using Robust.Shared.GameStates;

namespace Content.Goobstation.Shared.Interaction;

// this is here since no reason to be in Content.Shared
[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
[Access(typeof(InteractedBlacklistSystem))]
public sealed partial class InteractedBlacklistComponent : Component
{
    [DataField(required: true), AutoNetworkedField]
    public EntityWhitelist? Blacklist;
}
