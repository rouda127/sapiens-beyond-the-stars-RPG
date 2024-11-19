using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Lvl1UIManager : MonoBehaviour
{

    public GameObject player;
    [SerializeField] private TMP_Text text;



    // Start is called before the first frame update
    void Awake()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        int levers = 3 - player.GetComponent<PlayerMovement>().switchOrder;
        text.text = " Fruits Collected: " + player.GetComponent<PlayerMovement>().fruitCollected.ToString()
            + "\nLevers Remaining: "+ levers;
    }
}
