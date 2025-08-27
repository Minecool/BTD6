namespace Assets.Scripts.Data.Skins;

public class SkinsData : ScriptableObject
{
	[ReorderableList("items", True)]
	[SerializeField]
	private SkinContainer SkinList; //Field offset: 0x18

	public IEnumerable<SkinData> Skins
	{
		 get { } //Length: 27
	}

	public SkinsData() { }

	public void AddSkins(SkinData[] skinsToAdd) { }

	public IEnumerable<SkinData> get_Skins() { }

}

