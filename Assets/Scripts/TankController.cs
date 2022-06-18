
using UnityEngine;

public class TankController
{
    private TankModel tankmodel;
    private TankView tankview;


    public TankController(TankModel _tankModel, TankView _tankView)
    {
        tankmodel = _tankModel;
        tankview = _tankView;
        tankmodel.SetTankController(this);
        tankview.SetTankController(this);

        GameObject.Instantiate(tankview.gameObject);
    }
}
