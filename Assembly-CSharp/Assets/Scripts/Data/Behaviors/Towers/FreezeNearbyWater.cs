namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "FreezeNearbyWater", menuName = "BTD6/Behaviors/Towers/FreezeNearbyWater")]
public class FreezeNearbyWater : TowerBehavior
{
	public float radius; //Field offset: 0x30
	public float areaHeightOffset; //Field offset: 0x34
	public PrefabReference freezeDisplay; //Field offset: 0x38

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 149
	}

	public FreezeNearbyWater() { }

	public virtual TowerBehaviorModel get_Def() { }

}

