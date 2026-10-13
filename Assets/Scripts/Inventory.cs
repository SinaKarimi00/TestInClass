using UnityEngine;

namespace DefaultNamespace
{
    public class Inventory : MonoBehaviour
    {
        private int coin;

        private int health;


        public bool IsPlayerAlive() => health > 0;

        public int Coin
        {
            get { return coin; }
            private set
            {
                if (coin < 0)
                    return;

                this.coin += coin;
            }
        }

        private bool IsUserOnline() => true;
        // {
        //     return true;
        // }


        //
        // public int GetCurrentCoin()
        // {
        //     return coin;
        // }
        //
        // public void SetCoin(int coin)
        // {
        //     if (coin < 0)
        //         return;
        //
        //     this.coin = coin;
        // }
    }
}