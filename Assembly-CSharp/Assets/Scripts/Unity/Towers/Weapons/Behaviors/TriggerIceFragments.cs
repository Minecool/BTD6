namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class TriggerIceFragments : WeaponBehavior
{
	public TriggerIceFragments parent; //Field offset: 0x90
	public bool useTowerRange; //Field offset: 0x98
	public string expUseTowerRange; //Field offset: 0xA0

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 109
	}

	public TriggerIceFragments() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

