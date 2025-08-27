namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "ChipMapBasedObject", menuName = "BTD6/Behaviors/Projectiles/ChipMapBasedObject")]
public class ChipMapBasedObject : ProjectileBehavior
{
	public string chipId; //Field offset: 0x30

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 105
	}

	public ChipMapBasedObject() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

