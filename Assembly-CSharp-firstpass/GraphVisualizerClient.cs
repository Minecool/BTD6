//Type is in global namespace

public class GraphVisualizerClient
{
	private static GraphVisualizerClient s_Instance; //Field offset: 0x0
	private Dictionary<PlayableGraph, String> m_Graphs; //Field offset: 0x10

	public static GraphVisualizerClient instance
	{
		 get { } //Length: 207
	}

	public GraphVisualizerClient() { }

	protected virtual void Finalize() { }

	public static GraphVisualizerClient get_instance() { }

	public static IEnumerable<KeyValuePair`2<PlayableGraph, String>> GetGraphs() { }

	public static void Hide(PlayableGraph graph) { }

	public static void Show(PlayableGraph graph, string name) { }

}

