namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "BonusLivesPerRound", menuName = "BTD6/Behaviors/Towers/BonusLivesPerRound")]
public class BonusLivesPerRound : TowerBehavior
{
	public int amount; //Field offset: 0x30
	public float lifespan; //Field offset: 0x34
	public PrefabReference display; //Field offset: 0x38

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 147
	}

	public BonusLivesPerRound() { }

	public virtual TowerBehaviorModel get_Def() { }

}

