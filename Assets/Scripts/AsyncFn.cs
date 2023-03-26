using UnityEngine;
using Task = System.Threading.Tasks.Task;

public class AsyncFn : MonoBehaviour
{
    private const string FileTextReader = @"D:\Unity\proj\Dz14Asyn\Assets\StreamingAssets\Tree.txt";

    private static async Task ReadText()
    {
        var text = await System.IO.File.ReadAllTextAsync(FileTextReader);
        Debug.Log(text);
    }

    private async void Start()
    {
        await ReadText();
    }
}

