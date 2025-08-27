namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "RemoveMutatorsFromBloon", menuName = "BTD6/Behaviors/Projectiles/RemoveMutatorsFromBloon")]
public class RemoveMutatorsFromBloon : ProjectileBehavior
{
	public string key; //Field offset: 0x30
	public int collisionPass; //Field offset: 0x38
	public string mutatorIds; //Field offset: 0x40

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 148
	}

	public RemoveMutatorsFromBloon() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

