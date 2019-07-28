using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindEnemyDemo : MonoBehaviour
{

    private void OnGUI()
    {
        if (GUI.Button(new Rect(100, 150, 100, 80), "FindComponent"))
        {
            Enemy[] enemies = Object.FindObjectsOfType<Enemy>();
            Enemy minHPEnemy = FindEnemyMinHP(enemies);
            minHPEnemy.GetComponent<MeshRenderer>().material.color = Color.red;

			Debug.Log(Bonjour.GetServiceNames());
		}
    }

    public Enemy FindEnemyMinHP(Enemy[] enemies)
    {
        Enemy min = enemies[0];

        for (int i = 1; i < enemies.Length; i++)
        {
            if (min.HP > enemies[i].HP)
            {
                min = enemies[i];
            }
        }

        return min;
    }
}