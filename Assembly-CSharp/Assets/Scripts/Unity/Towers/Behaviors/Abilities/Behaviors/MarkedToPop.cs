namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class MarkedToPop : AbilityBehavior
{
	public MarkedToPop parent; //Field offset: 0x88
	public Attack markingAttack; //Field offset: 0x90
	public Attack expMarkingAttack; //Field offset: 0x98
	public Attack executionAttack; //Field offset: 0xA0
	public Attack expExecutionAttack; //Field offset: 0xA8
	public float markingTime; //Field offset: 0xB0
	public string expMarkingTime; //Field offset: 0xB8
	public float executionTimeMax; //Field offset: 0xC0
	public string expExecutionTimeMax; //Field offset: 0xC8

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 412
	}

	public MarkedToPop() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

