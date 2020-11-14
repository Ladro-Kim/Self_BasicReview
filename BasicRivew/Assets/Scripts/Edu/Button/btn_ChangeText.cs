using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class btn_ChangeText : MonoBehaviour
{
    public Text setText;
    public InputField getText;
    IEnumerator corout;

    private void Start()
    {
        corout = ieInputText(getText.text, 1);
    }

    public void ChangeText()
    {
        // StartCoroutine(ieInputText(getText.text, 1));
    }

    IEnumerator ieInputText(string text, float time)
    {
        StopCoroutine(corout);
        setText.text = "";
        char[] tempText = new char[text.Length];
        print(text.Length);
        tempText = text.ToCharArray();
        for (int i = 0; i < text.Length; i++)
        {
            print(i);
            setText.text += tempText[i];
            yield return new WaitForSeconds(time);
        }
    }

}
