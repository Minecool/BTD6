namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "Freeze", menuName = "BTD6/Behaviors/Projectiles/Freeze")]
public class Freeze : ProjectileBehavior
{
	public float speed; //Field offset: 0x30
	public float lifespan; //Field offset: 0x34
	public int layers; //Field offset: 0x38
	public string mutationId; //Field offset: 0x40
	public string overlayType; //Field offset: 0x48
	public bool cascadeMutators; //Field offset: 0x50
	public float percentChanceToFreeze; //Field offset: 0x54
	public bool enablePercentChanceToFreeze; //Field offset: 0x58
	public bool canFreezeMoabs; //Field offset: 0x59
	public Damage damage; //Field offset: 0x60
	public bool applyAfterDamage; //Field offset: 0x68

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 470
	}

	public Freeze() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

