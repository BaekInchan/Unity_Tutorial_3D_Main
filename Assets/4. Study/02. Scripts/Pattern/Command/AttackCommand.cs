using UnityEngine;
using Pattern.Command;

public class AttackCommand : ICommand
{
    private Player player;
    public AttackCommand(Player player)
    {
        this.player = player;
    }

    public void Cancel()
    {
        player.AttackCancel();
    }

    public void Execute()
    {
        player.Attack();
    }
}
