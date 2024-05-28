using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Constants : MonoBehaviour
{
    public const string NORMAL = "NORMAL";
    public const string MOVEABLE = "MOVEABLE";
    public const string JUMPING = "JUMPING";
    public const string MOVEABLE_JUMPING = "MOVEABLE_JUMPING";
    public const string SINGLE = "SINGLE";
    public const string BREAKABLE = "BREAKABLE";

    public static readonly List<string> TYPES = new List<string>()
    {
        NORMAL, MOVEABLE, JUMPING, SINGLE, MOVEABLE_JUMPING, BREAKABLE
    };
    
}
