    using UnityEngine;
using System.Collections;

public class GameScript : MonoBehaviour {
    public EnemySpawner enemySpawner;
    public int enemiesToSpawn = 10;
    public int waveToWin = 3;
    public int waveCount;




    // Use this for initialization
    protected void Start() { 

        





    }


    public void Spawnwave()
    {
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            enemySpawner.Spawn();
        }

    }

    // Update is called once per frame
    protected void Update()
    {
        if (EnemySpawner.activated && enemySpawner.transform.childCount == 0)
        {
            if (waveCount == 0)
            {

            }
            if (waveCount < waveToWin)
            {
                waveCount++;
                HUD.Message("This is round nr" + waveCount);
                Spawnwave();
            }
        }

    }
}