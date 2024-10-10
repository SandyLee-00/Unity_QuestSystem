using UnityEngine;

[CreateAssetMenu(menuName = "Quest/SubTask/Action/PositiveCount", fileName = "PositiveCount")]
public class PositiveCount : SubTaskAction
{
    public override int Run(SubTask subTask, int currentSuccess, int successCount)
    {
        return successCount > 0 ? currentSuccess + successCount : currentSuccess;
    }
}

