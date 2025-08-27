namespace Assets.Scripts.Data.Behaviors.Weapons;

[CreateAssetMenu(fileName = "EjectMultipleTestEffect", menuName = "BTD6/Behaviors/Weapons/EjectMultipleTestEffect")]
public class EjectMultipleTestEffect : WeaponBehavior
{
	public PrefabReference display; //Field offset: 0x30
	public float lifespan; //Field offset: 0x38
	public float count; //Field offset: 0x3C
	public Fullscreen fullscreen; //Field offset: 0x40
	public bool rotateToWeapon; //Field offset: 0x44

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 190
	}

	public EjectMultipleTestEffect() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

