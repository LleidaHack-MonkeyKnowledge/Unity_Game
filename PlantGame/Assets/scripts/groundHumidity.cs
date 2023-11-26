using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class groundHumidity : MonoBehaviour
{
    Image thisImage;
    [SerializeField]
    private float m_fadeDuration;
    [SerializeField]
    private bool m_ignoreTimeScale;
    int ground_Humidity;

    // Start is called before the first frame update
    void Start()
    {
        thisImage = gameObject.GetComponent<Image>();
    }    

    public void Update()
    {
        // Substituir els GetMouseButton per quan la planta necessita ser regada: ground Humidity < x
        
        if (ground_Humidity < 55) 
        {
            thisImage.CrossFadeAlpha(0f, m_fadeDuration, m_ignoreTimeScale);
        }
        else
        {
            thisImage.CrossFadeAlpha(1f, m_fadeDuration, m_ignoreTimeScale);
        }
    }

    public void setValue(int gHumidity)
    {
        ground_Humidity = gHumidity;
    }
}
