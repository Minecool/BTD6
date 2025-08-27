namespace Assets.Scripts.Unity.Towers.Behaviors;

public class CreateNearbyWater : TowerBehavior
{
	public CreateNearbyWater parent; //Field offset: 0x98
	public float radius; //Field offset: 0xA0
	public string expRadius; //Field offset: 0xA8
	public float areaHeightOffset; //Field offset: 0xB0
	public string expAreaHeightOffset; //Field offset: 0xB8
	public GameObject freezeDisplay; //Field offset: 0xC0
	public GameObject expFreezeDisplay; //Field offset: 0xC8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 204
	}

	public CreateNearbyWater() { }

	public virtual TowerBehaviorModel get_Def() { }

}

