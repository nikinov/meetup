using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IronPython.Hosting;

public class GameManager : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(wait());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(2);
        PyC.init();
        PyC pyC = FindObjectOfType<PyC>();
        //pyC.py = "test.py";
        yield return new WaitForSeconds(1);
        Debug.Log(pyC.py.printS("Kali"));
    }
}
