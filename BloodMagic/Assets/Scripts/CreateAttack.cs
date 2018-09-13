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
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        clone.velocity = new Vector2((mousePos.x - gameObject.transform.position.x), (mousePos.y - gameObject.transform.position.y));
        CloseRangeSkill abilities = clone.GetComponent<CloseRangeSkill>();
        abilities.Start();
        abilities.UseAbility();
    }
}
