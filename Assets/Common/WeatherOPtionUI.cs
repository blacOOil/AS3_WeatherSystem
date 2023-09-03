using System.Collections;
using System.Collections.Generic;
using PhEngine.Core;
using UnityEngine;
using UnityEngine.UI;
using SuperGame;

namespace SuperGame
{
    public class WeatherOPtionUI : Singleton<WeatherOPtionUI>
    {
        SuperGame.DifficultyManager difficultyManager = new DifficultyManager();
        [SerializeField] GameObject WeatherSelectionPanel;

      
        protected override void InitAfterAwake()
        {
            WeatherSelectionPanel.SetActive(false);
        }

        void Update()
        {
        
            {

            }

        }
        public void NotifyOnDifficultySelection()
        {
            WeatherSelectionPanel.SetActive(true);
        }
    }
}