using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Set_Character : MonoBehaviour
{

    public class C_base
    {
        public GameObject character;
        public Vector2 position;
        public Vector2 MovePosition;
    }

    public GameObject girl_charater;
    
    void Start()
    {
       // GetComponent<Manager>().WaitngTime(3);
        C_base f_char = new C_base();
        Setting(f_char);
       // MoveC_Position(f_char.position, f_char.MovePosition, 2);
    } 

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Setting(C_base character)
    {
        character.character = girl_charater;
        character.position = girl_charater.transform.position;
        character.MovePosition = GetComponent<Get_Position>().C_positon1.transform.position;
    }

    public IEnumerator MoveC_Position(Transform transform, Vector2 position, float timeToMove) //현재 위치, 이동 위치 , 목표 시간
    {
        var currentPos = transform.position;
        var t = 0f;
        while (t < 1)
        {
            t += Time.deltaTime / timeToMove;
            transform.position = Vector3.Lerp(currentPos, position, t);
            yield return null;
        }
    }
}
