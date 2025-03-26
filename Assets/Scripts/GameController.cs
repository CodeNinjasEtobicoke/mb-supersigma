using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [Header("Objects shapes")]
    public GameObject[] shapePrefabs;
    [Header("Default sopawn time delay")]
    public float spawnDelay = 2;
    [Header("default spawn time")]
    public float spawnTime = 3;
    [Header("game over ui canvas")]
    public GameObject GameOverCanvas;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", spawnDelay, spawnTime);
    }

    // Update is called once per frame
    void Spawn()
    {
        int randomInt = Random.Range(0, shapePrefabs.Length);
        Instantiate(shapePrefabs[randomInt], Vector3.zero, Quaternion.identity);
    }

    public void GameOver()
    {
        CancelInvoke("Spawn");
        GameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }
}
