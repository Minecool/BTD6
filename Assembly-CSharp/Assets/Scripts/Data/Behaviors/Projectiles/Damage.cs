namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "Damage", menuName = "BTD6/Behaviors/Projectiles/Damage")]
public class Damage : ProjectileBehavior
{
	[SerializeField]
	public float damage; //Field offset: 0x30
	[SerializeField]
	public float maxDamage; //Field offset: 0x34
	[SerializeField]
	public string damageType; //Field offset: 0x38
	[SerializeField]
	public bool distributeToChildren; //Field offset: 0x40
	[SerializeField]
	public bool overrideDistributeBlocker; //Field offset: 0x41
	[SerializeField]
	public bool createPopEffect; //Field offset: 0x42
	[SerializeField]
	public string ignoreImmunityForBloonTypes; //Field offset: 0x48
	[SerializeField]
	public bool ignoreImmunityDestroyer; //Field offset: 0x50
	[SerializeField]
	public bool ignoreDamageMultipliers; //Field offset: 0x51

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 286
	}

	public Damage() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

