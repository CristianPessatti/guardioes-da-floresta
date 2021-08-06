using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControleSom : MonoBehaviour
{
    [SerializeField] Slider sliderVolume;

    void Start()
    {
        if(!PlayerPrefs.HasKey("volumeMusica"))
        {
            PlayerPrefs.SetFloat("volumeMusica", 1);
            carregar();
        }else
        {
            carregar();
        }
    }

    public void mudarVolume()
    {
        AudioListener.volume = sliderVolume.value;
        salvar();
    }

    private void carregar()
    {
        sliderVolume.value = PlayerPrefs.GetFloat("volumeMusica");
    }

    private void salvar()
    {
        PlayerPrefs.SetFloat("volumeMusica", sliderVolume.value);
    }
}
