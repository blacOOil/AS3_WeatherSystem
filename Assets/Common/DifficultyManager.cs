using PhEngine.Core;
using UnityEngine;


namespace SuperGame
{
    public class DifficultyManager : Singleton<DifficultyManager>
    {
        public int DifficultyLevel => difficultyLevel;
        [SerializeField] int difficultyLevel;
        [SerializeField] GameObject difficultyUI;

        public bool isSelected = false;
        
        protected override void InitAfterAwake()
        {
            difficultyUI.SetActive(true);
        }

        public void SelectDifficultyLevel(int value)
        {
            difficultyLevel = value;
            difficultyUI.SetActive(false);
            isSelected = true;
            GameManager.Instance.StartLevel();
            
           

        }
        private void Update()
        {
            if(isSelected == true)
            {
                
            }
        }
    }
}