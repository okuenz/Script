using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health;  //объ€вление переменной
    public int maxHealth;  //объ€вление переменной

    public void TakeHit(int damage)  //функци€ дл получени€ урона
    {
        health -= damage;  //уменьшение текущего здоровь€

        if (health <= 0)  //проверка, если текущее здоровье меньше или равно нулю
        { 
            gameObject.SetActive(false);  //делаем игровой объект неактивным
        }
    }

    public void SetHealth(int bonusHealth)  //функци€ дл€ добавлени€ здоровь€
    {
        health += bonusHealth;  //увеличиваем текущее здоровье

        if (health > maxHealth)  //проверка, если текущее здоровье больше максимального
        {
            health = maxHealth;  //устанавливаем текущее здоровье равным максимальному
        }
    }
}
