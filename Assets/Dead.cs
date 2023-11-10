using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dead : MonoBehaviour
{
    public int invaders;
    public TextMeshProUGUI text;
    public GameObject gameOver;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            invaders++;
            Destroy(other.gameObject    );
        }
    }
    private void Update()
    {
        text.text = invaders.ToString();
        if(invaders > 8)
        {
            gameOver.SetActive(true);
        }
    }
}
