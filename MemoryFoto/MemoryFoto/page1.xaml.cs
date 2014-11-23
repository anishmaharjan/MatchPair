using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MemoryFoto
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class page1 : Page
    {
        Random a = new Random();
        int Num, Score = 0;
        BitmapImage Img;
        int[] box = new int[11];
        int[] rect = new int[]{1,2,3,4,5,6,7,8,9,10};


        Stack<int> compare = new Stack<int>();
        Stack<int> bostack = new Stack<int>();
        int count =0;
        public page1()
        {
            this.InitializeComponent();
            
            scoreblock.Text = Score.ToString();
            rarara();      
        }

        public void Increase_Score()
        {
            Score += 4;
            scoreblock.Text = Score.ToString();
            count++;
            if(count == 5 )
            {
                ShowMessage("GAME OVER!! Right Click For New Game");
            }
        }
        public void Decrease_Score()
        {
            Score--;
            Score--;
            scoreblock.Text = Score.ToString();
        }

        private async void ShowMessage(string callmsg)
        {
            // using Windows.UI.Popups;
            MessageDialog messageDialog = new MessageDialog(callmsg);
            await messageDialog.ShowAsync();
        }
        public void rarara()
        {
            Num = a.Next(1, 7);
            switch(Num)
            {
                case 1:
                    Img = new BitmapImage(new Uri("ms-appx:///Assets/1.jpg"));
                    _1.Source = Img;
                    box[1] = 1;

                    Img = new BitmapImage(new Uri("ms-appx:///Assets/2.jpg"));
                    _2.Source = Img;
                    box[2] = 2; 

                    Img = new BitmapImage(new Uri("ms-appx:///Assets/3.jpg"));
                    _3.Source = Img;
                    box[3] = 3;

                    Img = new BitmapImage(new Uri("ms-appx:///Assets/4.jpg"));
                    _4.Source = Img;
                    box[4] = 4;

                    Img = new BitmapImage(new Uri("ms-appx:///Assets/5.jpg"));
                    _5.Source = Img;
                    box[5] = 5;

                    Img = new BitmapImage(new Uri("ms-appx:///Assets/4.jpg"));
                    _6.Source = Img;
                    box[6] = 4;

                    Img = new BitmapImage(new Uri("ms-appx:///Assets/5.jpg"));
                    _7.Source = Img;
                    box[7] = 5;

                    Img = new BitmapImage(new Uri("ms-appx:///Assets/2.jpg"));
                    _8.Source = Img;
                    box[8] = 2;

                    Img = new BitmapImage(new Uri("ms-appx:///Assets/3.jpg"));
                    _9.Source = Img;
                    box[9] = 3;

                    Img = new BitmapImage(new Uri("ms-appx:///Assets/1.jpg"));
                    _10.Source = Img;
                    box[10] = 1;
                                       
                    break;

                case 2:
                    Img = new BitmapImage(new Uri("ms-appx:///Assets/5.jpg"));
                    _1.Source = Img;
                    box[1] = 5;

                    Img = new BitmapImage(new Uri("ms-appx:///Assets/1.jpg"));
                    _2.Source = Img;
                    box[2] = 1;

                    Img = new BitmapImage(new Uri("ms-appx:///Assets/4.jpg"));
                    _3.Source = Img;
                    box[3] = 4;

                    Img = new BitmapImage(new Uri("ms-appx:///Assets/1.jpg"));
                    _4.Source = Img;
                    box[4] = 1;

                    Img = new BitmapImage(new Uri("ms-appx:///Assets/3.jpg"));
                    _5.Source = Img;
                    box[5] = 3;

                    Img = new BitmapImage(new Uri("ms-appx:///Assets/2.jpg"));
                    _6.Source = Img;
                    box[6] = 2;

                    Img = new BitmapImage(new Uri("ms-appx:///Assets/5.jpg"));
                    _7.Source = Img;
                    box[7] = 5;

                    Img = new BitmapImage(new Uri("ms-appx:///Assets/3.jpg"));
                    _8.Source = Img;
                    box[8] = 3;

                    Img = new BitmapImage(new Uri("ms-appx:///Assets/4.jpg"));
                    _9.Source = Img;
                    box[9] = 4;

                    Img = new BitmapImage(new Uri("ms-appx:///Assets/2.jpg"));
                    _10.Source = Img;
                    box[10] = 2;
                    break;

                case 3:
                    Img = new BitmapImage(new Uri("ms-appx:///Assets/3.jpg"));
                    _1.Source = Img;
                    box[1] = 3;

                    Img = new BitmapImage(new Uri("ms-appx:///Assets/1.jpg"));
                    _2.Source = Img;
                    box[2] = 1;

                    Img = new BitmapImage(new Uri("ms-appx:///Assets/2.jpg"));
                    _3.Source = Img;
                    box[3] = 2;

                    Img = new BitmapImage(new Uri("ms-appx:///Assets/3.jpg"));
                    _4.Source = Img;
                    box[4] = 3;

                    Img = new BitmapImage(new Uri("ms-appx:///Assets/5.jpg"));
                    _5.Source = Img;
                    box[5] = 5;

                    Img = new BitmapImage(new Uri("ms-appx:///Assets/1.jpg"));
                    _6.Source = Img;
                    box[6] = 1;

                    Img = new BitmapImage(new Uri("ms-appx:///Assets/2.jpg"));
                    _7.Source = Img;
                    box[7] = 2;

                    Img = new BitmapImage(new Uri("ms-appx:///Assets/5.jpg"));
                    _8.Source = Img;
                    box[8] = 5;

                    Img = new BitmapImage(new Uri("ms-appx:///Assets/4.jpg"));
                    _9.Source = Img;
                    box[9] = 4;

                    Img = new BitmapImage(new Uri("ms-appx:///Assets/4.jpg"));
                    _10.Source = Img;
                    box[10] = 4;

                    break;

                case 4:                   
                    Img = new BitmapImage(new Uri("ms-appx:///Assets/6.jpg"));
                    _1.Source = Img;
                    box[1] = 6;

                    Img = new BitmapImage(new Uri("ms-appx:///Assets/4.jpg"));
                    _2.Source = Img;
                    box[2] = 4;

                    Img = new BitmapImage(new Uri("ms-appx:///Assets/2.jpg"));
                    _3.Source = Img;
                    box[3] = 2;

                    Img = new BitmapImage(new Uri("ms-appx:///Assets/1.jpg"));
                    _4.Source = Img;
                    box[4] = 1;

                    Img = new BitmapImage(new Uri("ms-appx:///Assets/7.jpg"));
                    _5.Source = Img;
                    box[5] = 7;

                    Img = new BitmapImage(new Uri("ms-appx:///Assets/2.jpg"));
                    _6.Source = Img;
                    box[6] = 2;

                    Img = new BitmapImage(new Uri("ms-appx:///Assets/7.jpg"));
                    _7.Source = Img;
                    box[7] = 7;

                    Img = new BitmapImage(new Uri("ms-appx:///Assets/6.jpg"));
                    _8.Source = Img;
                    box[8] = 6;

                    Img = new BitmapImage(new Uri("ms-appx:///Assets/4.jpg"));
                    _9.Source = Img;
                    box[9] = 4;

                    Img = new BitmapImage(new Uri("ms-appx:///Assets/1.jpg"));
                    _10.Source = Img;
                    box[10] = 1;

                    break;

                case 5:
                    Img = new BitmapImage(new Uri("ms-appx:///Assets/5.jpg"));
                    _1.Source = Img;
                    box[1] = 5;

                    Img = new BitmapImage(new Uri("ms-appx:///Assets/8.jpg"));
                    _2.Source = Img;
                    box[2] = 8;

                    Img = new BitmapImage(new Uri("ms-appx:///Assets/6.jpg"));
                    _3.Source = Img;
                    box[3] = 6;

                    Img = new BitmapImage(new Uri("ms-appx:///Assets/6.jpg"));
                    _4.Source = Img;
                    box[4] = 6;

                    Img = new BitmapImage(new Uri("ms-appx:///Assets/7.jpg"));
                    _5.Source = Img;
                    box[5] = 7;

                    Img = new BitmapImage(new Uri("ms-appx:///Assets/4.jpg"));
                    _6.Source = Img;
                    box[6] = 4;

                    Img = new BitmapImage(new Uri("ms-appx:///Assets/5.jpg"));
                    _7.Source = Img;
                    box[7] = 5;

                    Img = new BitmapImage(new Uri("ms-appx:///Assets/7.jpg"));
                    _8.Source = Img;
                    box[8] = 7;

                    Img = new BitmapImage(new Uri("ms-appx:///Assets/4.jpg"));
                    _9.Source = Img;
                    box[9] = 4;

                    Img = new BitmapImage(new Uri("ms-appx:///Assets/8.jpg"));
                    _10.Source = Img;
                    box[10] = 8;

                    break;

                default:
                    Img = new BitmapImage(new Uri("ms-appx:///Assets/8.jpg"));
                    _1.Source = Img;
                    box[1] = 8;

                    Img = new BitmapImage(new Uri("ms-appx:///Assets/3.jpg"));
                    _2.Source = Img;
                    box[2] = 3;

                    Img = new BitmapImage(new Uri("ms-appx:///Assets/10.jpg"));
                    _3.Source = Img;
                    box[3] = 10;

                    Img = new BitmapImage(new Uri("ms-appx:///Assets/9.jpg"));
                    _4.Source = Img;
                    box[4] = 9;

                    Img = new BitmapImage(new Uri("ms-appx:///Assets/8.jpg"));
                    _5.Source = Img;
                    box[5] = 8;

                    Img = new BitmapImage(new Uri("ms-appx:///Assets/2.jpg"));
                    _6.Source = Img;
                    box[6] = 2;

                    Img = new BitmapImage(new Uri("ms-appx:///Assets/9.jpg"));
                    _7.Source = Img;
                    box[7] = 9;

                    Img = new BitmapImage(new Uri("ms-appx:///Assets/3.jpg"));
                    _8.Source = Img;
                    box[8] = 3;

                    Img = new BitmapImage(new Uri("ms-appx:///Assets/2.jpg"));
                    _9.Source = Img;
                    box[9] = 2;

                    Img = new BitmapImage(new Uri("ms-appx:///Assets/10.jpg"));
                    _10.Source = Img;
                    box[10] = 10;

                    break;
                
            }
            
        }
        public async void collapsing(int a, int b)
        {
            await System.Threading.Tasks.Task.Delay(TimeSpan.FromSeconds(1));
            switch(a)
            {
                case 1:
                    _1.Visibility = Visibility.Collapsed;
                    break;

                case 2:                   
                    _2.Visibility = Visibility.Collapsed;
                    break;
                    
                case 3:
                    _3.Visibility = Visibility.Collapsed;
                    break;

                case 4:
                    _4.Visibility = Visibility.Collapsed;
                    break;

                case 5:
                    _5.Visibility = Visibility.Collapsed;
                    break;
                case 6:
                    _6.Visibility = Visibility.Collapsed;
                    break;

                case 7:
                    _7.Visibility = Visibility.Collapsed;
                    break;

                case 8:
                    _8.Visibility = Visibility.Collapsed;
                    break;

                case 9:
                    _9.Visibility = Visibility.Collapsed;
                    break;

                case 10:
                    _10.Visibility = Visibility.Collapsed;
                    break;
            }
            switch (b)
            {
                case 1:
                    _1.Visibility = Visibility.Collapsed;
                    break;

                case 2:
                    _2.Visibility = Visibility.Collapsed;
                    break;

                case 3:
                    _3.Visibility = Visibility.Collapsed;
                    break;

                case 4:
                    _4.Visibility = Visibility.Collapsed;
                    break;

                case 5:
                    _5.Visibility = Visibility.Collapsed;
                    break;
                case 6:
                    _6.Visibility = Visibility.Collapsed;
                    break;

                case 7:
                    _7.Visibility = Visibility.Collapsed;
                    break;

                case 8:
                    _8.Visibility = Visibility.Collapsed;
                    break;

                case 9:
                    _9.Visibility = Visibility.Collapsed;
                    break;

                case 10:
                    _10.Visibility = Visibility.Collapsed;
                    break;
            }
        }
        public async void uncollaps(int a, int b)
        {
            await System.Threading.Tasks.Task.Delay(TimeSpan.FromSeconds(0.5));

            switch (a)
            {
                case 1:
                    aa.Visibility = Visibility.Visible;
                    break;

                case 2:
                    bb.Visibility = Visibility.Visible;
                    break;

                case 3:
                    cc.Visibility = Visibility.Visible;
                    break;

                case 4:
                    dd.Visibility = Visibility.Visible;
                    break;

                case 5:
                    ee.Visibility = Visibility.Visible;
                    break;
                case 6:
                    ff.Visibility = Visibility.Visible;
                    break;

                case 7:
                    gg.Visibility = Visibility.Visible;
                    break;

                case 8:
                    hh.Visibility = Visibility.Visible;
                    break;

                case 9:
                    ii.Visibility = Visibility.Visible;
                    break;

                case 10:
                    jj.Visibility = Visibility.Visible;
                    break;
            }
            switch (b)
            {
                case 1:
                    aa.Visibility = Visibility.Visible;
                    break;

                case 2:
                    bb.Visibility = Visibility.Visible;
                    break;

                case 3:
                    cc.Visibility = Visibility.Visible;
                    break;

                case 4:
                    dd.Visibility = Visibility.Visible;
                    break;

                case 5:
                    ee.Visibility = Visibility.Visible;
                    break;
                case 6:
                    ff.Visibility = Visibility.Visible;
                    break;

                case 7:
                    gg.Visibility = Visibility.Visible;
                    break;

                case 8:
                    hh.Visibility = Visibility.Visible;
                    break;

                case 9:
                    ii.Visibility = Visibility.Visible;
                    break;

                case 10:
                    jj.Visibility = Visibility.Visible;
                    break;
            }
        }
        
        
        private void a_Tapped(object sender, TappedRoutedEventArgs e)
        {          
            aa.Visibility = Visibility.Collapsed;
            compare.Push(box[1]);
            bostack.Push(1);

            if (compare.Count == 2)
            {
                compare.Pop();
                int temp = compare.Pop();
                int send1, send2;
                send1 = bostack.Pop();
                send2 = bostack.Pop();
              
                if (temp == box[1])
                {
                    
                    collapsing(send1, send2);
                    Increase_Score();
             
                }
                else
                {
                    uncollaps(send1, send2);
                    Decrease_Score();
                }
            }
            
        }
        private  void bb_Tapped(object sender, TappedRoutedEventArgs e)
        {
            bb.Visibility = Visibility.Collapsed;
            compare.Push(box[2]);
            bostack.Push(2);

            if (compare.Count == 2)
            {
                compare.Pop();
                int temp = compare.Pop();
                int send1, send2;
                send1 = bostack.Pop();
                send2 = bostack.Pop();
                
                if (temp == box[2])
                {                    
                    collapsing(send1, send2);
                    Increase_Score();
                }
                else
                {
                    uncollaps(send1, send2);
                    Decrease_Score();
                }
            }
        }

        private void cc_Tapped(object sender, TappedRoutedEventArgs e)
        {
            cc.Visibility = Visibility.Collapsed;
            compare.Push(box[3]);
            bostack.Push(3);

            if (compare.Count == 2)
            {
                compare.Pop();
                int temp = compare.Pop();
                int send1, send2;
                send1 = bostack.Pop();
                send2 = bostack.Pop();

                if (temp == box[3])
                {
                    collapsing(send1, send2);
                    Increase_Score();
                }
                else
                {
                    uncollaps(send1, send2);
                    Decrease_Score();
                }
            }
        }

        private void dd_Tapped(object sender, TappedRoutedEventArgs e)
        {
            dd.Visibility = Visibility.Collapsed;
            compare.Push(box[4]);
            bostack.Push(4);

            if (compare.Count == 2)
            {
                compare.Pop();
                int temp = compare.Pop();
                int send1, send2;
                send1 = bostack.Pop();
                send2 = bostack.Pop();

                if (temp == box[4])
                {
                    collapsing(send1, send2);
                    Increase_Score();
                }
                else
                {
                    uncollaps(send1, send2);
                    Decrease_Score();
                }
            }
        }

        private void ee_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ee.Visibility = Visibility.Collapsed;
            compare.Push(box[5]);
            bostack.Push(5);

            if (compare.Count == 2)
            {
                compare.Pop();
                int temp = compare.Pop();
                int send1, send2;
                send1 = bostack.Pop();
                send2 = bostack.Pop();

                if (temp == box[5])
                {
                    collapsing(send1, send2);
                    Increase_Score();
                }
                else
                {
                    uncollaps(send1, send2);
                    Decrease_Score();
                }
            }
        }

        private void ff_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ff.Visibility = Visibility.Collapsed;
            compare.Push(box[6]);
            bostack.Push(6);

            if (compare.Count == 2)
            {
                compare.Pop();
                int temp = compare.Pop();
                int send1, send2;
                send1 = bostack.Pop();
                send2 = bostack.Pop();

                if (temp == box[6])
                {
                    collapsing(send1, send2);
                    Increase_Score();
                }
                else
                {
                    uncollaps(send1, send2);
                    Decrease_Score();
                }
            }
        }

        private void gg_Tapped(object sender, TappedRoutedEventArgs e)
        {
            gg.Visibility = Visibility.Collapsed;
            compare.Push(box[7]);
            bostack.Push(7);

            if (compare.Count == 2)
            {
                compare.Pop();
                int temp = compare.Pop();
                int send1, send2;
                send1 = bostack.Pop();
                send2 = bostack.Pop();

                if (temp == box[7])
                {
                    collapsing(send1, send2);
                    Increase_Score();
                }
                else
                {
                    uncollaps(send1, send2);
                    Decrease_Score();
                }
            }
        }

        private void hh_Tapped(object sender, TappedRoutedEventArgs e)
        {
            hh.Visibility = Visibility.Collapsed;
            compare.Push(box[8]);
            bostack.Push(8);

            if (compare.Count == 2)
            {
                compare.Pop();
                int temp = compare.Pop();
                int send1, send2;
                send1 = bostack.Pop();
                send2 = bostack.Pop();

                if (temp == box[8])
                {
                    collapsing(send1, send2);
                    Increase_Score();
                }
                else
                {
                    uncollaps(send1, send2);
                    Decrease_Score();
                }
            }
        }

        private void ii_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ii.Visibility = Visibility.Collapsed;
            compare.Push(box[9]);
            bostack.Push(9);

            if (compare.Count == 2)
            {
                compare.Pop();
                int temp = compare.Pop();
                int send1, send2;
                send1 = bostack.Pop();
                send2 = bostack.Pop();

                if (temp == box[9])
                {
                    collapsing(send1, send2);
                    Increase_Score();
                }
                else
                {
                    uncollaps(send1, send2);
                    Decrease_Score();
                }
            }
        }

        private void jj_Tapped(object sender, TappedRoutedEventArgs e)
        {
            jj.Visibility = Visibility.Collapsed;
            compare.Push(box[10]);
            bostack.Push(10);

            if (compare.Count == 2)
            {
                compare.Pop();
                int temp = compare.Pop();
                int send1, send2;
                send1 = bostack.Pop();
                send2 = bostack.Pop();

                if (temp == box[10])
                {
                    collapsing(send1, send2);
                    Increase_Score();
                }
                else
                {
                    uncollaps(send1, send2);
                    Decrease_Score();
                }
            }
        }

        private void Button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Application.Current.Exit();
        }

        private void newdeal_Tapped(object sender, TappedRoutedEventArgs e)
        {
            rarara();
            //Score = 0;
            scoreblock.Text = Score.ToString();
            aa.Visibility = Visibility.Visible;
            bb.Visibility = Visibility.Visible;
            cc.Visibility = Visibility.Visible;
            dd.Visibility = Visibility.Visible;
            ee.Visibility = Visibility.Visible;
            ff.Visibility = Visibility.Visible;
            gg.Visibility = Visibility.Visible;
            hh.Visibility = Visibility.Visible;
            ii.Visibility = Visibility.Visible;
            jj.Visibility = Visibility.Visible;

            _1.Visibility = Visibility.Visible;
            _2.Visibility = Visibility.Visible;
            _3.Visibility = Visibility.Visible;
            _4.Visibility = Visibility.Visible;
            _5.Visibility = Visibility.Visible;
            _6.Visibility = Visibility.Visible;
            _7.Visibility = Visibility.Visible;
            _8.Visibility = Visibility.Visible;
            _9.Visibility = Visibility.Visible;
            _10.Visibility = Visibility.Visible;
        }

        private void reset_Tapped(object sender, TappedRoutedEventArgs e)
        {
            rarara();
            Score = 0;
            scoreblock.Text = Score.ToString();
            aa.Visibility = Visibility.Visible;
            bb.Visibility = Visibility.Visible;
            cc.Visibility = Visibility.Visible;
            dd.Visibility = Visibility.Visible;
            ee.Visibility = Visibility.Visible;
            ff.Visibility = Visibility.Visible;
            gg.Visibility = Visibility.Visible;
            hh.Visibility = Visibility.Visible;
            ii.Visibility = Visibility.Visible;
            jj.Visibility = Visibility.Visible;

            _1.Visibility = Visibility.Visible;
            _2.Visibility = Visibility.Visible;
            _3.Visibility = Visibility.Visible;
            _4.Visibility = Visibility.Visible;
            _5.Visibility = Visibility.Visible;
            _6.Visibility = Visibility.Visible;
            _7.Visibility = Visibility.Visible;
            _8.Visibility = Visibility.Visible;
            _9.Visibility = Visibility.Visible;
            _10.Visibility = Visibility.Visible;

        }

        private async void about_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MessageDialog newmessage = new MessageDialog("This app is simply for people who knows Dota and through first plain game Windows App development programme.", "About");
            await newmessage.ShowAsync();
        }

        private async void credits_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MessageDialog newmessage = new MessageDialog("Credits to all the class mates that helped me in this first project. ", "Credits");
            await newmessage.ShowAsync();
        }

       
    }

        
}

