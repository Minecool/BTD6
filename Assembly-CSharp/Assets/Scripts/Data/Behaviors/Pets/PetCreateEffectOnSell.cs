namespace Assets.Scripts.Data.Behaviors.Pets;

[CreateAssetMenu(fileName = "PetCreateEffectOnSell", menuName = "BTD6/Behaviors/Pets/PetCreateEffectOnSell")]
public class PetCreateEffectOnSell : PetBehavior
{
	public PrefabReference effect; //Field offset: 0x28
	public float lifespan; //Field offset: 0x30

	public virtual PetBehaviorModel Def
	{
		 get { } //Length: 131
	}

	public PetCreateEffectOnSell() { }

	public virtual PetBehaviorModel get_Def() { }

}

