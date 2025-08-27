namespace Assets.Scripts.Data.ContestedTerritory;

public class TeamDetail
{
	public MaterialReference homeTileMaterial; //Field offset: 0x10
	public MaterialReference homeTileColourblindMaterial; //Field offset: 0x18
	public MaterialReference highlightTileMaterial; //Field offset: 0x20
	public MaterialReference openSeasonHighlightTileMaterial; //Field offset: 0x28
	public Color teamColor; //Field offset: 0x30
	public SpriteReference teamColorBanner; //Field offset: 0x40
	public SpriteReference colorBlindIcon; //Field offset: 0x48
	public string colourName; //Field offset: 0x50

	public TeamDetail() { }

}

