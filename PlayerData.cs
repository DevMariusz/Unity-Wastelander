using UnityEngine;

//Create a scriptable object.

[CreateAssetMenu(fileName = "Player", menuName = "Player/Player Data", order = 51)]
public class PlayerData : ScriptableObject
{
    [SerializeField]
    private Sprite playerIcon = null;
    public Sprite PlayerIcon { get { return playerIcon; } }

    [SerializeField]
    private string playerName = "none";
    public string PlayerName { get { return playerName; } }

    [SerializeField]
    private float playerHealth = 40;
    public float PlayerHealth { get { return playerHealth; } }
}
