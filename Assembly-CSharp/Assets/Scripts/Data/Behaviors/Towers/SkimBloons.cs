namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "SkimBloons", menuName = "BTD6/Behaviors/Towers/SkimBloons")]
public class SkimBloons : TowerBehavior
{
	public float skimAmount; //Field offset: 0x30

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 106
	}

	public SkimBloons() { }

	public virtual TowerBehaviorModel get_Def() { }

}

