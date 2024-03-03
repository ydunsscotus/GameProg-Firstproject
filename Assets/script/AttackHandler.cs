using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackHandler : MonoBehaviour
{
    public Animator charAnimator; 
    // Start is called before the first frame update
    void Start()
    {
        charAnimator = GetComponent<Animator>();
        
    }

    void AttackNow()
    {
        charAnimator.SetTrigger("goAttack");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            print("waduh");
            AttackNow();
        }
        
    }
}
