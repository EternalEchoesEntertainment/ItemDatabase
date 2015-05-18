using UnityEditor;
using UnityEngine;
using System.Collections;

namespace Echoes.Itemsystem.Editor
{
	public class ISQualityDatabaseEditor : EditorWindow 
	{
		ISQualityDatabase db;


		const string FILE_NAME = @"echoesQualityDatabase.asset";
		const string FOLDER_NAME = @"Database";
		const string DATABASE_PATH = @"Assets/" + FOLDER_NAME + "/" + FILE_NAME;



		[MenuItem("Echoes/Database/Quality Editor %#i")]
		public static void Init()
		{
			ISQualityDatabaseEditor window = EditorWindow.GetWindow<ISQualityDatabaseEditor>();
			window.minSize = new Vector2 (400, 300);
			window.title = "Quality DB";
			window.Show ();
		}

		void OnEnable()
		{
			db = AssetDatabase.LoadAssetAtPath (DATABASE_PATH, typeof(ISQualityDatabase)) as ISQualityDatabase;

			if (db == null)
			{
				if (!AssetDatabase.IsValidFolder("Assets/" + FOLDER_NAME))
				{
					AssetDatabase.CreateFolder("Assets", FOLDER_NAME);
				}

				db = ScriptableObject.CreateInstance<ISQualityDatabase>();
				AssetDatabase.CreateAsset(db, DATABASE_PATH);
				AssetDatabase.SaveAssets ();
				AssetDatabase.Refresh();
			}
		}
	}
}