namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "AirUnit", menuName = "BTD6/Behaviors/Towers/AirUnit")]
public class AirUnit : TowerBehavior
{
	public PrefabReference display; //Field offset: 0x30
	public bool isAirUnitSelectable; //Field offset: 0x38
	public float selectableRadius; //Field offset: 0x3C
	public bool blocksPlacement; //Field offset: 0x40
	public float blockingRadius; //Field offset: 0x44
	public TowerBehavior[] behaviors; //Field offset: 0x48

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 281
	}

	public AirUnit() { }

	public virtual TowerBehaviorModel get_Def() { }

}

