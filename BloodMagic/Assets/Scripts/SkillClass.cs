using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A class that defines what an ability has to implement
/// in order to be used in the game
/// </summary>
public abstract class SkillClass : MonoBehaviour
{
    public abstract void UseAbility();

    //Cost in order to use ability
    public int HpCost;

    //Hp returned, dependent on whether the attack is close ranged or 
    //if the attack actually hits the enemy
    public int HpReturn;

    //How much damage the attack does to an enemy
    public int Power;
	
}
