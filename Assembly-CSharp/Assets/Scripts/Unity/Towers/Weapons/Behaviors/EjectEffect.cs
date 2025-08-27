namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class EjectEffect : WeaponBehavior
{
	public EjectEffect parent; //Field offset: 0x90
	public GameObject display; //Field offset: 0x98
	public GameObject expDisplay; //Field offset: 0xA0
	public Effect effect; //Field offset: 0xA8
	public Effect expEffect; //Field offset: 0xB0
	public float lifespan; //Field offset: 0xB8
	public string expLifespan; //Field offset: 0xC0
	public Fullscreen fullscreen; //Field offset: 0xC8
	public string expFullscreen; //Field offset: 0xD0
	public bool rotateToWeapon; //Field offset: 0xD8
	public string expRotateToWeapon; //Field offset: 0xE0
	public bool useEjectPoint; //Field offset: 0xE8
	public string expUseEjectPoint; //Field offset: 0xF0
	public bool useEmittedFrom; //Field offset: 0xF8
	public string expUseEmittedFrom; //Field offset: 0x100
	public bool useMainAttackRotation; //Field offset: 0x108
	public string expUseMainAttackRotation; //Field offset: 0x110

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 583
	}

	public EjectEffect() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

