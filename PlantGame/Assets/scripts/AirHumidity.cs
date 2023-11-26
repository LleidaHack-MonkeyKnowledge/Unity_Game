using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirHumidity : MonoBehaviour
{
    ParticleSystem airHumid;
    [SerializeField]int humidValue = 0;
    // Start is called before the first frame update
    void Start()
    {

        GameObject go = GameObject.FindGameObjectWithTag("AirHumidity");
        if(go != null) { airHumid = go.GetComponent<ParticleSystem>(); }

    }

    // Update is called once per frame
    void Update()
    {
        if(humidValue == 0) { airHumid.Stop(); }
        else
        {
            if(!airHumid.isPlaying) airHumid.Play();

            var mainModule = airHumid.main;
            mainModule.startSpeed = humidValue;

        }
    }
    

    public void SetValue(int value)
    {
        humidValue = value;
    }
}
