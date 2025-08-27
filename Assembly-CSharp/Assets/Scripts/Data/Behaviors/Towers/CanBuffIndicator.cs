namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "CanBuffIndicator", menuName = "BTD6/Behaviors/Towers/CanBuffIndicator")]
public class CanBuffIndicator : TowerBehaviorBuff
{
	public bool isDisabled; //Field offset: 0x38

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 197
	}

	public CanBuffIndicator() { }

	public virtual TowerBehaviorModel get_Def() { }

}

