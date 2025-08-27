namespace UnityEngine;

[RequiredByNativeCode]
public struct Resolution
{
	private int m_Width; //Field offset: 0x0
	private int m_Height; //Field offset: 0x4
	private RefreshRate m_RefreshRate; //Field offset: 0x8

	public int height
	{
		 get { } //Length: 6
		 set { } //Length: 4
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Resolution.refreshRate is obsolete. Use refreshRateRatio instead.", False)]
	public int refreshRate
	{
		 get { } //Length: 278
		 set { } //Length: 11
	}

	public RefreshRate refreshRateRatio
	{
		 get { } //Length: 7
		 set { } //Length: 5
	}

	public int width
	{
		 get { } //Length: 5
		 set { } //Length: 8900
	}

	public int get_height() { }

	public int get_refreshRate() { }

	public RefreshRate get_refreshRateRatio() { }

	public int get_width() { }

	public void set_height(int value) { }

	public void set_refreshRate(int value) { }

	public void set_refreshRateRatio(RefreshRate value) { }

	public void set_width(int value) { }

	public virtual string ToString() { }

}

