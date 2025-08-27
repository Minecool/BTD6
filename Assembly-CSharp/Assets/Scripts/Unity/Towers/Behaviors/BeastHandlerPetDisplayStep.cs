namespace Assets.Scripts.Unity.Towers.Behaviors;

public class BeastHandlerPetDisplayStep : TowerBehavior
{
	public BeastHandlerPetDisplayStep parent; //Field offset: 0x98
	public GameObject display; //Field offset: 0xA0
	public GameObject expDisplay; //Field offset: 0xA8
	public GameObject projectileDisplay; //Field offset: 0xB0
	public GameObject expProjectileDisplay; //Field offset: 0xB8
	public float percent; //Field offset: 0xC0
	public string expPercent; //Field offset: 0xC8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 223
	}

	public BeastHandlerPetDisplayStep() { }

	public virtual TowerBehaviorModel get_Def() { }

}

