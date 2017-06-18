using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomScript : StateMachineBehaviour
{
    public string   parameterName = "RandomIdleID";
    public int[] stateIDArray = { 0, 1, 2, 3 };

    override public void OnStateMachineEnter(Animator animator, int stateMachinePathHash)
    {
        if (stateIDArray.Length <= 0)
        {
            animator.SetInteger(parameterName, 0);
        }
        else
        {
            int index = Random.Range(0, stateIDArray.Length);
            Debug.Log(parameterName + "=>" + stateIDArray[index]);
            animator.SetInteger(parameterName, stateIDArray[index]);
        }
    }
}
