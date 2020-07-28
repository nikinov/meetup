using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IronPython.Hosting;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI text;

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
        yield return new WaitForSeconds(1);
        text.text = pyC.pyL.printS("Kali");
    }

}
