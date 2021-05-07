using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Levelcontroller: MonoBehaviour
{
    private static int _nextLevelIndex = 0;
    private Enemy[] _enemies;
    public Text levelText;
     private void OnEnable()
    {
        _enemies = FindObjectsOfType<Enemy>();
    }

    // Update is called once per frame
    void Update()
    {
       foreach(Enemy enemy in _enemies)
        {
            if (enemy != null)
                return;
        }

        Debug.Log("You killed all enemies");
        _nextLevelIndex++;
        string nextLevelName = "Level0" + _nextLevelIndex ;
        SceneManager.LoadScene(nextLevelName);
    }
}
