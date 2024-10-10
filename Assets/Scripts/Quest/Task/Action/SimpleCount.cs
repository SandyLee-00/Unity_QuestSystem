using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Quest/SubTask/Action/SimpleCount", fileName = "SimpleCount")]
public class SimpleCount : SubTaskAction
{
    public override int Run(SubTask subTask, int currentSuccess, int successCount)
    {
        return currentSuccess + successCount;
    }
}

[CreateAssetMenu(menuName = "Quest/SubTask/Action/ContinonusCount", fileName = "ContinonusCount")]
public class ContinonusCount : SubTaskAction
{
    public override int Run(SubTask subTask, int currentSuccess, int successCount)
    {
        return successCount > 0 ? currentSuccess + successCount : 0;
    }
}