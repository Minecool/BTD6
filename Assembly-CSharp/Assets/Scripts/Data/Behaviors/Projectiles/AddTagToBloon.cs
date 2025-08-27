namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "AddTagToBloon", menuName = "BTD6/Behaviors/Projectiles/AddTagToBloon")]
public class AddTagToBloon : ProjectileBehavior
{
	public string bloonTag; //Field offset: 0x30
	public float lifespan; //Field offset: 0x38
	public int layers; //Field offset: 0x3C
	public string mutationId; //Field offset: 0x40
	public bool isUnique; //Field offset: 0x48
	public string overlayType; //Field offset: 0x50

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 196
	}

	public AddTagToBloon() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

