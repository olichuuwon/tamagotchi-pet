using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeacherLoginController : MonoBehaviour
{
    private string username;
    private string password;

    public void ReadUsernameInput(string s)
    {
        username = s;
        Debug.Log(s);
    }

    public void ReadPasswordInput(string s)
    {
        password = s;
        Debug.Log(s);
    }

    public void Login()
    {
        //API call to backend return teacherId to be saved in playerprefs


    }

}
