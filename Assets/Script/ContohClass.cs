using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContohClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Membuat dan Mengisi Identitas objek Ducati
        
        //Car ducati = new Car();
        //ducati.Name = "Ducati";
        //ducati.Speed = 385.3f;
        //ducati.Color = "Black";

        // Kalo sudah buat constractor didalam class, tidak perlu mengisi variable/fieldnya
        Car ducati = new Car("Ducati", 385.3f, "Black");

        // Membuat dan Mengisi Identitas objek BMW
        // Car BMW = new Car();
        // BMW.Name = "BMW";
        // BMW.Speed = 350.7f;
        // BMW.Color = "Dark Blue";
        
        Car BMW = new Car("BMW",350.7f,"Dark Blue");

        Car Ferari = new Car("Ferari", 312.8f, "Red");

        Debug.Log(ducati.Name);
        Debug.Log(BMW.Name);

        // Memanggil method di dalam class "Car"
        ducati.Status();
        BMW.Status();
        Ferari.Status();
    }
}

public class Car // Blueprint (Identitas) Objek
{
    public string Name,Color;
    public float Speed;

    public Car(string name, float speed, string color)
    {
        // Name = name;
        // Speed = speed;
        // Color = color;
    }

    public void Status()
    {
        Debug.Log(Color + " " + Name + " Car" + " is moving in " + Speed + "Kmph");
    }
}