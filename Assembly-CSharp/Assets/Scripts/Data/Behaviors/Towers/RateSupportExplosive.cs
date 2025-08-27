namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "RateSupportExplosive", menuName = "BTD6/Behaviors/Towers/RateSupportExplosive")]
public class RateSupportExplosive : SupportBehavior
{
	public string filterTowers; //Field offset: 0x48
	public bool isUnique; //Field offset: 0x50
	public float multiplier; //Field offset: 0x54
	public string mutatorId; //Field offset: 0x58
	public string isGlobal; //Field offset: 0x60

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 767
	}

	public RateSupportExplosive() { }

	public virtual TowerBehaviorModel get_Def() { }

}

