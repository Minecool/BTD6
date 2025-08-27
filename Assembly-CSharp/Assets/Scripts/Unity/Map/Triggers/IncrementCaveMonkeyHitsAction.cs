namespace Assets.Scripts.Unity.Map.Triggers;

public class IncrementCaveMonkeyHitsAction : MapAction
{
	private IncrementCaveMonkeyHitsActionModel incrementCaveMonkeyHitsModel; //Field offset: 0x20
	public int amount; //Field offset: 0x28

	public virtual MapActionModel Def
	{
		 get { } //Length: 145
	}

	public IncrementCaveMonkeyHitsAction() { }

	public virtual MapActionModel get_Def() { }

}

