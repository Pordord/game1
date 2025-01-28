// Libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Introduction : MonoBehaviour
{
    public int STR;
    public int healthPoints;
    public int Damage;

    // Start is called before the first frame update
    void Start()
    {
        healthPoints = 5 * STR;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Hello World");
        //when we press space bar
        //we call the function TakeDamage();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage();
        }
        if (healthPoints < 0)
        {
            Debug.Log("You're Dead");
            healthPoints = 0;
        }
    }

    void TakeDamage()
    {
        //healthPoints = healthPoints - Damage;
        //1000 - 50 = 950
        healthPoints -= Damage;
    }

}
