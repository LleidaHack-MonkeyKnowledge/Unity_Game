using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Thermometer : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider _slider;
    Color sliderColor;
    float _color;
    public GameObject celcius;

    public void SetValue(float temperature) 
    {
        celcius.GetComponent<TextMeshProUGUI>().text = temperature.ToString();
        _color = temperature;
        _color = _color/40;
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        sliderColor = Color.Lerp(Color.red, Color.blue, _color);
        _slider.GetComponentInChildren<Image>().color = sliderColor;
    }
}
