namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "PatBuffIndicator", menuName = "BTD6/Behaviors/Towers/PatBuffIndicator")]
public class PatBuffIndicator : TowerBehaviorBuff
{
	public bool isDisabled; //Field offset: 0x38

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 197
	}

	public PatBuffIndicator() { }

	public virtual TowerBehaviorModel get_Def() { }

}

