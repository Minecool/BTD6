namespace Assets.Scripts.Unity.Towers.Pets;

public class PetCreateEffectOnSell : PetBehavior
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

	public PetCreateEffectOnSell() { }

	public virtual PetBehaviorModel get_Def() { }

}

