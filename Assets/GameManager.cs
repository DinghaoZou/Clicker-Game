using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text moneyText;
    public float money;
    public float moneyPerClick = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addMoney () {
        money += moneyPerClick;
        moneyText.text = "$" + money;
    }
}
