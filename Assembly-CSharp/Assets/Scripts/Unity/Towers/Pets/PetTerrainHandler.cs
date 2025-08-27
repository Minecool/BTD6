namespace Assets.Scripts.Unity.Towers.Pets;

public class PetTerrainHandler : PetBehavior
{
	[SerializeField]
	private float landHeightOffset; //Field offset: 0x10
	[SerializeField]
	private float waterHeightOffset; //Field offset: 0x14
	[SerializeField]
	private float moveSpeed; //Field offset: 0x18
	private PetBehaviorModel def; //Field offset: 0x20

	public virtual PetBehaviorModel Def
	{
		 get { } //Length: 181
	}

	public PetTerrainHandler() { }

	public virtual PetBehaviorModel get_Def() { }

}

