using JuhaKurisu.PopoTools.Utility;
using UnityEngine;

public class test : PopoBehaviour
{
    protected override void Start()
    {
        Debug.Log($"{positionX}, {positionY}, {positionZ}");
        positionX = 10;
        positionY = 20;
        positionZ = 30;
    }

    protected override void FixedUpdate()
    {
        Debug.Log($"{positionX}, {positionY}, {positionZ}");
    }
}
