namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "Syphon", menuName = "BTD6/Behaviors/Towers/Syphon")]
public class Syphon : TowerBehavior
{
	public string mutationId; //Field offset: 0x30
	public float multiplier; //Field offset: 0x38
	public int charges; //Field offset: 0x3C
	public float lifespan; //Field offset: 0x40
	public string ignoreTags; //Field offset: 0x48
	public string overlayType; //Field offset: 0x50
	public int overlayLayer; //Field offset: 0x58

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 250
	}

	public Syphon() { }

	public virtual TowerBehaviorModel get_Def() { }

}

