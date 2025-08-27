namespace Assets.Scripts.Unity.SimulationBehaviors;

public class AddMapAssetsEvent : SimulationBehavior
{
	public bool disableAmbientMapFx; //Field offset: 0x18
	public PrefabReference[] fXPrefabs; //Field offset: 0x20

	public virtual SimulationBehaviorModel Def
	{
		 get { } //Length: 106
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public AddMapAssetsEvent() { }

	public virtual SimulationBehaviorModel get_Def() { }

	public virtual string get_Type() { }

}

