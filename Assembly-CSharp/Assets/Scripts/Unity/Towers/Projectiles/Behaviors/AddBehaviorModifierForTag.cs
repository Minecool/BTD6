namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class AddBehaviorModifierForTag : ProjectileBehavior
{
	public AddBehaviorModifierForTag parent; //Field offset: 0x88
	public float multiplier; //Field offset: 0x90
	public string expMultiplier; //Field offset: 0x98
	public string tagValue; //Field offset: 0xA0
	public string expTagValue; //Field offset: 0xA8
	public string mutatorId; //Field offset: 0xB0
	public string expMutatorId; //Field offset: 0xB8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 158
	}

	public AddBehaviorModifierForTag() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

