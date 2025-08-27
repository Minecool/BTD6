namespace UnityEngine.Rendering;

[AttributeUsage(20, AllowMultiple = False)]
[Conditional("UNITY_EDITOR")]
public class CurrentPipelineHelpURLAttribute : HelpURLAttribute
{
	[CompilerGenerated]
	private readonly string <pageName>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private readonly string <pageHash>k__BackingField; //Field offset: 0x30

	private string pageHash
	{
		[CompilerGenerated]
		private get { } //Length: 5
	}

	private string pageName
	{
		[CompilerGenerated]
		private get { } //Length: 5
	}

	public virtual string URL
	{
		 get { } //Length: 18
	}

	public CurrentPipelineHelpURLAttribute(string pageName, string pageHash = "") { }

	[CompilerGenerated]
	private string get_pageHash() { }

	[CompilerGenerated]
	private string get_pageName() { }

	public virtual string get_URL() { }

}

