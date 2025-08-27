namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "HeroXpPerRound", menuName = "BTD6/Behaviors/Towers/HeroXpPerRound")]
public class HeroXpPerRound : TowerBehavior
{
	public float additionalXpPerRound; //Field offset: 0x30

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 106
	}

	public HeroXpPerRound() { }

	public virtual TowerBehaviorModel get_Def() { }

}

