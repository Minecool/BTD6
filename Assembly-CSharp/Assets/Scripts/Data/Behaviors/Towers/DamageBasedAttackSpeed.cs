namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "DamageBasedAttackSpeed", menuName = "BTD6/Behaviors/Towers/DamageBasedAttackSpeed")]
public class DamageBasedAttackSpeed : TowerBehavior
{
	public float damageThreshold; //Field offset: 0x30
	public float maxTimeWithoutDamage; //Field offset: 0x34
	public float increasePerThreshold; //Field offset: 0x38
	public int maxStacks; //Field offset: 0x3C

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 183
	}

	public DamageBasedAttackSpeed() { }

	public virtual TowerBehaviorModel get_Def() { }

}

