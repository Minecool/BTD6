namespace Assets.Scripts.Data.Behaviors.Weapons;

[CreateAssetMenu(fileName = "EjectEffectWithOffsets", menuName = "BTD6/Behaviors/Weapons/EjectEffectWithOffsets")]
public class EjectEffectWithOffsets : WeaponBehavior
{
	public PrefabReference display; //Field offset: 0x30
	public Effect effect; //Field offset: 0x38
	public bool rotateToWeapon; //Field offset: 0x40

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 238
	}

	public EjectEffectWithOffsets() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

