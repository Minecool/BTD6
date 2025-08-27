namespace UnityEngine.U2D;

public class AngleRange : ICloneable
{
	[SerializeField]
	private float m_Start; //Field offset: 0x10
	[SerializeField]
	private float m_End; //Field offset: 0x14
	[SerializeField]
	private int m_Order; //Field offset: 0x18
	[SerializeField]
	private List<Sprite> m_Sprites; //Field offset: 0x20

	public float end
	{
		 get { } //Length: 6
	}

	public int order
	{
		 get { } //Length: 4
	}

	public List<Sprite> sprites
	{
		 get { } //Length: 5
		 set { } //Length: 5
	}

	public float start
	{
		 get { } //Length: 6
	}

	public AngleRange() { }

	public override object Clone() { }

	public virtual bool Equals(object obj) { }

	public float get_end() { }

	public int get_order() { }

	public List<Sprite> get_sprites() { }

	public float get_start() { }

	public virtual int GetHashCode() { }

	public void set_sprites(List<Sprite> value) { }

}

