namespace Assets.Scripts.Data.Behaviors.Weapons;

[CreateAssetMenu(fileName = "EjectEffect", menuName = "BTD6/Behaviors/Weapons/EjectEffect")]
public class EjectEffect : WeaponBehavior
{
	public PrefabReference display; //Field offset: 0x30
	public Effect effect; //Field offset: 0x38
	public float lifespan; //Field offset: 0x40
	public Fullscreen fullscreen; //Field offset: 0x44
	public bool rotateToWeapon; //Field offset: 0x48
	public bool useEjectPoint; //Field offset: 0x49
	public bool useEmittedFrom; //Field offset: 0x4A
	public bool useMainAttackRotation; //Field offset: 0x4B

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 323
	}

	public EjectEffect() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

