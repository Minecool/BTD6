namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class EjectMultipleTestEffect : WeaponBehavior
{
	public EjectMultipleTestEffect parent; //Field offset: 0x90
	public GameObject display; //Field offset: 0x98
	public GameObject expDisplay; //Field offset: 0xA0
	public float lifespan; //Field offset: 0xA8
	public string expLifespan; //Field offset: 0xB0
	public float count; //Field offset: 0xB8
	public string expCount; //Field offset: 0xC0
	public Fullscreen fullscreen; //Field offset: 0xC8
	public string expFullscreen; //Field offset: 0xD0
	public bool rotateToWeapon; //Field offset: 0xD8
	public string expRotateToWeapon; //Field offset: 0xE0

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 505
	}

	public EjectMultipleTestEffect() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

