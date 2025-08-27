namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "RangeSupport", menuName = "BTD6/Behaviors/Towers/RangeSupport")]
public class RangeSupport : SupportBehavior
{
	public bool isUnique; //Field offset: 0x48
	public float multiplier; //Field offset: 0x4C
	public float additive; //Field offset: 0x50
	public string mutatorId; //Field offset: 0x58
	public bool isGlobal; //Field offset: 0x60

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 282
	}

	public RangeSupport() { }

	public virtual TowerBehaviorModel get_Def() { }

}

