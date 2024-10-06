using UnityEngine;

/// <summary>
/// Provides methods to interact with the game.
/// </summary>
public class RWGameCommands : MonoBehaviour
{
    /// <summary>
    /// Whether or not the room lights are on. Can be set to turn the lights on or off.
    /// </summary>
    public bool RoomLightsOn
    {
        get => OnGetRoomLights?.Invoke() ?? false;
        set => OnSetRoomLights?.Invoke(value);
    }

    /// <summary>
    /// Do not use in mod. For game use only.
    /// </summary>
    public event GetRoomLightsDelegate OnGetRoomLights;

    /// <summary>
    /// Do not use in mod. For game use only.
    /// </summary>
    public event SetRoomLightsDelegate OnSetRoomLights;

#pragma warning disable CS1591
    public delegate bool GetRoomLightsDelegate();
    public delegate void SetRoomLightsDelegate(bool on);
#pragma warning restore CS1591
}
