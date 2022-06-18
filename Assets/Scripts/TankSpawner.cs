using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    public TankView tankview;
    // Start is called before the first frame update
    void Start()
    {
        createTank();
    
    }

    private void createTank()
    {
        TankModel tankModel = new TankModel();
        TankController tankController = new TankController(tankModel,tankview);
    }
}
