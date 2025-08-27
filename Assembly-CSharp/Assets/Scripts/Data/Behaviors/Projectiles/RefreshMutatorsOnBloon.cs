namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "RefreshMutatorsOnBloon", menuName = "BTD6/Behaviors/Projectiles/RefreshMutatorsOnBloon")]
public class RefreshMutatorsOnBloon : ProjectileBehavior
{
	public string mutatorId; //Field offset: 0x30
	public string mutatorKey; //Field offset: 0x38

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 128
	}

	public RefreshMutatorsOnBloon() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

