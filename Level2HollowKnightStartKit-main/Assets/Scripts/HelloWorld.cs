using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public string stringToPrint = "Something else ;) ???";

    private float timeSincePrint =0f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start ( )
    {
    }

    // Update is called once per frame
    void Update()
    {
        timeSincePrint += Time.deltaTime;

        if (timeSincePrint >= 3f)
        {
            PrintHelloWorld(stringToPrint);

            timeSincePrint = 0f;
        }

        if(Input.GetKeyDown(KeyCode.P))
        {
            PrintHelloWorld("P Pressed");
        }


    }

    public void PrintHelloWorld(string toPrint)
    {
        Debug.Log(toPrint);
    }
}
