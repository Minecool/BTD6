namespace Assets.Scripts.Data.Behaviors.Pets;

[CreateAssetMenu(fileName = "PetCreateEffectOnPlace", menuName = "BTD6/Behaviors/Pets/PetCreateEffectOnPlace")]
public class PetCreateEffectOnPlace : PetBehavior
{
	public PrefabReference effect; //Field offset: 0x28
	public float lifespan; //Field offset: 0x30

	public virtual PetBehaviorModel Def
	{
		 get { } //Length: 131
	}

	public PetCreateEffectOnPlace() { }

	public virtual PetBehaviorModel get_Def() { }

}

