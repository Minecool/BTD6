namespace Assets.Scripts.Unity.Towers.Behaviors.Attack.Behaviors;

public class RandomPositionBasic : TargetTypeBehavior
{
	public RandomPositionBasic parent; //Field offset: 0x98
	public float minRadius; //Field offset: 0xA0
	public string expMinRadius; //Field offset: 0xA8
	public float maxRadius; //Field offset: 0xB0
	public string expMaxRadius; //Field offset: 0xB8
	public float mapBorder; //Field offset: 0xC0
	public string expMapBorder; //Field offset: 0xC8
	public bool useTerrainHeight; //Field offset: 0xD0
	public string expUseTerrainHeight; //Field offset: 0xD8

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 186
	}

	public RandomPositionBasic() { }

	public virtual AttackBehaviorModel get_Def() { }

}

