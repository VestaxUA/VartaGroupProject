using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyMenuCreate : MonoBehaviour
{
    [SerializeField]
    private GameObject targetEnemyUnitPrefab;
    [SerializeField]
    private Vector2 initialPosition, itemDimensions;
    [SerializeField]
    private KillEnemy killEnemyScript;
    // Use this for initialization
    void Awake()
    {
        GameObject enemyUnitsMenu = GameObject.Find("EnemyMenu");
        GameObject[] existingItems = GameObject.FindGameObjectsWithTag("TargetButton");
        Vector2 nextPosition = new Vector2(this.initialPosition.x + (existingItems.Length * this.itemDimensions.x), this.initialPosition.y);
        GameObject targetEnemyUnit = Instantiate(this.targetEnemyUnitPrefab, enemyUnitsMenu.transform) as GameObject;
        targetEnemyUnit.name = "Target" + this.gameObject.name;
        targetEnemyUnit.transform.localPosition = nextPosition;
        targetEnemyUnit.transform.localScale = new Vector2(0.7f, 0.7f);
        targetEnemyUnit.GetComponent<Button>().onClick.AddListener(() => selectEnemyTarget());
        killEnemyScript.menuItem = targetEnemyUnit;
    }
    public void selectEnemyTarget()
    {

    }
}
