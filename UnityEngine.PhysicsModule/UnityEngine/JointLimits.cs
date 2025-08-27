namespace UnityEngine;

public struct JointLimits
{
	private float m_Min; //Field offset: 0x0
	private float m_Max; //Field offset: 0x4
	private float m_Bounciness; //Field offset: 0x8
	private float m_BounceMinVelocity; //Field offset: 0xC
	private float m_ContactDistance; //Field offset: 0x10
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("minBounce and maxBounce are replaced by a single JointLimits.bounciness for both limit ends.", True)]
	public float minBounce; //Field offset: 0x14
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("minBounce and maxBounce are replaced by a single JointLimits.bounciness for both limit ends.", True)]
	public float maxBounce; //Field offset: 0x18

	public float bounceMinVelocity
	{
		 get { } //Length: 8
		 set { } //Length: 6
	}

	public float bounciness
	{
		 get { } //Length: 8
		 set { } //Length: 6
	}

	public float contactDistance
	{
		 get { } //Length: 8
		 set { } //Length: 6
	}

	public float max
	{
		 get { } //Length: 8
		 set { } //Length: 6
	}

	public float min
	{
		 get { } //Length: 7
		 set { } //Length: 5
	}

	public float get_bounceMinVelocity() { }

	public float get_bounciness() { }

	public float get_contactDistance() { }

	public float get_max() { }

	public float get_min() { }

	public void set_bounceMinVelocity(float value) { }

	public void set_bounciness(float value) { }

	public void set_contactDistance(float value) { }

	public void set_max(float value) { }

	public void set_min(float value) { }

}

