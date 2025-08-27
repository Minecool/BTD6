namespace Assets.Scripts.Data.Feats;

[CreateAssetMenu(fileName = "LegendsFeatData", menuName = "BTD6/LegendsFeatData")]
public class LegendsFeatData : ScriptableObject
{
	public int featId; //Field offset: 0x18
	public SpriteReference icon; //Field offset: 0x20
	public int goal; //Field offset: 0x28
	public bool hidden; //Field offset: 0x2C
	public string subscript; //Field offset: 0x30
	public FeatType featType; //Field offset: 0x38
	public LegendType legendType; //Field offset: 0x3C
	[TypeSelectionAsString("Assets.Scripts.Unity.Feats.List", typeof(LegendsFeatActive))]
	public string classType; //Field offset: 0x40

	public LegendsFeatData() { }

}

