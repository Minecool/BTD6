namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class CritRollWithDistance : CritRoll
{
	public float bonusPerDistance; //Field offset: 0xD8
	public string expBonusPerDistance; //Field offset: 0xE0

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 266
	}

	public CritRollWithDistance() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

