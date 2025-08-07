using UnityEngine;

namespace Pattern.Deco
{

    public class Player : MonoBehaviour
    {
        void Start()
        {
            IAttack attack = new BasicAttack();

            attack = new FireAttack(attack);
            attack.Execute();

            attack = new IceAttack(attack);
            attack.Execute();
        }

    }
}
