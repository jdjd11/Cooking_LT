using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Manager : MonoBehaviour
{
    class Box
    {
        public bool check;
        public GameObject gameObject_;

    }

    public GameObject C_positon1;
    public GameObject C_positon2;
    public GameObject C_positon3; //손님이 이동하는 위치 3
    public GameObject NPC_Women1;
    public GameObject NPC_Women2;
    public GameObject NPC_Women3;

    private object x1;

    public Vector2 NPC_stratposition;
    public Vector2 targetposition;
    public float movetime;
    public float t;

    public bool npc1;
    public bool npc2;
    public bool npc3;

    public float WaitingTime;
    public float Timer;

    // float Timer;
    void Start()
    {
        Box box1 = new Box()
        {
            check = false,
            gameObject_ = C_positon1.GetComponent<GameObject>()

        };
        Box box2 = new Box()
        {
            check = false,
            gameObject_ = C_positon2.GetComponent<GameObject>()

        };
        Box box3 = new Box()
        {
            check = false,
            gameObject_ = C_positon3.GetComponent<GameObject>()

        };
        // WaitingTime = 3.0f;
        // WaitngTime(WaitingTime);
        npc1 = false;
        npc2 = false;
        npc3 = false;
    }

    void Update()
    {
        if (npc1 == false)
        {
            NPC_Move();

        }
        if (npc2 == false && npc1 == true)
        {
            NPC_Move2();
        }
        if (npc2 == true && npc1 == true && npc3 == false)
        {
            NPC_Move3();
        }
    }
    public void NPC_Move()
    {
        NPC_stratposition = NPC_Women1.transform.position;
        targetposition = C_positon1.transform.position;

        movetime = 0;
        movetime += Time.deltaTime;
        t = movetime / 1.2f;
        NPC_Women1.transform.position = Vector2.Lerp(NPC_stratposition, targetposition, t);
        if (NPC_Women1.transform.position.x <= -554f)
        {
            NPC_Women1.transform.position = targetposition;
            t = 1f;
            Invoke("Bool_", 5);
        }

    }
    public void NPC_Move2()
    {
        NPC_stratposition = NPC_Women2.transform.position;
        targetposition = C_positon2.transform.position;

        movetime = 0;
        movetime += Time.deltaTime;
        t = movetime / 1.2f;
        NPC_Women2.transform.position = Vector2.Lerp(NPC_stratposition, targetposition, t);

        if (NPC_Women2.transform.position.x <=35f)
        {
            NPC_Women2.transform.position = targetposition;
            t = 1f;
            Invoke("Bool_2", 5);
        }
    }

    public void NPC_Move3()
    {
        NPC_stratposition = NPC_Women3.transform.position;
        targetposition = C_positon3.transform.position;

        movetime = 0;
        movetime += Time.deltaTime;
        t = movetime / 1.2f;
        NPC_Women3.transform.position = Vector2.Lerp(NPC_stratposition, targetposition, t);

        if (NPC_Women3.transform.position.x <= 610f)
        {
            NPC_Women3.transform.position = targetposition;
            t = 1f;
            //Invoke("Bool_3", 5);
        }
    }

    public void WaitngTime(float waitingtime)
    {
        for (Timer = 0.0f; Timer <= waitingtime; Timer += Time.deltaTime)
        {
            Debug.Log(Timer + "초");
        }
        if (Timer >= waitingtime)
        {
            Timer = 0;
        }
    }

    public void Bool_()
    {
        npc1 = true;
    }
    public void Bool_2()
    {
        npc2 = true;
    }
    public void Bool_3()
    {
        npc3 = true;
    }
}
