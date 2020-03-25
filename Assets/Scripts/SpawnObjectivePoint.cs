using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjectivePoint : MonoBehaviour
{
    public GameObject objective;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(objective, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
