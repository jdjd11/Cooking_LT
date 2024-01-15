using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class Image_Blink : MonoBehaviour
{
    private SpriteRenderer CRT;
    float time = 0.0f;
    int watingTime  = 2 ;
    
    // Start is called before the first frame update
    void Start()
    {
        CRT= GetComponent<SpriteRenderer>();
        StartCoroutine("Blink");
       
  
    }

    
    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            StopCoroutine("Blink");
            
            this.CRT.enabled = true;
            //Debug.Log(time);
            StartCoroutine(Timer());
            //SceneManager.LoadScene("03. Stage_1");
           
        }
        if (time > watingTime)
        {
            StopAllCoroutines();
            SceneManager.LoadScene("02.Stage");
        }
    }
    private IEnumerator Blink()
    {
        this.CRT.enabled = false;
        yield return new WaitForSecondsRealtime(1);
        this.CRT.enabled = true;
        yield return new WaitForSecondsRealtime(1);
        yield return StartCoroutine(Blink());
    }
    
    private IEnumerator Timer()
    {
        time += Time.deltaTime;
        Debug.Log(time);
        yield return null;
        yield return StartCoroutine (Timer());
    }
}
