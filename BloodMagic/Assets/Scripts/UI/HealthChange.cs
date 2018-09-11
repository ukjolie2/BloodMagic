using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthChange : MonoBehaviour
{

    public Slider healthSlider;
    public Slider capSlider;
    private int counter;
    private int dcounter;
    public int HealthCount = 0;
    public int CapCount = 25;
    public int MaxHealth = 100;
    public int PracticalHealth = 100;
    public int FillRate = 0;
    public int CapRate = 0;


    public Image healthFill;  // assign in the editor the "Fill"
    public Image capFill;
    public Color MaxHealthColor = Color.red;
    public Color MinHealthColor = Color.black;
    public Color DeadColor = Color.blue;

    private void Awake()
    {
        PracticalHealth = (MaxHealth - CapCount);
        counter = 0;       // just for testing purposes
        dcounter = 0;
    }


    private void Start()
    {
        healthSlider.wholeNumbers = true; 
        healthSlider.minValue = 0f;
        healthSlider.maxValue = MaxHealth;
        healthSlider.value = 0;
        capSlider.wholeNumbers = true;
        capSlider.minValue = 0f;
        capSlider.maxValue = MaxHealth;
        capSlider.value = 0;
    }

    private void Update()
    {
        if (PracticalHealth <= counter)
        {
            FillRate = 0;

        }

        else
        {
            FillRate = 1;
            counter += FillRate;
        }

        if ( CapCount <= dcounter)
        {
            CapRate = 0;

        }

        else
        {
            CapRate = 1;
            dcounter += CapRate;
        }

        UpdateHealthChange(counter,dcounter);

    }

    public void UpdateHealthChange(int fval,int dval)
    {


        healthSlider.value = fval;
        capSlider.value = dval;
        capFill.color = DeadColor;
        Debug.Log(""+HealthCount);
        Debug.Log(PracticalHealth);
        healthFill.color = Color.Lerp(MinHealthColor, MaxHealthColor, (float)fval / MaxHealth);
    }
}