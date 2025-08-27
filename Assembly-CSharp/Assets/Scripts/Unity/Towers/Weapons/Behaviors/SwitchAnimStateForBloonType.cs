namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class SwitchAnimStateForBloonType : WeaponBehavior
{
	public SwitchAnimStateForBloonType parent; //Field offset: 0x90
	public int nonMoabsAnimId; //Field offset: 0x98
	public string expNonMoabsAnimId; //Field offset: 0xA0
	public int moabAnimId; //Field offset: 0xA8
	public string expMoabAnimId; //Field offset: 0xB0
	public int bfbAnimId; //Field offset: 0xB8
	public string expBfbAnimId; //Field offset: 0xC0
	public int zomgAnimId; //Field offset: 0xC8
	public string expZomgAnimId; //Field offset: 0xD0
	public int ddtAnimId; //Field offset: 0xD8
	public string expDdtAnimId; //Field offset: 0xE0
	public int badAnimId; //Field offset: 0xE8
	public string expBadAnimId; //Field offset: 0xF0

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 191
	}

	public SwitchAnimStateForBloonType() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

