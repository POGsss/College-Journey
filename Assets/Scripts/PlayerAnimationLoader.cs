using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationLoader : MonoBehaviour
{
    public RuntimeAnimatorController[] animatorControllers;

    void Start()
    {
        int selectedPlayer = PlayerPrefs.GetInt("selectedPlayer", 0);
        GetComponent<Animator>().runtimeAnimatorController = animatorControllers[selectedPlayer];
    }
}