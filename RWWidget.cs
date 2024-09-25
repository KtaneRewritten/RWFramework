using UnityEngine;

/// <summary>
/// Used for additional options in conjunction with <see cref="KMWidget"/>.
/// </summary>
[RequireComponent(typeof(KMWidget))]
public sealed class RWWidget : MonoBehaviour
{
    /// <summary>
    /// Should this widget be present on every bomb?
    /// </summary>
    [Tooltip("Should this widget be present on every bomb?")]
    public bool IsRequiredWidget = false;

    /// <summary>
    /// How many instances of this widget are allowed to be created on one bomb. Set to zero for no limit.
    /// </summary>
    [Tooltip("How many instances of this widget are allowed to be created on one bomb. Set to zero for no limit.")]
    public int MaxInstances = 0;
}
