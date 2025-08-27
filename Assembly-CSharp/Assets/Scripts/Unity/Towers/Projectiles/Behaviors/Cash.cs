namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class Cash : ProjectileBehavior
{
	public Cash parent; //Field offset: 0x88
	public float minimum; //Field offset: 0x90
	public string expMinimum; //Field offset: 0x98
	public float maximum; //Field offset: 0xA0
	public string expMaximum; //Field offset: 0xA8
	public float bonusMultiplier; //Field offset: 0xB0
	public string expBonusMultiplier; //Field offset: 0xB8
	public float salvage; //Field offset: 0xC0
	public string expSalvage; //Field offset: 0xC8
	public bool noTransformCash; //Field offset: 0xD0
	public string expNoTransformCash; //Field offset: 0xD8
	public bool distributeSalvage; //Field offset: 0xE0
	public string expDistributeSalvage; //Field offset: 0xE8
	public bool forceCreateProjectile; //Field offset: 0xF0
	public string expForceCreateProjectile; //Field offset: 0xF8
	public bool isDoubleable; //Field offset: 0x100
	public string expIsDoubleable; //Field offset: 0x108
	public bool distributeBonusIncome; //Field offset: 0x110
	public string expDistributeBonusIncome; //Field offset: 0x118

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 305
	}

	public Cash() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

