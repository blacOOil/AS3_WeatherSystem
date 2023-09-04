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
        public bool isWeatherSelected = false;

        protected override void InitAfterAwake()
        {
            difficultyUI.SetActive(true);
            
        }

        public void SelectDifficultyLevel(int value)
        {
            difficultyLevel = value;
            difficultyUI.SetActive(false);
            isSelected = true;
            if (isWeatherSelected == false)
            {
                WeatherOPtionUI.Instance.WeatherSelectioning();
                
            }
            else
            {
                GameManager.Instance.StartLevel();
            }
        }
        public void WeatherOkay()
        {
            isWeatherSelected = true;
            
        }
      
    }
}