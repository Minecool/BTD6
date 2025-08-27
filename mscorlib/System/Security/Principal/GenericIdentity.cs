namespace System.Security.Principal;

public class GenericIdentity : ClaimsIdentity
{
	private readonly string m_name; //Field offset: 0x78
	private readonly string m_type; //Field offset: 0x80

	public virtual string AuthenticationType
	{
		 get { } //Length: 8
	}

	public virtual IEnumerable<Claim> Claims
	{
		 get { } //Length: 101
	}

	public virtual string Name
	{
		 get { } //Length: 70
	}

	public GenericIdentity(string name, string type) { }

	private GenericIdentity() { }

	protected GenericIdentity(GenericIdentity identity) { }

	private void AddNameClaim() { }

	public virtual ClaimsIdentity Clone() { }

	public virtual string get_AuthenticationType() { }

	public virtual IEnumerable<Claim> get_Claims() { }

	public virtual string get_Name() { }

}

