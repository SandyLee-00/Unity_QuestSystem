using UnityEngine;

[CreateAssetMenu(menuName = "Quest/SubTask/Action/SimpleSet", fileName = "SimpleSet")]
public class SimpleSet : SubTaskAction
{
    public override int Run(SubTask subTask, int currentSuccess, int successCount)
    {
        return successCount;
    }
}

