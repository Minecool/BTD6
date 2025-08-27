namespace Assets.Scripts.Data.Behaviors.Towers.CorvusSpells.OnEnd;

[CreateAssetMenu(fileName = "CorvusOnSpellEndEffects", menuName = "BTD6/Behaviors/Towers/CorvusSpells/OnEnd/CorvusOnSpellEndEffects")]
public class CorvusOnSpellEndEffects : CorvusOnSpellEnd
{
	public int stateOnCorvus; //Field offset: 0x40
	public int stateOnSpirit; //Field offset: 0x44
	public Effect effectOnCorvus; //Field offset: 0x48
	public Effect effectOnSpirit; //Field offset: 0x50
	public Sound sound; //Field offset: 0x58

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 307
	}

	public CorvusOnSpellEndEffects() { }

	public virtual TowerBehaviorModel get_Def() { }

}

