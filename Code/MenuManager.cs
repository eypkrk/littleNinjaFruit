using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
public class MenuManager : MonoBehaviour
{
    public void ToGame()
    {
        SoundManager.Instance.PlaySound(1) ;
        SceneManager.LoadScene("Game");
    }
}
