using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class testing : MonoBehaviour
{
#if UNITY_IPHONE
   
       // On iOS plugins are statically linked into
       // the executable, so we have to use __Internal as the
       // library name.
       [DllImport ("__Internal")]

#else

    // Other platforms load plugins dynamically, so pass the name
    // of the plugin's dynamic library.
    [DllImport("converter")]

#endif

    private static extern dynamic getNum(float x);

    void Awake()
    {
        // Calls the FooPluginFunction inside the plugin
        // And prints 5 to the console
        Debug.Log(getNum(3f));
    }
}