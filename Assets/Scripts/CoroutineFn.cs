using System.Collections;
using UnityEngine;

public class CoroutineFn : MonoBehaviour
{
    private const string FileTextReader = @"D:\Unity\proj\Dz14Asyn\Assets\StreamingAssets\Tree.txt";

    private void Start()
    {
        StartCoroutine(ReadText());
    }

    private static IEnumerator ReadText()
    {
        var text = System.IO.File.ReadAllText(FileTextReader);
        yield return null;
        Debug.Log(text);
    }
}