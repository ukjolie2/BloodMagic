using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthChange : MonoBehaviour
{
    public Slider healthSlider;
    public Slider capSlider;
    //how much health we have?
    public int CapCount = 25;
    public int MaxHealth;
    public int FillRate = 0;
    public int CapRate = 0;


    public Image healthFill;  // assign in the editor the "Fill"
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
        healthSlider.wholeNumbers = true;
        healthSlider.minValue = 0f;
        healthSlider.maxValue = GameObject.Find("Player").GetComponent<PlayerController>().hp;
        healthSlider.value = 0;
        capSlider.wholeNumbers = true;
        capSlider.minValue = 0f;
        capSlider.maxValue = GameObject.Find("Player").GetComponent<PlayerController>().hp;
        capSlider.value = 0;
    }
    private void Update()
    {
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
        UpdateHealthChange(counter, dcounter);
    }
    public void UpdateHealthChange(int health)
    {
        healthSlider.value = health;
        capSlider.value = health;
        capFill.color = DeadColor;
        healthFill.color = Color.Lerp(MinHealthColor, MaxHealthColor, (float)health / MaxHealth);
    }
}
