using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ColorChange : MonoBehaviour
{
    // Start is called before the first frame update
    //Color day = new Color(0f, 0f, 0f, 0f);
    //Color night = new Color(1f, 1f, 1f, 0.1f);

    Color color;
    int opacity;
    public GameObject _light;

    public void SetValue(int light)
    {
        _light.GetComponent<TextMeshProUGUI>().text = light.ToString();
        opacity = light;
        opacity = opacity / 100;
    }
    void Start()
    {
        color = gameObject.GetComponent<Image>().color;
    }

    // Update is called once per frame
    void Update()
    {
        //Get slider value
        

        //Change the object color
        Color dayNight = new Color(color.r, color.g, color.b, opacity - 0.2f);
        gameObject.GetComponent<Image>().color = dayNight;
    }

}
