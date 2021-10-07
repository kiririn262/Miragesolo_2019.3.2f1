using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class Code
{
    public static void Change_Scene(int num)
    {
        SceneManager.LoadScene(num);
    }
    public static void Change_Scene(string str)
    {
        SceneManager.LoadScene(str);
    }
}
