namespace Assets.Scripts.Data.Behaviors.Weapons;

[CreateAssetMenu(fileName = "BloonsInRangeAttackSpeed", menuName = "BTD6/Behaviors/Weapons/BloonsInRangeAttackSpeed")]
public class BloonsInRangeAttackSpeed : WeaponBehavior
{
	public float rateIncreasePerStack; //Field offset: 0x30
	public int bloonsPerStack; //Field offset: 0x34
	public int maxStacks; //Field offset: 0x38

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 145
	}

	public BloonsInRangeAttackSpeed() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

