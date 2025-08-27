namespace UnityEngine.U2D;

[HelpURL("https://docs.unity3d.com/Packages/com.unity.2d.spriteshape@latest/index.html?subfolder=/manual/SSProfile.html")]
public class SpriteShape : ScriptableObject
{
	[SerializeField]
	private List<AngleRange> m_Angles; //Field offset: 0x18
	[SerializeField]
	private Texture2D m_FillTexture; //Field offset: 0x20
	[SerializeField]
	private List<CornerSprite> m_CornerSprites; //Field offset: 0x28
	[SerializeField]
	private float m_FillOffset; //Field offset: 0x30
	[SerializeField]
	private bool m_UseSpriteBorders; //Field offset: 0x34

	public List<AngleRange> angleRanges
	{
		 get { } //Length: 5
		 set { } //Length: 5
	}

	public List<CornerSprite> cornerSprites
	{
		 get { } //Length: 5
		 set { } //Length: 5
	}

	public float fillOffset
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public Texture2D fillTexture
	{
		 get { } //Length: 5
		 set { } //Length: 5
	}

	public bool useSpriteBorders
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public SpriteShape() { }

	public List<AngleRange> get_angleRanges() { }

	public List<CornerSprite> get_cornerSprites() { }

	public float get_fillOffset() { }

	public Texture2D get_fillTexture() { }

	public bool get_useSpriteBorders() { }

	private CornerSprite GetCornerSprite(CornerType cornerType) { }

	internal static int GetSpriteShapeHashCode(SpriteShape spriteShape) { }

	private void OnValidate() { }

	private void Reset() { }

	private void ResetCornerList() { }

	public void set_angleRanges(List<AngleRange> value) { }

	public void set_cornerSprites(List<CornerSprite> value) { }

	public void set_fillOffset(float value) { }

	public void set_fillTexture(Texture2D value) { }

	public void set_useSpriteBorders(bool value) { }

}

