namespace Assets.Scripts.Models.Profile;

public interface ICreatorModelWrapper
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

	public string SharedId
	{
		 get { } //Length: 0
	}

	public void Delete() { }

	public string get_CreationId() { }

	public CustomMapModel get_CustomMapModel() { }

	public string get_Name() { }

	public string get_SharedId() { }

	public Task LoadAsync() { }

	public Task SaveAsync() { }

}

