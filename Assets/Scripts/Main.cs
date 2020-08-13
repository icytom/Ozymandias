using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public GameObject[] Triggers;
    private int currentTrigger = 0;

  

    // Start is called before the first frame update
    void Start()
    {
        Triggers[currentTrigger].GetComponent<Animator>().Play("ShowTrigger");
        Triggers[currentTrigger].GetComponent<Animator>().SetBool("TriggerShowing", true);
        currentTrigger++;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void showNextTrigger()
    {

        if (currentTrigger == Triggers.Length)
        {
            Triggers[currentTrigger - 1].GetComponent<Animator>().SetBool("TriggerShowing", false);
        }
        else
        {

            Triggers[currentTrigger - 1].GetComponent<Animator>().SetBool("TriggerShowing", false);

            Triggers[currentTrigger].GetComponent<Animator>().SetBool("TriggerShowing", true);

            if (currentTrigger < Triggers.Length)
            {
                currentTrigger++;
            }

        }
    }


}
