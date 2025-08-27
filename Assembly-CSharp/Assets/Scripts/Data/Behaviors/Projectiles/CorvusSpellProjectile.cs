namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "CorvusSpellProjectile", menuName = "BTD6/Behaviors/Projectiles/CorvusSpellProjectile")]
public class CorvusSpellProjectile : ProjectileBehavior
{
	public CorvusSpellType spellType; //Field offset: 0x30

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 113
	}

	public CorvusSpellProjectile() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

