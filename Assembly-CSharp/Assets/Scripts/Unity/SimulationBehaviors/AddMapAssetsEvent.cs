namespace Assets.Scripts.Unity.SimulationBehaviors;

public class AddMapAssetsEvent : SimulationBehavior
{
	public bool disableAmbientMapFx; //Field offset: 0x18
	public PrefabReference[] fXPrefabs; //Field offset: 0x20

	public virtual Model Model
	{
		 get { } //Length: 106
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public AddMapAssetsEvent() { }

	public virtual Model get_Model() { }

	public virtual string get_Type() { }

}

