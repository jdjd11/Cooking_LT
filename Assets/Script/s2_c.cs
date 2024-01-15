using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class s2_c : MonoBehaviour
{
    private MeshCollider CRT;
    float time = 0.0f;
    int watingTime  = 2 ;
    
    // Start is called before the first frame update
    void Start()
    {
        CRT = GetComponent<MeshCollider>();
        // CRT= GetComponent<SpriteRenderer>();
    }

    
    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            this.CRT.enabled = true;
            //Debug.Log(time);
            //StartCoroutine(Timer());
            SceneManager.LoadScene("03. Stage_1");

        }
    }
}
