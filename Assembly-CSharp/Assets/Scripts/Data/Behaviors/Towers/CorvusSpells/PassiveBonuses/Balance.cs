namespace Assets.Scripts.Data.Behaviors.Towers.CorvusSpells.PassiveBonuses;

[CreateAssetMenu(fileName = "Balance", menuName = "BTD6/Behaviors/Towers/CorvusSpells/PassiveBonuses/Balance")]
public class Balance : TowerBehavior
{
	public float maxGenerationManaPoolThreshold; //Field offset: 0x30
	public float maxGenerationRate; //Field offset: 0x34
	public float minGenerationManaPoolThreshold; //Field offset: 0x38
	public float minGenerationRate; //Field offset: 0x3C

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 189
	}

	public Balance() { }

	public virtual TowerBehaviorModel get_Def() { }

}

