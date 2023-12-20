using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PUManager : MonoBehaviour
{
    public Transform spawnArea;
    public int maxPUAmount;
    public int spawnInterval;
    public int PuLifeTime;
    public Vector2 puAreaMin;
    public Vector2 puAreaMax;
    public List<GameObject> PowerUpTemplateList;
    List<GameObject> powerUpList;

    float timer;

    void Start()
    {
        powerUpList = new List<GameObject>();
        timer = 0;
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            // Men-Spawn power up setelah interval tertentu
            GenerateRandomPU();
            timer -= spawnInterval;
        }

        foreach (GameObject powerUp in powerUpList)
        {
            // Menghancurkan power up jika tidak di ambil dalam interval tertentu
            StartCoroutine(DestroyPowerUp(powerUp, PuLifeTime));
        }
    }

    public void GenerateRandomPU()
    {
        // Memanggil fungsi untuk spawn poer up dengan posisi random
        GenerateRandomPU(new Vector2(Random.Range(puAreaMin.x, puAreaMax.x), Random.Range(puAreaMin.y, puAreaMax.y)));
    }
    public void GenerateRandomPU(Vector2 position)
    {
        // Mengontrol tempat dan jumlah power up
        if (powerUpList.Count >= maxPUAmount)
        {
            Debug.Log("Max Power Up Reached");
            return;
        }
        if (position.x < puAreaMin.x ||
            position.x > puAreaMax.x ||
            position.y < puAreaMin.y ||
            position.y > puAreaMax.y )
        {
            return;
        }

        int randomIndex = Random.Range(0, PowerUpTemplateList.Count);

        // Me Spawn power up
        GameObject powerUp = Instantiate(PowerUpTemplateList[randomIndex], new Vector3(position.x, position.y, PowerUpTemplateList[randomIndex].transform.position.z), Quaternion.identity, spawnArea);
        powerUp.SetActive(true);
        
        // menambahkan power up ke dalam list
        powerUpList.Add(powerUp);
    }

    public void RemovePowerUp(GameObject powerUp)
    {
        // Menghancurkan Power Up
        powerUpList.Remove(powerUp);
        Destroy(powerUp);
    }

    public void RemoveAllPowerUp()
    {
        // Menghancurkan seluruh power up
        while (powerUpList.Count > 0)
        {
            RemovePowerUp(powerUpList[0]);
        }
    }

    IEnumerator DestroyPowerUp(GameObject powerUp, float interval)
    {
        yield return new WaitForSeconds(interval);
        RemovePowerUp(powerUp);
    }
}
