namespace Assets.Scripts.Models.Profile;

public interface ICreatorModel
{

	public string CreationId
	{
		 get { } //Length: 0
	}

	public CustomMapModel CustomMapModel
	{
		 get { } //Length: 0
	}

	public string Name
	{
		 get { } //Length: 0
	}

	protected static string NewId
	{
		 get { } //Length: 85
	}

	public string SharedId
	{
		 get { } //Length: 0
	}

	public string get_CreationId() { }

	public CustomMapModel get_CustomMapModel() { }

	public string get_Name() { }

	protected static string get_NewId() { }

	public string get_SharedId() { }

}

