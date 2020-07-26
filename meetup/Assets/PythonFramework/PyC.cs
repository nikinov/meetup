using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using System;
using IronPython.Hosting;
using System.IO;

public class PyC : MonoBehaviour
{
    private static GameObject _PyEmpty;
    public dynamic pyL;
    public string pName;

    private void Awake()
    {
        initPython();
    }
    public static void init()
    {
        _PyEmpty = new GameObject();
        _PyEmpty.name = "PythonC";
        _PyEmpty.AddComponent(typeof(PyC));
        _PyEmpty.isStatic = true;
        if (Application.isPlaying)
            DontDestroyOnLoad(_PyEmpty);
    }
    private void initPython()
    {
        var engine = Python.CreateEngine();

        ICollection<string> searchPaths = engine.GetSearchPaths();

        //Path to the Assets folder
        searchPaths.Add(Application.dataPath);
        //Path to the Python standard library
        searchPaths.Add(Application.dataPath + @"/Plugins/Lib/");
        engine.SetSearchPaths(searchPaths);
        engine.ExecuteFile(Application.dataPath + @"/PythonScripts/" + "test");
    }
}
