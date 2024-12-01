using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int capturedStatues = 0;
    public int best;
    public GameObject player;
    GameData gameData;
    BestScore bestScore;
    string filepath = "/GameData.json";
    string bestpath = "/best.json";

    // Start is called before the first frame update
    void Start()
    {
       if (File.Exists(bestpath))
        {
            string loadbestScore = File.ReadAllText(bestpath);
            bestScore = JsonUtility.FromJson<BestScore>(loadbestScore);
            Debug.Log("Best Score loaded");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addScore() {
        capturedStatues+=1;
    }
    void save() {
        gameData = new GameData();
        gameData.currentScore = capturedStatues;
        gameData.playerTransform = player.transform;
    }
    public void SaveGame()
    {
        if (File.Exists(filepath))
        {
            File.Delete(filepath);
        }
        string savePlayerData = JsonUtility.ToJson(gameData);
        File.WriteAllText(filepath, savePlayerData);
    }
    public void LoadGame()
    {
        if (File.Exists(filepath))
        {
            string loadPlayerData = File.ReadAllText(filepath);
            gameData = JsonUtility.FromJson<GameData>(loadPlayerData);
            Debug.Log("Last Game loaded");
        }
    }
}

public class GameData
{
    public int currentScore;
    public Transform playerTransform;
}

public class BestScore {
    public int bestScore = 0;
}
