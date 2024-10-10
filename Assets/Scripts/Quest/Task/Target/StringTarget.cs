using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Quest/SubTask/Target/String", fileName = ("Target_"))]
public class StringTarget : SubTaskTarget
{
    [SerializeField]
    private string value;

    public override object Value => value;

    public override bool IsEqual(object target)
    {
        string targetAsString = target as string;
        if(targetAsString == null)
        {
            return false;
        }

        return value == targetAsString;
    }
}
