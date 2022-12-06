using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerScript : MonoBehaviour
{
    private Transform tfm;
    // Start is called before the first frame update
    void Start()
    {
        tfm = GetComponent<Transform>();   
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, 50 * Time.deltaTime);
    }
    private void OnMouseDown()
    {
        GameBehavior.Instance.scoreCount++;
        tfm.position= new Vector3(Random.Range(-8.0f, 8.0f), Random.Range(-4.0f, 4.0f), tfm.position.z);
    }
}
