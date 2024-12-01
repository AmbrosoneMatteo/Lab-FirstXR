using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreText : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    // Start is called before the first frame update
    int score = 0;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addScore()
    {
        gameManager.addScore();
        score++;
        GetComponent<TextMeshProUGUI>().text = "Oggetti Trovati: "+score.ToString();
    }
}
