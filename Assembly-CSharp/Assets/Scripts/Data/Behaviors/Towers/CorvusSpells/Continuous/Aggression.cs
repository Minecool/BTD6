namespace Assets.Scripts.Data.Behaviors.Towers.CorvusSpells.Continuous;

[CreateAssetMenu(fileName = "Aggression", menuName = "BTD6/Behaviors/Towers/CorvusSpells/Continuous/Aggression")]
public class Aggression : CorvusContinuousSpell
{
	public float sizeMultiplier; //Field offset: 0x88
	public float rehitCooldownMultiplier; //Field offset: 0x8C
	public PrefabReference displaySwap; //Field offset: 0x90

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 691
	}

	public Aggression() { }

	public virtual TowerBehaviorModel get_Def() { }

}

