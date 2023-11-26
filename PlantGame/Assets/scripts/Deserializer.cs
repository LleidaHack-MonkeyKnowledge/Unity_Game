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
    public void Start()
    {
        //Initialize values
    }

    public PlantData GetDataFromJson(string data)
    {
        PlantData pd = JsonUtility.FromJson<PlantData>(data);
        ProcessData(pd);
        return pd;
    }

    public void ProcessData(PlantData pd)
    {
        Debug.Log("Light: " + pd.light + "\nSoil Humidity: " + pd.soil_humidity +
            "\nAir Humidity: " + pd.air_humidity + "\nTemperature: " + pd.temperature);
    }
}
