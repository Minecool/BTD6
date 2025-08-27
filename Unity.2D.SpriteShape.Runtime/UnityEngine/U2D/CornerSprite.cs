namespace UnityEngine.U2D;

public class CornerSprite : ICloneable
{
	[SerializeField]
	private CornerType m_CornerType; //Field offset: 0x10
	[SerializeField]
	private List<Sprite> m_Sprites; //Field offset: 0x18

	public CornerType cornerType
	{
		 get { } //Length: 94
		 set { } //Length: 4
	}

	public List<Sprite> sprites
	{
		 get { } //Length: 5
		 set { } //Length: 5
	}

	public CornerSprite() { }

	public override object Clone() { }

	public virtual bool Equals(object obj) { }

	public CornerType get_cornerType() { }

	public List<Sprite> get_sprites() { }

	public virtual int GetHashCode() { }

	public void set_cornerType(CornerType value) { }

	public void set_sprites(List<Sprite> value) { }

}

