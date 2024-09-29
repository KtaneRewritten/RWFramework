using UnityEngine;

/// <summary>
/// Defines information about the active game, like mission info. Can be used without any extra components.
/// </summary>
public class RWGameInfo : MonoBehaviour
{
    /// <summary>
    /// Is this mod running in Rewritten?
    /// </summary>
    public bool IsRewritten { get; set; } = false;

    /// <summary>
    /// The information for the current mission. May be null.
    /// </summary>
    public KMMission Mission => OnGetMission?.Invoke();

    /// <summary>
    /// Do not use in mod. For game use only.
    /// </summary>
    public event GetMissionDelegate OnGetMission;

#pragma warning disable CS1591
    public delegate KMMission GetMissionDelegate();
#pragma warning restore CS1591
}
