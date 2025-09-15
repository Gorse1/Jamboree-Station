// SPDX-FileCopyrightText: 2025 Baine Junk <wym0n@proton.me>
// SPDX-FileCopyrightText: 2025 Bibble-B-Boop <mysticball8@gmail.com>
// SPDX-FileCopyrightText: 2025 JamboreeBot <JamboreeBot@proton.me>
//
// SPDX-License-Identifier: AGPL-3.0-or-later

using Robust.Shared.Prototypes;

namespace Content.Shared._Imp.Pleebnar;

/// <summary>
///     prototype that hold vision data
/// </summary>
[Prototype]
public sealed partial class PleebnarVisionPrototype : IPrototype
{
    [IdDataField] public string ID { get; private set; } = default!;

    /// <summary>
    ///     Loc string for the vision
    /// </summary>
    [DataField("visionString", required: true)]
    public LocId VisionString = string.Empty;
    /// <summary>
    ///     Loc string for the vision name
    /// </summary>
    [DataField(required: true)]
    public LocId Name = string.Empty;
}
