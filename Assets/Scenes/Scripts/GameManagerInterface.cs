using UnityEngine;
namespace gameUtils{
    public interface IGameManager
    {
        public void checkVictory();
        public void Player1Scored();
        public void Player2Scored();
    }
}
