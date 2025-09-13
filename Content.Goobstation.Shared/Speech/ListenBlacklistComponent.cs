// SPDX-FileCopyrightText: 2025 JamboreeBot <JamboreeBot@proton.me>
// SPDX-FileCopyrightText: 2025 deltanedas <39013340+deltanedas@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 deltanedas <@deltanedas:kde.org>
//
// SPDX-License-Identifier: AGPL-3.0-or-later

using Content.Shared.Whitelist;
using Robust.Shared.GameStates;

namespace Content.Goobstation.Shared.Speech;

/// <summary>
/// Prevents this entity from listening to entities that match a blacklist.
/// </summary>
[RegisterComponent, NetworkedComponent]
public sealed partial class ListenBlacklistComponent : Component
{
    /// <summary>
    /// The blacklist the source entity gets checked against.
    /// </summary>
    [DataField(required: true)]
    public EntityWhitelist Blacklist = new();
}
