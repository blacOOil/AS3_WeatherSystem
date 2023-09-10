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
        public void WeatherSelectioning()
        {
            WeatherSelectionPanel.SetActive(true);

        }
        public void WeatherSelected(int value)
        {
            if (value > 0)
            {
                WeatherSelectionPanel.SetActive(false);
            }
        }

    }
}