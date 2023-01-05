using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreUIManager : MonoBehaviour
{
    public string nameText;

    public TMP_Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        nameText = MenuManager.Instance.playerName;
        scoreText.SetText(nameText);
    }
}
