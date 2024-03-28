using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class FruitManager : MonoBehaviour
{
    [Header("ELement")]
    [SerializeField] GameObject fruitPrefab;

    [Header("Settings")]
    [SerializeField] float fruitSpawnPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            ManagerPlayerInput();
        }
    }
    void ManagerPlayerInput()
    { 
        Vector2 pos = GetClickedWorldPosition();
        pos.y = fruitSpawnPosition;
        Instantiate(fruitPrefab,pos, Quaternion.identity);
    }
     Vector2 GetClickedWorldPosition()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
