namespace Assets.Scripts.Unity.Towers.Behaviors;

public class SkimBloons : TowerBehavior
{
	public SkimBloons parent; //Field offset: 0x98
	public float skimAmount; //Field offset: 0xA0
	public string expSkimAmount; //Field offset: 0xA8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 109
	}

	public SkimBloons() { }

	public virtual TowerBehaviorModel get_Def() { }

}

