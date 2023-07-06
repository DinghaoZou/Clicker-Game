using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Text moneyText;
    public float money;
    public float moneyPerClick = 0;
    public float moneyPerSecond = 0;

    public float hiredEmployees = 0;
    public TMP_Text hiredEmployeesButton;

    public float Computer = 1;
    public TMP_Text ComputerButton;

    // Start is called before the first frame update
    void Start()
    {
        money = PlayerPrefs.GetFloat("moneyYouGot");
        hiredEmployees = PlayerPrefs.GetFloat("hiredEmployeesStatus");
        Computer = PlayerPrefs.GetFloat("ComputerStatus");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        moneyText.text = "$" + money;
        moneyPerClick = ( 1 + hiredEmployees ) * Computer;
        PlayerPrefs.SetFloat("moneyYouGot", money);
    }

    public void addMoney () {
        money += moneyPerClick;
        moneyText.text = "$" + money;
    }

    public void hireEmployeesClick () {
        if (money >= 10 && hiredEmployees == 0) {
            money -= 10;
            hiredEmployeesButton.text = "Sold";
            
            Debug.Log("Sold");

            hiredEmployees = 1;
            PlayerPrefs.SetFloat("hiredEmployeesStatus", hiredEmployees);
        }
    }

    public void computerClick () {
        if (money >= 20 && Computer == 1) {
            money -= 20;
            ComputerButton.text = "Sold";

            Debug.Log("Sold");

            Computer = 2;
            PlayerPrefs.SetFloat("ComputerStatus", Computer);
        }
    }
}
