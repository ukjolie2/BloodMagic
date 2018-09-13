using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthChange : MonoBehaviour
{
    public Slider healthSlider;
    public Slider capSlider;
    //how much health we have?
    public int CapCount = 0; //Used for any effects that limit our Health Total
    public int MaxHealth; //Assigned upon Start
    
    //Unused for now. Meant for slow transitions between current and lost health
    public int FillRate = 0;
    public int CapRate = 0;
    //


    public Image healthFill;  // assign in the editor the "Fill" Used for Drawing the Health Bar and Color
    public Image capFill;

    //Different colors
    public Color MaxHealthColor = Color.red;
    public Color MinHealthColor = Color.black;
    public Color DeadColor = Color.blue;
    private void Awake()
    {
    }
    private void Start()
    {
        MaxHealth = GameObject.Find("Player").GetComponent<PlayerController>().hp;
        healthSlider.wholeNumbers = true;
        healthSlider.minValue = 0f;
        healthSlider.maxValue = GameObject.Find("Player").GetComponent<PlayerController>().hp;
        healthSlider.value = 0; //Variable Health Position
        capSlider.wholeNumbers = true;
        capSlider.minValue = 0f;
        capSlider.maxValue = GameObject.Find("Player").GetComponent<PlayerController>().hp;
        capSlider.value = 0; //Varaible Cap Position
    }
    private void Update()
    {

        //Used for Health Slider updates for transitions between lost health. Will need more and altered code
        /*
        if (PracticalHealth <= counter)
        {
            FillRate = 0;
        }
        else
        {
            FillRate = 1;
            counter += FillRate;
        }
        if (CapCount <= dcounter)
        {
            CapRate = 0;
        }
        else
        {
            CapRate = 1;
            dcounter += CapRate;
        }
        */

        UpdateHealthChange(GameObject.Find("Player").GetComponent<PlayerController>().hp, 0); //Temporary Updater for immediate feedback
      
    }

    public void UpdateHealthChange(int health, int cap)
    {
        healthSlider.value = health;
        capSlider.value = cap; //Right bar, currently unused
        capFill.color = DeadColor;
        healthFill.color = Color.Lerp(MinHealthColor, MaxHealthColor, (float)health / MaxHealth); //Gradient Color Transitions
    }
}
