namespace Assets.Scripts.Data.Behaviors.Weapons;

[CreateAssetMenu(fileName = "CreateSoundOnProjectileCreated", menuName = "BTD6/Behaviors/Weapons/CreateSoundOnProjectileCreated")]
public class CreateSoundOnProjectileCreated : WeaponBehavior
{
	public Sound sound1; //Field offset: 0x30
	public Sound sound2; //Field offset: 0x38
	public Sound sound3; //Field offset: 0x40
	public Sound sound4; //Field offset: 0x48
	public Sound sound5; //Field offset: 0x50
	public string type; //Field offset: 0x58

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 389
	}

	public CreateSoundOnProjectileCreated() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

