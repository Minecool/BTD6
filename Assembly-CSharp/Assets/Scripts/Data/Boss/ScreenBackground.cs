namespace Assets.Scripts.Data.Boss;

public class ScreenBackground
{
	public string screenName; //Field offset: 0x10
	public bool useOwnOrNoBackground; //Field offset: 0x18
	public TextureReference bgTextureRef; //Field offset: 0x20
	public Color color; //Field offset: 0x28
	public float tilesPerHeight; //Field offset: 0x38
	public float vignetteMul; //Field offset: 0x3C

	public ScreenBackground() { }

}

