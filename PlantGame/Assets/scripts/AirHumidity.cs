using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AirHumidity : MonoBehaviour
{
    ParticleSystem airHumid;
    [SerializeField]int humidValue = 0;
    public GameObject AirText;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        
     
    }
    

    public void SetValue(int value)
    {
        AirText.GetComponent<TextMeshProUGUI>().text = value.ToString();
        humidValue = value;
    }
}
