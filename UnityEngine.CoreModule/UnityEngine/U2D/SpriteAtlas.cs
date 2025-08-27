namespace UnityEngine.U2D;

[NativeHeader("Runtime/Graphics/SpriteFrame.h")]
[NativeType(Header = "Runtime/2D/SpriteAtlas/SpriteAtlas.h")]
public class SpriteAtlas : object
{

	public bool isVariant
	{
		[NativeMethod("IsVariant")]
		 get { } //Length: 51
	}

	public int spriteCount
	{
		 get { } //Length: 51
	}

	public string tag
	{
		 get { } //Length: 51
	}

	public SpriteAtlas() { }

	public bool CanBindTo(Sprite sprite) { }

	[NativeMethod("IsVariant")]
	public bool get_isVariant() { }

	public int get_spriteCount() { }

	public string get_tag() { }

	public Sprite GetSprite(string name) { }

	public int GetSprites(Sprite[] sprites) { }

	public int GetSprites(Sprite[] sprites, string name) { }

	private int GetSpritesScripting(Sprite[] sprites) { }

	private int GetSpritesWithNameScripting(Sprite[] sprites, string name) { }

}

