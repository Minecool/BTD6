namespace Assets.Scripts.Unity.Towers.Behaviors;

public class Syphon : TowerBehavior
{
	public Syphon parent; //Field offset: 0x98
	public string mutationId; //Field offset: 0xA0
	public string expMutationId; //Field offset: 0xA8
	public float multiplier; //Field offset: 0xB0
	public string expMultiplier; //Field offset: 0xB8
	public int charges; //Field offset: 0xC0
	public string expCharges; //Field offset: 0xC8
	public float lifespan; //Field offset: 0xD0
	public string expLifespan; //Field offset: 0xD8
	public string ignoreTags; //Field offset: 0xE0
	public string expIgnoreTags; //Field offset: 0xE8
	public string overlayType; //Field offset: 0xF0
	public string expOverlayType; //Field offset: 0xF8
	public int overlayLayer; //Field offset: 0x100
	public string expOverlayLayer; //Field offset: 0x108

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 268
	}

	public Syphon() { }

	public virtual TowerBehaviorModel get_Def() { }

}

