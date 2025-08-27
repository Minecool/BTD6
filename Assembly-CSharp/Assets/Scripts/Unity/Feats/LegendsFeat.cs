namespace Assets.Scripts.Unity.Feats;

public class LegendsFeat
{
	public int featId; //Field offset: 0x10
	public SpriteReference icon; //Field offset: 0x18
	public int goal; //Field offset: 0x20
	public string loot; //Field offset: 0x28
	public bool hidden; //Field offset: 0x30
	[TypeSelectionAsString("Assets.Scripts.Unity.Feats.List", typeof(LegendsFeatActive))]
	public string type; //Field offset: 0x38

	public LegendsFeat() { }

}

