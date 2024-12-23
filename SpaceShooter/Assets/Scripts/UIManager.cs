using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject HP;
    public GameObject HP1;
    public GameObject HP2;
    public GameObject HP3;
    public GameObject HP4; 
    public GameObject HP5;
    public GameObject HP6;
    public GameObject HP7;
    public GameObject HP8;
    public GameObject HP9;

    public List<GameObject> HPPointsList = new List<GameObject>();



    // Start is called before the first frame update
    void Start()
    {
        GameManager.uiManager = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisableHpSprite(int value) 
    {
        HPPointsList[value-1].SetActive(false);
    }
}
