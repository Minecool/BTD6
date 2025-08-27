namespace Assets.Scripts.Data.Behaviors.Pets;

[CreateAssetMenu(fileName = "PetTerrainHandler", menuName = "BTD6/Behaviors/Pets/PetTerrainHandler")]
public class PetTerrainHandler : PetBehavior
{
	public float landHeightOffset; //Field offset: 0x28
	public float waterHeightOffset; //Field offset: 0x2C
	public float moveSpeed; //Field offset: 0x30

	public virtual PetBehaviorModel Def
	{
		 get { } //Length: 158
	}

	public PetTerrainHandler() { }

	public virtual PetBehaviorModel get_Def() { }

}

