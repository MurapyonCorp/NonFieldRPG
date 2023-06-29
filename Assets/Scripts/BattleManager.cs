using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// PlayerとEnemyの対戦の管理
public class BattleManager : MonoBehaviour
{
  public PlayerUIManager playerUI;
  public EnemyUIManager enemyUI;
  public PlayerManager player;
  EnemyManager enemy;

  // 初期設定
  public void Setup(EnemyManager enemyManager)
  {
    enemy = enemyManager;
    enemyUI.SetupUI(enemy);
    playerUI.SetupUI(player);

    enemy.addEventListenerOnTap(PlayerAttack);
  }

  void PlayerAttack()
  {
    player.Attack(enemy);
    enemyUI.UpdateUI(enemy);
    if (enemy.hp <= 0)
    {

    }
    else
    {

    }
  }

  void EnemyAttack()
  {
    enemy.Attack(player);
    playerUI.UpdateUI(player);
  }
}
