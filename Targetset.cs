using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Targetset : MonoBehaviour
{
    public GameObject target;
    public float number;
    public bool set;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (set)
        {
            number += Time.deltaTime;
            if (number > 2f)
            {
                Instantiate(target, gameObject.transform.position + new Vector3(Random.Range(-5, 5) * 5, Random.Range(-5, 5) * 5, 0f), target.transform.rotation);
                number = 0f;
            }
        }
    }
}
