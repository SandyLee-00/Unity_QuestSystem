using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SubTaskAction : ScriptableObject
{
    public abstract int Run(SubTask subTask, int currentSuccess, int successCount);
}
