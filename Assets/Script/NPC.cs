using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NPC : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject manager;
    public bool box1;
    public GameObject box4;
    public GameObject NPC_Women1;
    public GameObject resetPosition;

    public Vector2 NPC_stratposition;
    public Vector2 targetposition;
    public float movetime;
    public float t;
    void Start()
    {
       // manager.GetComponent<Manager>().npc1 = box1;
        //이러면 box1은 true

    }

    // Update is called once per frame
    void Update()
    {
        box1 = manager.GetComponent<Manager>().npc1;
        if (box1 == true)
        {
            Invoke("Exit_", 10f);
           // Invoke("Bool_", 5f);
        }


    }

    public void Exit_()
    {
        NPC_stratposition = NPC_Women1.transform.position;
        targetposition = box4.transform.position;

        movetime = 0;
        movetime += Time.deltaTime;
        t = movetime / 1.2f;
        NPC_Women1.transform.position = Vector2.Lerp(NPC_stratposition, targetposition, t);
        if (NPC_Women1.transform.position.x <= -1289f)
        {
            t = 1f;
            box1 = false;
            NPC_Women1.transform.position = box4.transform.position;
           // manager.GetComponent<Manager>().npc1=box1;
        }
    }
    public void Bool_()
    {
        box1 = false;
        manager.GetComponent<Manager>().npc1 = box1;
    }
}

