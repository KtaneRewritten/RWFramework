using UnityEngine;

/// <summary>
/// Used for additional options in conjunction with <see cref="KMNeedyModule"/>.
/// </summary>
[RequireComponent(typeof(KMNeedyModule))]
public class RWNeedyModule : MonoBehaviour
{
    /// <summary>
    /// Whether the module requires a deeper foam backing in the bomb casing.
    /// </summary>
    [Tooltip("Whether the module requires a deeper foam backing in the bomb casing.")]
    public bool RequiresDeepBacking;

    /// <summary>
    /// Whether gameplay music should be muted when this module is selected.
    /// </summary>
    [Tooltip("Whether gameplay music should be muted when this module is selected.")]
    public bool MuteGameplayMusic;

    /// <summary>
    /// Whether or not the module should wait and reset after a deactivation. False means the module will never re-activate.
    /// </summary>
    [Tooltip("Whether or not the module should wait and reset after a deactivation. False means the module will never re-activate.")]
    public bool ShouldReset = true;

    /// <summary>
    /// The time remaining, in seconds, for which the module will play the warning sound.
    /// </summary>
    [Tooltip("The time remaining, in seconds, for which the module will play the warning sound.")]
    public float WarningTime = 5f;
}
