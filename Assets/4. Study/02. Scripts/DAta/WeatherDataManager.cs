using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

public class WeatherDataManager : MonoBehaviour
{
    public enum WeatherType { Sun, Cloud, Rain, Snow}
    public WeatherType weatherType;

    private string URL = "http://apis.data.go.kr/1360000/VilageFcstInfoService_2.0/getVilageFcst?";

    public string key;
    public string numOfRows;
    public string pageNo;
    public string dataType;
    public string base_date;
    public string base_time;
    public string nx;
    public string ny;

    public WeatherData.Root weatherDatas;
    private int currentPTY;
    private int currentSKY;

    IEnumerator Start()
    {
        URL += $"serviceKey={key}&numOfRows={numOfRows}&pageNo={pageNo}&dataType={dataType}"+
            $"&base_date={base_date}&base_time={base_time}&nx={nx}&ny={ny}";

        Debug.Log(URL);
        UnityWebRequest www = UnityWebRequest.Get(URL);

        yield return www.SendWebRequest();

        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.Log("Failed Data :" + www.error);
        }
        else 
        {
            string data = www.downloadHandler.text;

            Debug.Log(data);

            WeatherData.Root weatherData = JsonUtility.FromJson<WeatherData.Root>(data);

            weatherData = JsonUtility.FromJson<WeatherData.Root>(data);

            foreach ( var item in weatherData.response.body.items.item )
            {
                if(item.category == "PTY")
                {
                    Debug.Log("���� ����" + item.fcstValue);
                }

                else if (item.category == "SKY")
                {
                    currentSKY = int.Parse(item.fcstValue);
                    
                }
            }
            SetWeatherType();
        }

    }

    private void SetWeatherType()
    {
        if (currentPTY == 1 || currentPTY == 2 || currentPTY == 4)
        {
            weatherType = WeatherType.Rain;
        }
        else if (currentPTY == 3)
        {
            weatherType = WeatherType.Snow;
        }

        if (currentSKY == 1)
        {
            weatherType = WeatherType.Sun;
        }
        else if (currentSKY == 3)
        {
            weatherType = WeatherType.Snow;
        }

        Debug.Log($"���� ������ {weatherType}�Դϴ�.");
    }
}
