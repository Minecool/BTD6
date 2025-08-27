namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class RemoveMutatorsFromBloon : ProjectileBehavior
{
	public AddBehaviorToBloon parent; //Field offset: 0x88
	public string key; //Field offset: 0x90
	public string expKey; //Field offset: 0x98
	public int collisionPass; //Field offset: 0xA0
	public string expCollisionPass; //Field offset: 0xA8
	public string mutatorIds; //Field offset: 0xB0
	public string expMutatorIds; //Field offset: 0xB8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 157
	}

	public RemoveMutatorsFromBloon() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

