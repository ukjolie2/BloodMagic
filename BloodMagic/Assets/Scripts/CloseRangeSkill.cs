using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseRangeSkill : SkillClass {
    public Rigidbody2D shape;

    public CloseRangeSkill()
    {
        HpCost = 5;
        HpReturn = 3;
        Power = 5;
    }

    public override int HpCost { get; set; }
    public override int HpReturn { get; set; }
    public override int Power { get; set; }

    public override void UseAbility()
    {
        PlayerController.instance.hp -= HpCost;
    }

    void OnCollisionStay(Collision collision)
    {
        foreach (ContactPoint contact in collision.contacts)
        {
            if(contact.otherCollider.CompareTag("Enemy")) {
                int enemyHp = contact.otherCollider.transform.parent.gameObject.GetComponent<EnemyController>().hp;
                enemyHp -= Power;
                PlayerController.instance.hp += HpReturn;
            }
        }
        Destroy(gameObject);
    }
}