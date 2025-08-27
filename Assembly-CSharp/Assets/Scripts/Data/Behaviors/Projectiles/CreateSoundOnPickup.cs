namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "CreateSoundOnPickup", menuName = "BTD6/Behaviors/Projectiles/CreateSoundOnPickup")]
public class CreateSoundOnPickup : ProjectileBehavior
{
	public Sound sound; //Field offset: 0x30

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 147
	}

	public CreateSoundOnPickup() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

