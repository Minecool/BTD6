namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class EjectEffectWithOffsets : WeaponBehavior
{
	public EjectEffectWithOffsets parent; //Field offset: 0x90
	public GameObject display; //Field offset: 0x98
	public GameObject expDisplay; //Field offset: 0xA0
	public Effect effect; //Field offset: 0xA8
	public Effect expEffect; //Field offset: 0xB0
	public bool rotateToWeapon; //Field offset: 0xB8
	public string expRotateToWeapon; //Field offset: 0xC0

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 285
	}

	public EjectEffectWithOffsets() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

