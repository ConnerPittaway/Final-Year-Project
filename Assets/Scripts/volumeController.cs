using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class volumeController : MonoBehaviour
{
    public Slider backgroundVolumeSlider, sfxVolumeSlider;

    public void OnBackgroundChangeVolume()
    {
        Audio.Instance.BackgroundChangeVolume(backgroundVolumeSlider.value);
    }

    public void OnSoundEffectsChangeVolume()
    {
        Audio.Instance.SoundEffectsChangeVolume(sfxVolumeSlider.value);
    }

    // Start is called before the first frame update
    void Start()
    {
        backgroundVolumeSlider.value = Audio.Instance.backgroundSource.volume;
        sfxVolumeSlider.value = Audio.Instance.sfxSource.volume;
    }
}
