namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class ExpireTowerAfterAbility : AbilityBehavior
{
	public ExpireTowerAfterAbility parent; //Field offset: 0x88
	public float time; //Field offset: 0x90
	public string expTime; //Field offset: 0x98
	public int rounds; //Field offset: 0xA0
	public string expRounds; //Field offset: 0xA8
	public bool useRoundTime; //Field offset: 0xB0
	public string expUseRoundTIme; //Field offset: 0xB8
	public Effect effect; //Field offset: 0xC0
	public Effect expEffect; //Field offset: 0xC8
	public AudioClip sound; //Field offset: 0xD0
	public AudioClip expSound; //Field offset: 0xD8

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 412
	}

	public ExpireTowerAfterAbility() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

