using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct PlantData
{

    public string id;
    public int light;
    public int soil_humidity;
    public int air_humidity;
    public float temperature;

}

public class Deserializer : MonoBehaviour
{
    groundHumidity gh;
    Thermometer t;
    ColorChange l;

    public void Start()
    {
        //Initialize values
        gh = FindObjectOfType<groundHumidity>();
        t = FindObjectOfType<Thermometer>();
        l = FindObjectOfType<ColorChange>();

    }

    public PlantData GetDataFromJson(string data)
    {
        PlantData pd = JsonUtility.FromJson<PlantData>(data);
        Debug.Log("MessageRecieved");
        ProcessData(pd);
        return pd;
    }

    public void ProcessData(PlantData pd)
    {
        Debug.Log("Light: " + pd.light + "\nSoil Humidity: " + pd.soil_humidity +
            "\nAir Humidity: " + pd.air_humidity + "\nTemperature: " + pd.temperature);

        gh.setValue(pd.soil_humidity);
        t.SetValue(pd.temperature);
        l.SetValue(pd.light);
    }
}
