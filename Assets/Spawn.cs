using UnityEngine;
using UnityEngine.UI;

public class Spawn : MonoBehaviour
{
    public float delay;
    public Material color;
    public Text score;
    public Text gameOver;

    private static Vector3[] directions =
    {
        new Vector3(15, 1, 0), 
        new Vector3(-15, 1, 0),
        new Vector3(0, 1, 15),
        new Vector3(0, 1, -15)
    };

    private static Vector3[] forceDirections =
    {
        new Vector3(-1000, 0, 0),
        new Vector3(1000, 0, 0),
        new Vector3(0, 0, -1000),
        new Vector3(0, 0, 1000),
    };
    void Start()
    {
        gameOver.gameObject.SetActive(false);
        InvokeRepeating("SpawnEnemy", 1, delay);
    }

    void SpawnEnemy()
    {
        int randIndex = Random.Range(0, 4);
        GameObject enemy = GameObject.CreatePrimitive(PrimitiveType.Cube);
        enemy.AddComponent(typeof(Rigidbody));
        EnemyCollision enemyScript = enemy.AddComponent<EnemyCollision>();
        enemyScript.score = score;
        enemyScript.gameOver = gameOver;
        enemy.transform.position = directions[randIndex];
        Rigidbody enemyBody = enemy.GetComponent<Rigidbody>();
        enemy.GetComponent<Renderer>().material = color;
        enemyBody.AddForce(forceDirections[randIndex]);
    }
}
