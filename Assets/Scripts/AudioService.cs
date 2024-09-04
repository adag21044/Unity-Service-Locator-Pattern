using UnityEngine;

public class AudioService : IAudioService
{
    public void PlaySound(string soundName)
    {
        Debug.Log($"Playing sound: {soundName}");
    }
}