using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerStats : MonoBehaviour
{
    public gameMaster gm;
    public ThirdPersonCharacterController thirdPerson;

    public float Warmth;
    public float warmthOverTimer;

    public float Thirst;
    public float thirstOverTimer;

    public float Hunger;
    public float hungerOverTimer;


    public Slider WarmthBar;
    public Slider ThirstBar;
    public Slider HungerBar;

    private bool dead;
    public Text howDied;

    public float minAmount = 50f;


    // Use this for initialization
    void Start()
    {
        WarmthBar.maxValue = Warmth;
        ThirstBar.maxValue = Thirst;
        HungerBar.maxValue = Hunger;

        UpdateUI();
    }

    // Update is called once per frame
    void Update()
    {
        if(!dead)
        {
            if (Warmth == 0 || Thirst == 0 || Hunger == 0)
            {
                dead = true;
                thirdPerson.Die();
                // SceneManager.LoadScene(0);
            }
        }
        
        



        CalculateValues();

    }

    void CalculateValues()
    {
        if (!gm.showDiary)
        {
        Hunger -= hungerOverTimer * Time.deltaTime;
        Thirst -= thirstOverTimer * Time.deltaTime;
        Warmth -= warmthOverTimer * Time.deltaTime;
        }
       


      

        UpdateUI();


    }

    void UpdateUI()
    {
        Warmth = Mathf.Clamp(Warmth, 0, 100f);
        Thirst = Mathf.Clamp(Thirst, 0, 100f);
        Hunger = Mathf.Clamp(Hunger, 0, 100f);


        WarmthBar.value = Warmth;
        ThirstBar.value = Thirst;
        HungerBar.value = Hunger;


    }


    //end of class
}
