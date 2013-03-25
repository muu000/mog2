using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// 空白ページのアイテム テンプレートについては、http://go.microsoft.com/fwlink/?LinkId=234238 を参照してください

namespace mogtata
{
    /// <summary>
    /// それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
    /// </summary>
    public sealed partial class GamePage : Page
    {
        public GamePage()
        {
            this.InitializeComponent();
        }

        // --- 設定 --- //
       
        TimeSpan Game = new TimeSpan(0, 0, 30); // ゲーム時間
       // TimeSpan 

        ///            ///




        /// <summary>
        /// このページがフレームに表示されるときに呼び出されます。
        /// </summary>
        /// <param name="e">このページにどのように到達したかを説明するイベント データ。Parameter 
        /// プロパティは、通常、ページを構成するために使用します。</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            DispatcherTimer gameTime = new DispatcherTimer();
            DispatcherTimer mog1Time = new DispatcherTimer();
            DispatcherTimer mog2Time = new DispatcherTimer();
            DispatcherTimer mog3Time = new DispatcherTimer();

            gameTime.Interval = Game;
            gameTime.Start();
            gameTime.Tick += gameTime_Tick;


        }

        void gameTime_Tick(object sender, object e)
        {

            Frame.GoBack();
        }

        private void mog1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Storyboard1.Begin();
        }

        private void mog2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Storyboard2.Begin();
        }

        private void mog3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Storyboard3.Begin();
        }
    }
}
