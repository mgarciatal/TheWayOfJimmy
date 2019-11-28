using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recarrega_Enemics : MonoBehaviour
{
    private void Awake()
    {
        EnemyController.DontDestroyOnLoad(gameObject);
    }
}
