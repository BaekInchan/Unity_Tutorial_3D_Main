using System.IO;
using UnityEngine;

[System.Serializable]
public class SaveData
{
    public string CharID = "";
    public string Name = "";
    public int HP = 100;
    public int Attack = 10;
    public int score;
}

public class SaveDataFile : MonoBehaviour
{
    private int score;
    private string savePath;

    private void Start()
    {
        // Application.dataPath : Asset 폴더
        // Aplication.persistentDataPath : 플랫폼 별로 안전하게 추천하는 로컬 저장소 경로
        savePath = Path.Combine(Application.persistentDataPath, "saveDataFile.json");

        Load();
        Debug.Log("Load Score : " + score);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            score++;

            Debug.Log("Score :" + score);

            Save();
        }
    }

    private void Save()
    {
        SaveData data = new SaveData();
        data.score = score;

        string json = JsonUtility.ToJson(data, true);
        //string json = JsonUtility.ToJson(data, true);

        File.WriteAllText(savePath, json);

        Debug.Log("Data saved to : " + savePath);
        
    }

    private void Load()
    {
        if (File.Exists(savePath))
        {
            string json = File.ReadAllText(savePath);
            SaveData data = JsonUtility.FromJson<SaveData>(json);
            score = data.score;
        }

        else
        {
            score = 0;
        }
    }

    private void OnApplicationQuit()
    {
        Save();
    }
}
