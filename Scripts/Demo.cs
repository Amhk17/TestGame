using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo: MonoBehaviour
{
	protected EnemyData enemyData;

	void Start ()
	{
		// Load instance of /Settings/Enemies.csv from /Resources created by SettingsAutoConverter Class
		LoadEnemy("Enemy1");
		// Unload Database from assets, its optimum
		UnloadEnemy();
	}

	private void LoadEnemy(string name){
		enemyData = Resources.Load<EnemyData>(name);
		Debug.Log (enemyData.name);
	}

	private void UnloadEnemy(){
		enemyData = null;
		Resources.UnloadUnusedAssets();
	}
}
