using UnityEngine;

/// <summary>
/// Used for additional options in conjunction with <see cref="KMBombModule"/>.
/// </summary>
[RequireComponent(typeof(KMBombModule))]
public class RWBombModule : MonoBehaviour
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
}
