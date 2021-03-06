﻿using UnityEngine;
using UnityEngine.UI;

namespace ProjectBlue.RepulserEngine.Presentation
{
    public class Overlay : MonoBehaviour, IOverlayPresenter
    {

        [SerializeField] private Image overlayImage;
        [SerializeField] private float fadeTime = 1;

        [SerializeField] private Color warningColor = Color.red;
        [SerializeField] private float defaultAlpha = 0.5f;

        private Color currentColor;
    
        private float time = 0;

        private bool running = false;

        private float fraction = 0;

        private void Start()
        {
            Finish();
        }

        public void Trigger()
        {
            if (running) return;
        
            currentColor = new Color(warningColor.r, warningColor.g, warningColor.b, defaultAlpha);
            overlayImage.enabled = true;
            running = true;
            time = 0;
        }

        private void Finish()
        {
            running = false;
            overlayImage.enabled = false;
        }

        private void Update()
        {
            if (!running) return;
        
            time += Time.deltaTime;

            fraction = time / fadeTime;

            currentColor.a = (1 - fraction) * defaultAlpha;
            overlayImage.color = currentColor;

            if (time > fadeTime)
            {
                Finish();
            }

        }
    
    }

}

