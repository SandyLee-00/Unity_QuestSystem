using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SubTaskTarget : ScriptableObject
{
    public abstract object Value { get;}

    public abstract bool IsEqual(object target);
}
