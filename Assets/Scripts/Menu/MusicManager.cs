using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicManager : MonoBehaviour
{
    [SerializeField] Slider musicSlider;
    [SerializeField] AudioSource AudioSource;

    public void ChangeVolume()
    {
        AudioSource.volume = (musicSlider.value / 100);
    }
}
