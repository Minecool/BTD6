namespace Assets.Scripts.Data.Legends;

[CreateAssetMenu(menuName = "BTD6/RogueTileMap")]
public class RogueMapTemplate : ScriptableObject
{
	public RogueMapTheme mapTheme; //Field offset: 0x18
	public RogueTileSaveData[] tileData; //Field offset: 0x20

	public RogueMapTemplate() { }

}

