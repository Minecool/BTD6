namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class CreateSequencedTypedTowerCurrentIndex : WeaponBehavior
{
	public CreateSequencedTypedTowerCurrentIndex parent; //Field offset: 0x90
	public bool onlyAllowOneTowerPerType; //Field offset: 0x98
	public string expOnlyAllowOneTowerPerType; //Field offset: 0xA0

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 529
	}

	public CreateSequencedTypedTowerCurrentIndex() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

