namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "StartOfRoundRateBuff", menuName = "BTD6/Behaviors/Towers/StartOfRoundRateBuff")]
public class StartOfRoundRateBuff : TowerBehavior
{
	public float modifier; //Field offset: 0x30
	public float duration; //Field offset: 0x34

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 159
	}

	public StartOfRoundRateBuff() { }

	public virtual TowerBehaviorModel get_Def() { }

}

