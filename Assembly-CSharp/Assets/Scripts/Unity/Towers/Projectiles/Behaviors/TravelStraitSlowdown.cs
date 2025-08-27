namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class TravelStraitSlowdown : TravelStrait
{
	public float slowdownSpeed; //Field offset: 0xB0
	public string expSlowdownSpeed; //Field offset: 0xB8
	public float minSpeed; //Field offset: 0xC0
	public string expMinSpeed; //Field offset: 0xC8
	public bool canReducePierce; //Field offset: 0xD0
	public string expCanReducePierce; //Field offset: 0xD8
	public int startingPierce; //Field offset: 0xE0
	public string expStartingPierce; //Field offset: 0xE8
	public int endPierce; //Field offset: 0xF0
	public string expEndPierce; //Field offset: 0xF8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 356
	}

	public TravelStraitSlowdown() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

