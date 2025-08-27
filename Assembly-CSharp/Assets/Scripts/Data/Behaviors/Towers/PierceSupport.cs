namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "PierceSupport", menuName = "BTD6/Behaviors/Towers/PierceSupport")]
public class PierceSupport : SupportBehavior
{
	public bool isUnique; //Field offset: 0x48
	public float pierce; //Field offset: 0x4C
	public string mutatorId; //Field offset: 0x50
	public bool isGlobal; //Field offset: 0x58

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 289
	}

	public PierceSupport() { }

	public virtual TowerBehaviorModel get_Def() { }

}

