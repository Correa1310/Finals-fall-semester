using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI coinAmountText;

    public Button replayButton;

    private int _coinAmount = 0;

    // Start is called before the first frame update
    void Start()
    {
        replayButton.GameObject.SetActive(false);
        coinAmountText.text = "Coins: " + _coinAmount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateCoinAmount()
    {
        _coinAmount++;
        coinAmount.text + "Coin: " + _coinAmount.ToString();
    }

    public void GameOver()
    {
        replayButton.gameObject.SetActive(true);
    }


    public void ReplayGame()
    {
        SceneManager.loadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
