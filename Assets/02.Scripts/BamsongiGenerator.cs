using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BamsongiGenerator : MonoBehaviour
{
    public GameObject bamsongiPrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            GameObject bamsongi = Instantiate(bamsongiPrefab);
            bamsongi.GetComponent<BamsongiController>().shoot(new Vector3(0, 200, 2000));

        }
    }
}
