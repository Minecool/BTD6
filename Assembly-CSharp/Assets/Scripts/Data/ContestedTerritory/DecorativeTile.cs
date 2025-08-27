namespace Assets.Scripts.Data.ContestedTerritory;

public class DecorativeTile
{
	public string id; //Field offset: 0x10
	public EventName forEvent; //Field offset: 0x18
	public PrefabReference prefab; //Field offset: 0x20
	public float relativeFrequency; //Field offset: 0x28

	public DecorativeTile() { }

}

