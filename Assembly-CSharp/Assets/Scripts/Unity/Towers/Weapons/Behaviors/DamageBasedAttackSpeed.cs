namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class DamageBasedAttackSpeed : TowerBehavior
{
	public DamageBasedAttackSpeed parent; //Field offset: 0x98
	public float damageThreshold; //Field offset: 0xA0
	public string expDamageThreshold; //Field offset: 0xA8
	public float maxTimeWithoutDamage; //Field offset: 0xB0
	public string expMaxTimeWithoutDamage; //Field offset: 0xB8
	public float increasePerThreshold; //Field offset: 0xC0
	public string expIncreasePerThreshold; //Field offset: 0xC8
	public int maxStacks; //Field offset: 0xD0
	public string expMaxStacks; //Field offset: 0xD8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 195
	}

	public DamageBasedAttackSpeed() { }

	public virtual TowerBehaviorModel get_Def() { }

}

