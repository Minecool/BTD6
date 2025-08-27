namespace Assets.Scripts.Data.Behaviors.Weapons;

[CreateAssetMenu(fileName = "CritMultiplier", menuName = "BTD6/Behaviors/Weapons/CritMultiplier")]
public class CritMultiplier : WeaponBehavior
{
	public float damage; //Field offset: 0x30
	public float spacingLower; //Field offset: 0x34
	public float spacingUpper; //Field offset: 0x38
	public string distributeToChildren; //Field offset: 0x40
	public PrefabReference display; //Field offset: 0x48

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 392
	}

	public CritMultiplier() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

