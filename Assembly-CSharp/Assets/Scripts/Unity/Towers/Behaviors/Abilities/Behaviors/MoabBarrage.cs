namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class MoabBarrage : AbilityBehavior
{
	public MoabBarrage parent; //Field offset: 0x88
	public float duration; //Field offset: 0x90
	public string expDuration; //Field offset: 0x98
	public string mutatorId; //Field offset: 0xA0
	public string expMutatorId; //Field offset: 0xA8
	public int targets; //Field offset: 0xB0
	public string expTargets; //Field offset: 0xB8
	public BloonBehavior behavior; //Field offset: 0xC0
	public BloonBehavior expBehavior; //Field offset: 0xC8

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 225
	}

	public MoabBarrage() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

