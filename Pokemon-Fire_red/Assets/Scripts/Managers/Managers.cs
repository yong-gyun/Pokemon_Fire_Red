using System;
using System.Collections;
using UnityEngine;

public class Managers : MonoBehaviour
{
    public static Managers Instance { get { Init(); return _instance; } }
    private static Managers _instance;

    static void Init()
    {
        if (_instance == null)
        {
            GameObject go = GameObject.Find("@Managers");
            if (go == null)
                go = new GameObject("@Managers");
            
            _instance = go.GetOrAddComponent<Managers>();
            DontDestroyOnLoad(go);
        }
    }

    public void CoStartCoroutine(IEnumerator routine)
    {
        StartCoroutine(routine);
    }

    public void Clear()
    {

    }
}
