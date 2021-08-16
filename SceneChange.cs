using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void ChangeTitle()
    {
        SceneManager.LoadScene("TitleScene");
    }

    public void ChangeStory()
    {
        SceneManager.LoadScene("StoryScene");
    }

    public void ChangePlayFive()
    {
        SceneManager.LoadScene("5FScene");
    }

    public void ChangePlayFour()
    {
        SceneManager.LoadScene("4FScene");
    }

    public void ChangePlayThree()
    {
        SceneManager.LoadScene("3FScene");
    }

    public void ChangePlayTwo()
    {
        SceneManager.LoadScene("2FScene");
    }
    public void ChangePlayOne()
    {
        SceneManager.LoadScene("1FScene");
    }
}
