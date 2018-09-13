using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Holds all the attacks created so far
//PlayerController calls upon this to spawn their attacks
public class CreateAttack : MonoBehaviour {
    
    public Rigidbody2D closeRange;
	
    public void AttackCloseRange()
    {
        var clone = Instantiate(closeRange, gameObject.transform.position, gameObject.transform.rotation);
        clone.velocity = gameObject.transform.TransformDirection(Vector3.forward * 20);
        CloseRangeSkill abilities = clone.GetComponent<CloseRangeSkill>();
        abilities.Start();
        abilities.UseAbility();
    }
}
