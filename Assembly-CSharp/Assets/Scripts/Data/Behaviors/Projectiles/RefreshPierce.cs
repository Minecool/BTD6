namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "RefreshPierce", menuName = "BTD6/Behaviors/Projectiles/RefreshPierce")]
public class RefreshPierce : ProjectileBehavior
{
	public float refreshInterval; //Field offset: 0x30
	public bool isBuffedByRate; //Field offset: 0x34

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 130
	}

	public RefreshPierce() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

