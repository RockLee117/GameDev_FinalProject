using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesDeadCounter : MonoBehaviour
{
    public int enemiesDead = 0;
    public int total_enemies = 0;

    public static EnemiesDeadCounter singleton;

    void Awake(){
        if(singleton == null){
            singleton = this;
        }
        else{
            Destroy(this.gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
