// SPDX-FileCopyrightText: 2025 Bibble-B-Boop <mysticball8@gmail.com>
// SPDX-FileCopyrightText: 2025 JamboreeBot <JamboreeBot@proton.me>
//
// SPDX-License-Identifier: AGPL-3.0-or-later

using Content.Shared.Speech;
using Robust.Shared.Audio;
using Robust.Shared.GameStates;
using Robust.Shared.Prototypes;

namespace Content.Shared._Imp.Pleebnar.Components;
/// <summary>
/// component for the pleebnar telepathy action component
/// </summary>
[RegisterComponent, NetworkedComponent]
public sealed partial class PleebnarTelepathyActionComponent : Component
{
    [DataField]
    public EntityUid? TelepathyAction;

    [DataField]
    public string? TelepathyActionId = "ActionPleebnarTelepathy";

    [DataField]
    public string? WeirdAudioPath = "/Audio/_Impstation/Animals/pleebnar_weird.ogg";

    [DataField]
    public EntityUid? VisionAction;

    [DataField]
    public string? VisionActionId = "ActionPleebnarVision";

    [DataField]
    public string? PleebnarVison;
    [DataField]
    public string? PleebnarVisonName;
    [DataField]
    public string? PleebnarVisonID;
}
