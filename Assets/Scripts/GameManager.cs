using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    public UIDocument btnDoc;
    private float playerHealth, playerAV, enemyAV, playerNoa, enemyNoa;
    public UnityEngine.UIElements.Button patkBtn, eatkBtn, spwnBtn;
    public Label consoleOut, PlayerHP, EnemyHP;
    public Fighter playerprefab, spawnedPlayer;
    public Enemy[] enemyprefab;
    public Enemy spawnedEnemy;
    private bool isPlayerAttacking = true;
    DropdownField menuSelect;

    List<string> choices = new List<string> { "Abomination", "Archer", "Bat", "Bear", "Blob",
            "Camel", "Centaur", "Centipede","Crab", "Cricket", "Cultist", "Devil", "Djinn",
            "Donkey", "Eyeball", "Fighter", "Gascloud", "Horse", "Lich", "Lizard", "Lizardman",
            "Lizardninja", "Monkey", "Mosquitoman", "Mule", "Pegasus", "Rat", "Shade",
            "Skeleton", "Snake", "Snakeman", "Unicorn", "Wolf" };



    void Start()
    {
        

        btnDoc = GetComponent<UIDocument>();
        
        patkBtn = btnDoc.rootVisualElement.Q("LeftAttackButton") as UnityEngine.UIElements.Button;
        eatkBtn = btnDoc.rootVisualElement.Q("RightAtkButton") as UnityEngine.UIElements.Button;
        spwnBtn = btnDoc.rootVisualElement.Q("SpawnEnemyButton") as UnityEngine.UIElements.Button;
        consoleOut = btnDoc.rootVisualElement.Q("Console") as Label;
        PlayerHP = btnDoc.rootVisualElement.Q("PlayerHP") as Label;
        EnemyHP = btnDoc.rootVisualElement.Q("EnemyHP") as Label;
        menuSelect = btnDoc.rootVisualElement.Q("enemyDDField") as DropdownField;

        menuSelect.choices = choices;
        menuSelect.value = choices[0];
        
        Fighter player = Instantiate(playerprefab, new Vector3(-7, 1, 0), Quaternion.identity) as Fighter;
        spawnedPlayer = player;
        Debug.Log(spawnedPlayer.Health.ToString());
        
    
        for (int i = 0; i < enemyprefab.Length; i++)
        {
            enemyprefab[i] = Instantiate(enemyprefab[i], new Vector3(1, 1, 0), Quaternion.identity) as Enemy;
            enemyprefab[i].GetComponent<SpriteRenderer>().enabled = false;
        }

        playerHealth = player.health;
        Debug.Log(playerHealth);
        playerAV = player.attackValue;
        playerNoa = player.numberOfAttacks;

        patkBtn.RegisterCallback<ClickEvent>(OnButtonClickPlayerAtk);

        eatkBtn.RegisterCallback<ClickEvent>(OnButtonClickEnemyAtk);

        spwnBtn.RegisterCallback<ClickEvent>(OnButtonClickSpwnBtn);
     
    }
    void Update()
    {
        PlayerHP.text = spawnedPlayer.Health.ToString();
        if (spawnedEnemy)
        {
            EnemyHP.text = spawnedEnemy.Health.ToString();
        }
        if (isPlayerAttacking)
        {
            eatkBtn.visible = false;
            patkBtn.visible = true;
        }
        else
        {
            eatkBtn.visible = true;
            patkBtn.visible = false;
        }
    }

    public void OnButtonClickPlayerAtk(ClickEvent click)
    {
        consoleOut.text = "You clicked the player's attack button ";
        float av = playerAV * playerNoa;
        spawnedEnemy.Health -= av;
        isPlayerAttacking = false;
    }

    public void OnButtonClickEnemyAtk(ClickEvent click)
    {
        consoleOut.text = "You clicked the enemy's attack button ";
        float av = enemyAV * enemyNoa;
        spawnedPlayer.Health -= av;
        isPlayerAttacking = true;
    }

    public void GetEnemy(Enemy enemy)
    {
        spawnedEnemy = enemy;
        enemyAV = spawnedEnemy.AttackValue;
        enemyNoa = spawnedEnemy.NumberOfAttacks;
        Debug.Log("From within GetEnemy()" + spawnedEnemy.Health.ToString() );
    }
    public void OnButtonClickSpwnBtn(ClickEvent click)
    {
        if(spawnedEnemy)
        {
            spawnedEnemy.GetComponent<SpriteRenderer>().enabled = false;
            spawnedEnemy = null;
        }
        enemyprefab[menuSelect.index].GetComponent<SpriteRenderer>().enabled = true;
        GetEnemy(enemyprefab[menuSelect.index]);
    }
}
