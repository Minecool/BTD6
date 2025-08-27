namespace Assets.Scripts.Data.Behaviors.Towers.CorvusSpells.PassiveBonuses;

[CreateAssetMenu(fileName = "Attunement", menuName = "BTD6/Behaviors/Towers/CorvusSpells/PassiveBonuses/Attunement")]
public class Attunement : TowerBehavior
{
	public float maxSpeedMultiplier; //Field offset: 0x30
	public float maxDamageMultiplier; //Field offset: 0x34

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 133
	}

	public Attunement() { }

	public virtual TowerBehaviorModel get_Def() { }

}

