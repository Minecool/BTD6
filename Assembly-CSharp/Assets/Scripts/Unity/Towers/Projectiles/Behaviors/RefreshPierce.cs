namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class RefreshPierce : ProjectileBehavior
{
	public RefreshPierce parent; //Field offset: 0x88
	public float refreshInterval; //Field offset: 0x90
	public string expRefreshInterval; //Field offset: 0x98
	public bool isBuffedByRate; //Field offset: 0xA0
	public string expIsBuffedByRate; //Field offset: 0xA8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 136
	}

	public RefreshPierce() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

