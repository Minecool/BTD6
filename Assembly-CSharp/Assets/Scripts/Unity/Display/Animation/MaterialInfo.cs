namespace Assets.Scripts.Unity.Display.Animation;

public class MaterialInfo
{
	public string id; //Field offset: 0x10
	public String[] textureNames; //Field offset: 0x18
	public Rect[] rectangles; //Field offset: 0x20

	public MaterialInfo() { }

	public Nullable<Rect> FindRect(string textureName) { }

}

