namespace Assets.Scripts.Unity.CorvusSpells.OnEnd;

public class CorvusOnSpellEndEffects : CorvusOnSpellEnd
{
	public CorvusOnSpellEndEffects parent; //Field offset: 0xA8
	public int stateOnCorvus; //Field offset: 0xB0
	public string expStateOnCorvus; //Field offset: 0xB8
	public int stateOnSpirit; //Field offset: 0xC0
	public string expStateOnSpirit; //Field offset: 0xC8
	public Effect effectOnCorvus; //Field offset: 0xD0
	public Effect expEffectOnCorvus; //Field offset: 0xD8
	public Effect effectOnSpirit; //Field offset: 0xE0
	public Effect expEffectOnSpirit; //Field offset: 0xE8
	public AudioClip sound; //Field offset: 0xF0
	public AudioClip expSound; //Field offset: 0xF8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 459
	}

	public CorvusOnSpellEndEffects() { }

	public virtual TowerBehaviorModel get_Def() { }

}

