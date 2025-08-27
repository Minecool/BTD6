namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "BeastHandlerPetDisplayStep", menuName = "BTD6/Behaviors/Towers/BeastHandlerPetDisplayStep")]
public class BeastHandlerPetDisplayStep : TowerBehavior
{
	public PrefabReference display; //Field offset: 0x30
	public PrefabReference projectileDisplay; //Field offset: 0x38
	public float percent; //Field offset: 0x40

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 158
	}

	public BeastHandlerPetDisplayStep() { }

	public virtual TowerBehaviorModel get_Def() { }

}

