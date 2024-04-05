using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine;

public class Simple : MonoBehaviour
{
    public int IntValue;
    public double DoubleValue;
    public float FloatValue;
    
    public List<int> ListOfInt;
    public List<double> ListOfDouble;
    public List<float> ListOfFloat;

    // Start is called before the first frame update
    void Start()
    {
        IntValue = 5;
        DoubleValue = 5.2;
        FloatValue = 5.6f;
        
        for(int _ = 0; _ < 5; ++_)
        {
            float newFloat = Random.Range(0f, 10f);
            int newInt = Random.Range(0, 10);
            double newDouble = Random.Range(0f, 10f);

            ListOfInt.Add(newInt);
            ListOfFloat.Add(newFloat);
            ListOfDouble.Add(newDouble);
        }

        // Вывод

        Debug.Log(IntValue);
        Debug.Log(FloatValue);
        Debug.Log(DoubleValue);

        WriteList<double>(ListOfDouble);
        WriteList<float>(ListOfFloat);
        WriteList<int>(ListOfInt);        
    }

    static void WriteList<T>(List<T> list)
    {
        string listString = $"[{string.Join(", ", list)}]";        
        Debug.Log($"List of type {typeof(T)}: {listString}");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
