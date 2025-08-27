namespace Assets.Scripts.Unity.Map.Triggers;

public class ChangeEmitProjectileAction : MapAction
{
	public MapEvent mapEvent; //Field offset: 0x20
	public Projectile newProjectile; //Field offset: 0x28
	private MapActionModel def; //Field offset: 0x30

	public virtual MapActionModel Def
	{
		 get { } //Length: 219
	}

	public ChangeEmitProjectileAction() { }

	public virtual MapActionModel get_Def() { }

}

