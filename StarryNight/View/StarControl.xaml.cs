﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StarryNight.View
{
    using System.Windows.Media.Animation;
    /// <summary>
    /// Logika interakcji dla klasy StarControl.xaml
    /// </summary>
    public partial class StarControl : UserControl
    {
        public StarControl()
        {
            InitializeComponent();
        }

        public void FadeIn()
        {
            Storyboard fadeInStoryboard = FindResource("fadeInStoryboard") as Storyboard;
            fadeInStoryboard.Begin();
        }

        public void FadeOut()
        {
            Storyboard fadeOutStoryboard = FindResource("fadeOutStoryboard") as Storyboard;
            fadeOutStoryboard.Begin();
        }
    }
}
