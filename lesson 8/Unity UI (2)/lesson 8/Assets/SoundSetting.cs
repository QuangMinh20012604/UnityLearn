using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SoundSetting : MonoBehaviour
{
    [SerializeField] private float soundValue;
    Slider slider;
    private void Awake()
    {
        slider = GetComponent<Slider>();
        slider.onValueChanged.AddListener(delegate { OnSliderChange(); });
    }
    private void OnSliderChange()
    {
        soundValue = slider.value;
    }
    public void Reset(float value)
    {
        soundValue = value;
    }
}
