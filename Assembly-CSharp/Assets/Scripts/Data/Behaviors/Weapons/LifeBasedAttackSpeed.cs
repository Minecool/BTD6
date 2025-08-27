namespace Assets.Scripts.Data.Behaviors.Weapons;

[CreateAssetMenu(fileName = "LifeBasedAttackSpeed", menuName = "BTD6/Behaviors/Weapons/LifeBasedAttackSpeed")]
public class LifeBasedAttackSpeed : WeaponBehavior
{
	public float ratePerLife; //Field offset: 0x30
	public int lifeCap; //Field offset: 0x34
	public float baseRateIncrease; //Field offset: 0x38
	public string saveId; //Field offset: 0x40

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 205
	}

	public LifeBasedAttackSpeed() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

