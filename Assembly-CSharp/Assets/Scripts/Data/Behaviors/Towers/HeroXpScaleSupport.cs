namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "HeroXpScaleSupport", menuName = "BTD6/Behaviors/Towers/HeroXpScaleSupport")]
public class HeroXpScaleSupport : SupportBehavior
{
	public bool isUnique; //Field offset: 0x48
	public float heroXpScale; //Field offset: 0x4C

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 219
	}

	public HeroXpScaleSupport() { }

	public virtual TowerBehaviorModel get_Def() { }

}

