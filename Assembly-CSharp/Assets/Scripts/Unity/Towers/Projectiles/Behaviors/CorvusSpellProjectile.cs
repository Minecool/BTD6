namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class CorvusSpellProjectile : ProjectileBehavior
{
	private CorvusSpellProjectileModel def; //Field offset: 0x88
	public CorvusSpellType spellType; //Field offset: 0x90

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 157
	}

	public CorvusSpellProjectile() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

