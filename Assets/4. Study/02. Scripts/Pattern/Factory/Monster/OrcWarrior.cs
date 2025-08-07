using UnityEngine;
using Pattern.Factory;

public class OrcWarrior : Monster
{
    private void Awake()
    {
        Initialize("OrcWarrior", 150, 40);
    }
}
