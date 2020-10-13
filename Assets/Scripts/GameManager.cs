using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score { get; set; }
    private float timer;
    private bool isAlive;
    private Item cookie; //struct
    private Item2 cookie2; //class
    public bool playerAlive
    {
        get
        {
            return isAlive;
        }
    }

    public float timeLeft
    {
        get
        {
            return Mathf.Round(timer);
        }
    }

    public bool victory { get; set; }
    private static GameManager _instance;

    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                GameObject go = new GameObject("GameManager");
                go.AddComponent<GameManager>();
            }

            return _instance;
        }
    }

    void Awake()
    {
        _instance = this;
        DontDestroyOnLoad(this.gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        timer = 120f;
        isAlive = true;

        cookie2 = new Item2(0, "roze koek");
        cookie.itemName = "stroopwafel";
        cookie.ID = 2;

    }
    

    // Update is called once per frame
    void Update()
    {
        if (timer > 0 && isAlive)
        {
            timer -= Time.deltaTime;
        }else if (isAlive)
        {
            isAlive = false;
        }
    }
}
