namespace Assets.Scripts.Unity.Towers.Pets;

public class PetCreateEffectOnPlace : PetBehavior
{
	[SerializeField]
	private PrefabReference effect; //Field offset: 0x10
	[SerializeField]
	private float lifespan; //Field offset: 0x18
	private PetBehaviorModel def; //Field offset: 0x20

	public virtual PetBehaviorModel Def
	{
		 get { } //Length: 155
	}

	public PetCreateEffectOnPlace() { }

	public virtual PetBehaviorModel get_Def() { }

}

