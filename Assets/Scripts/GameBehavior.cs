using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBehavior : MonoBehaviour
{
    public static GameBehavior Instance;
    public int scoreCount = 0;
    Texture2D closedH;
    Texture2D openH;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        string filename = "Assets/closedHand.png";
        var rawData = System.IO.File.ReadAllBytes(filename);
        closedH = new Texture2D(2, 2);
        closedH.LoadImage(rawData);

        filename = "Assets/openHand.png";
        rawData = System.IO.File.ReadAllBytes(filename);
        openH = new Texture2D(2, 2);
        openH.LoadImage(rawData);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Cursor.SetCursor(closedH, Vector2.zero, CursorMode.ForceSoftware);
        }
        if(Input.GetMouseButtonUp(0))
        {
            Cursor.SetCursor(openH, Vector2.zero, CursorMode.ForceSoftware);
        }
    }
}
