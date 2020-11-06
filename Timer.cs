using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timer;
    public GameObject settarget;
    public GameObject setarrow;
    public GameObject btn;
    public float timenumber;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timenumber -= Time.deltaTime;
        int number = (int)timenumber;

        if (number > 0)
        {
            gameObject.GetComponent<Text>().text = number.ToString();
        }
        else
        {
            gameObject.GetComponent<Text>().text = "0";
            settarget.GetComponent<Targetset>().set = false;
            setarrow.GetComponent<arrowAdd>().timeOver = true;
            btn.SetActive(true);
        }
    }
}
