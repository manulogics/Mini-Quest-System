using UnityEngine;

namespace manulogics.Enemies
{
    public class Enemy
    {
        public EnemyType Type { get; private set; }

        public Enemy(EnemyType type)
        {
            Type = type;
        }
    }
}

