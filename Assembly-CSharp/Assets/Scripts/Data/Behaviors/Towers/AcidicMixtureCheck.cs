namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "AcidicMixtureCheck", menuName = "BTD6/Behaviors/Towers/AcidicMixtureCheck")]
public class AcidicMixtureCheck : TowerBehavior
{
	public int maxCount; //Field offset: 0x30
	public string mutationId; //Field offset: 0x38

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 127
	}

	public AcidicMixtureCheck() { }

	public virtual TowerBehaviorModel get_Def() { }

}

