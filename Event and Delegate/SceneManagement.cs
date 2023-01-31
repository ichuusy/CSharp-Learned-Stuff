using System;

namespace EventAndDelegates
{
	internal class Program
	{

		public static void Main(string[] args)
		{
			SceneManagement sceneManagement = new SceneManagement();
			sceneManagement.sceneLoaded += OnSceneLoaded;
			sceneManagement.Call();

		}

		static void OnSceneLoaded(string scene,string loadSceneMode)
		{
			Console.WriteLine($"Scene changed.\tCurrent scene : {scene}\tScene mode : {loadSceneMode}");
		}
	}

	public class SceneManagement
	{
		public delegate void SceneEventHandler(string scene, string loadSceneMode);
		public event SceneEventHandler sceneLoaded;

		public void Call()
		{
			sceneLoaded("1","Normal");
		}
		
	}
}
