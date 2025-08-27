namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class AddHeatToBloon : ProjectileBehavior
{
	public AddHeatToBloon parent; //Field offset: 0x88
	public float heatAmount; //Field offset: 0x90
	public string expHeatAmount; //Field offset: 0x98

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 118
	}

	public AddHeatToBloon() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

